using System.Collections.Generic;
using System.Drawing;
using MatrixTransformations.Math;
using MatrixTransformations.World;

namespace MatrixTransformations.CoordinateSystem
{
    public class Axis
    {
        public List<Vector> VertexBuffer;
        public Color Color { get; }
        public string Label { get; }

        public Vector Rotation { get; set; }
        public Vector Scale { get; set; }
        public Vector Translate { get; set; }

        public Axis(string label, Color color)
        {
            Label = label;
            Color = color;
            Rotation = new Vector(0, 0, 0, 1);
            Scale = new Vector(1, 1, 1, 1);
            Translate = new Vector(0, 0, 0, 1);
        }

        public void Draw(Graphics g, Render renderer, float width, float height)
        {
            var transformedCoordinates = renderer.Transform(VertexBuffer, width, height, Scale, Rotation, Translate);

            var start = transformedCoordinates[0];
            var end = transformedCoordinates[1];

            Pen pen = new Pen(Color, 2f);
            g.DrawLine(pen, (float)start.x, (float)start.y, (float)end.x, (float)end.y);
            Font font = new Font("Arial", 10);

            PointF p = new PointF((float)start.x, (float)end.y);
            g.DrawString(Label, font, new SolidBrush(Color), p);
        }
    }
}