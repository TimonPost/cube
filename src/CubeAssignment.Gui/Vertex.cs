using System.Drawing;

namespace CubeAssignment.Gui
{
    public class Vertex
    {
        public Vertex(Vector vector, Color color)
        {
            Vector = vector;
            Color = color;
        }

        public Vector Vector { get; }
        public Color Color { get; }
    }
}