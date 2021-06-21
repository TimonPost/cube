using System.Drawing;

namespace CubeAssignment.Gui
{
    /// <summary>
    ///     The Vertex data is used to render Mesh Edges.
    /// </summary>
    public class Vertex
    {
        public Vertex(Vector position, Color color)
        {
            Position = position;
            Color = color;
        }

        /// <summary>
        ///     The Position vector of the vertex
        /// </summary>
        public Vector Position { get; }

        /// <summary>
        ///     The color of the Vertex
        /// </summary>
        public Color Color { get; }
    }
}