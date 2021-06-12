using System.Drawing;
using PropertyChanged;

namespace CubeAssignment.Gui.Scene
{
    /// <summary>
    /// Represents a Mesh SceneObject
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class MeshSceneObject : SceneObject
    {
        protected readonly Renderer Renderer;

        public MeshSceneObject(Mesh mesh, Renderer renderer)
        {
            Renderer = renderer;
            Mesh = mesh;
        }

        public override void Draw(Graphics graphics, Camera camera)
        {
            var modelMatrix = Matrix.ModelTransformation(Scale, Rotation, Position);
            Renderer.Draw(graphics, Mesh.VertexBuffer, Mesh.IndexBuffer, camera, modelMatrix);
        }

        public override void Update()
        {
        }

        public Vector Rotation { get; set; }= new Vector();
        public Vector Position { get; set; } = new Vector();
        public Vector Scale { get; set; } = new Vector(1, 1, 1, 1);

        public Mesh Mesh { get; }
    }
}