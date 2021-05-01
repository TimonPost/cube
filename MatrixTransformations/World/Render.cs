using System.Collections.Generic;
using MatrixTransformations.Math;

namespace MatrixTransformations.World
{
    public class Camera
    {
        public Matrix GetMatrix()
        {
            return Matrix.CreateLookAt(Position, LookAt, UpVector);
        }

        public Vector UpVector = new Vector(0, 1, 0);

        public Vector LookAt { get; set; } = new Vector(0,0,0);
        
        public Vector Position { get; set; } =  new Vector(0, 0, 3);
    }

    public class Render
    {
        public Render(Camera camera)
        {
            Camera= camera;
        }

        public Camera Camera { get; set; }

        public IReadOnlyList<Vector> Transform(IReadOnlyList<Vector> objectCoordinates, float width, float height, Vector scale, Vector rotate, Vector translate)
        {
            List<Vector> transformedVertexes = new List<Vector>(objectCoordinates.Count);

            var modelMatrix = ModelTransformation(scale, rotate, translate);
            var viewMatrix = Camera.GetMatrix();

            for (var i = 0; i < objectCoordinates.Count; i++)
            {
                Vector model = objectCoordinates[i];
                model.w = 1;
                
                var world = Vector.Transform(model, modelMatrix);
                world.w = 1;
                
                var view = Vector.Transform(world, viewMatrix);

                var projection = ProjectionTransformation(2, view.z);
                
                Vector projected = Vector.Transform(view, projection);

                //Scale to screen
                projected.x = (projected.x + 1f) * width * 0.5f;
                projected.y = (1f - projected.y) * height * 0.5f;
                transformedVertexes.Add(projected);
            }

            return transformedVertexes;
        }

        public static Matrix ModelTransformation(Vector scale, Vector rotate, Vector translate)
        {
            var scaleMatrix = Matrix.Scale(scale);
            var rotationMatrixX = Matrix.RotateX(rotate.x);
            var rotationMatrixY = Matrix.RotateY(rotate.y);
            var rotationMatrixZ = Matrix.RotateZ(rotate.z);
            var translateMatrix = Matrix.CreateTranslation(translate);

            return translateMatrix * scaleMatrix * rotationMatrixX * rotationMatrixY * rotationMatrixZ;
        }

        public static Matrix ProjectionTransformation(float distance, float z)
        {
            float projectedZ = 1 / (distance - z);
            var projectionMatrix = new Matrix(
                projectedZ, 0, 0, 0,
                0, projectedZ, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
            );
            return projectionMatrix;
        }
    }
}
