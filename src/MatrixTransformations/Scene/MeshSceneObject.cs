using System.Drawing;

namespace MatrixTransformations
{
    public class MeshSceneObject : SceneObject
    {
        protected readonly Renderer Renderer;

        public MeshSceneObject(Mesh mesh, Renderer renderer)
        {
            Renderer = renderer;
            Mesh = mesh;
        }

        public override void Draw(Graphics graphics, Matrix viewMatrix)
        {
            Renderer.Draw(graphics, Mesh.VertexBuffer, Mesh.IndexBuffer,
                Matrix.ModelTransformation(Scale, Rotation, Position) * viewMatrix);
        }

        public override void Update()
        {
        }

        public Vector Rotation = new Vector();
        public Vector Position = new Vector();
        public Vector Scale = new Vector(1, 1, 1, 1);

        public Mesh Mesh { get; }
    }
}