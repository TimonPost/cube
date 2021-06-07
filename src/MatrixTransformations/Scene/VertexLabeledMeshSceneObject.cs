using System.Drawing;
using MatrixTransformations.Math;

namespace MatrixTransformations.World
{
    public class VertexLabeledMeshSceneObject : MeshSceneObject
    {
        public VertexLabeledMeshSceneObject(Mesh mesh, Renderer renderer) : base(mesh, renderer)
        {
        }

        public override void Draw(Graphics graphics, Matrix viewMatrix)
        {
            var modeViewMatrix = Matrix.ModelTransformation(Scale, Rotation, Position) * viewMatrix;
            for (var index = 0; index < Mesh.VertexBuffer.Count; index++)
            {
                Vertex vertex = Mesh.VertexBuffer[index];
                Renderer.DrawText(graphics, index.ToString(), Color.White, vertex.Vector, modeViewMatrix);
            }

            base.Draw(graphics, viewMatrix);
        }
    }
}