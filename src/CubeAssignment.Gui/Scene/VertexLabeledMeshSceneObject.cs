using System.Drawing;

namespace CubeAssignment.Gui.Scene
{
    /// <summary>
    /// A text label mesh object. 
    /// </summary>
    public class VertexLabeledMeshSceneObject : MeshSceneObject
    {
        public VertexLabeledMeshSceneObject(Mesh mesh, Renderer renderer) : base(mesh, renderer)
        {
        }

        public override void Draw(Graphics graphics, Camera camera)
        {
            Matrix modeViewMatrix = Matrix.ModelTransformation(Scale, Rotation, Position);

            for (var index = 0; index < Mesh.VertexBuffer.Count; index++)
            {
                Vertex vertex = Mesh.VertexBuffer[index];
                Renderer.DrawText(graphics, index.ToString(), Color.White, vertex.Position, camera, modeViewMatrix);
            }

            base.Draw(graphics, camera);
        }
    }
}