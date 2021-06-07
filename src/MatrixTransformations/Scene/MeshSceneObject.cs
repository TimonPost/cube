using System.Drawing;
using MatrixTransformations.Animation;
using MatrixTransformations.Math;

namespace MatrixTransformations.World
{
    public class MeshSceneObject : SceneObject
    {
        private readonly Renderer _renderer;
        private readonly IAnimationFiniteStateMachine _stateMachine;

        public MeshSceneObject(Mesh mesh, Renderer renderer, IAnimationFiniteStateMachine stateMachine = null)
        {
            _renderer = renderer;
            _stateMachine = stateMachine;
            Mesh = mesh;
        }

        public override void Draw(Graphics graphics, Matrix viewMatrix)
        {
            _renderer.Draw(graphics, Mesh.VertexBuffer, Mesh.IndexBuffer, Matrix.ModelTransformation(Scale, Rotation, Position) * viewMatrix);
        }

        public override void Update()
        {
            if (_stateMachine != null)
            {
                _stateMachine.Tick(new CubeAnimationData(Rotation, Scale, Position));
            }
        }

        public Vector Rotation { get; set; } = new Vector();
        public Vector Position { get; set; } = new Vector();
        public Vector Scale { get; set; } = new Vector(1,1,1,1);

        public Mesh Mesh { get; }
    }
}