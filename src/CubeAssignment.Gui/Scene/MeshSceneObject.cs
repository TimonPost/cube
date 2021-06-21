using System.Drawing;
using PropertyChanged;

namespace CubeAssignment.Gui.Scene
{
    /// <summary>
    ///     Represents a Mesh SceneObject
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

        /// <summary>
        ///     The rotation of this mesh scene object.
        /// </summary>
        public Vector Rotation { get; set; } = new Vector();

        /// <summary>
        ///     The position of this mesh scene object.
        /// </summary>
        public Vector Position { get; set; } = new Vector();

        /// <summary>
        ///     The scale of this mesh scene object.
        /// </summary>
        public Vector Scale { get; set; } = new Vector(1, 1, 1);

        /// <summary>
        ///     The underlying mesh for this mesh scene object.
        /// </summary>
        public Mesh Mesh { get; }

        public override void Draw(Graphics graphics, Camera camera)
        {
            var modelMatrix = Matrix.ModelTransformation(Scale, Rotation, Position);
            Renderer.Draw(graphics, Mesh.VertexBuffer, Mesh.IndexBuffer, camera, modelMatrix);
        }

        public override void Update(float deltaTime)
        {
        }
    }
}