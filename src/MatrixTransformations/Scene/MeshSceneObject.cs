using System.Drawing;
using MatrixTransformations.Animation;
using MatrixTransformations.MathCustom;

namespace MatrixTransformations.World
{
    public class MeshSceneObject : SceneObject
    {
        private readonly Renderer _renderer;
        
        public MeshSceneObject(Mesh mesh, Renderer renderer)
        {
            _renderer = renderer;
            Mesh = mesh;
        }

        public override void Draw(Graphics graphics, Matrix viewMatrix)
        {
            _renderer.Draw(graphics, Mesh.VertexBuffer, Mesh.IndexBuffer, Matrix.ModelTransformation(Scale, Rotation, Position) * viewMatrix);
        }

        public override void Update()
        {
        }

        public Vector Rotation  = new Vector();
        public Vector Position  = new Vector();
        public Vector Scale = new Vector(1,1,1,1);

        public Mesh Mesh { get; }
    }
}