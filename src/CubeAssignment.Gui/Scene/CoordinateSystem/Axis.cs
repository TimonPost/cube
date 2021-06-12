using System.Drawing;

namespace CubeAssignment.Gui.Scene.CoordinateSystem
{
    public class Axis
    {
        private readonly Renderer _renderer;
        private readonly string _label;
        private readonly Vector _baseVector;
        private readonly Color _color;
        private readonly Mesh _lineMesh;
        
        public Axis(Renderer renderer, string label, Vector baseVector, Color color)
        {
            _renderer = renderer;
            _label = label;
            _baseVector = baseVector;
            _color = color;

            _lineMesh = Mesh.CreateLine(Vector.NullVector, color, _baseVector, color);
        }

        public void Draw(Graphics graphics, Camera camera)
        {
            _renderer.Draw(graphics, _lineMesh.VertexBuffer, _lineMesh.IndexBuffer, camera, Matrix.Identity());
            _renderer.DrawText(graphics, _label, _color, _baseVector, camera);
        }
    }
}