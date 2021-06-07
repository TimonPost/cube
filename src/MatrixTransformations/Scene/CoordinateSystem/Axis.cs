using System.Collections.Generic;
using System.Drawing;
using MatrixTransformations.Math;
using MatrixTransformations.World;

namespace MatrixTransformations.CoordinateSystem
{
    public class Axis
    {
        private readonly Pen _pen;
        private readonly Font _font;
        private readonly SolidBrush _fontBrush;
        public string Label { get; }
        public Vector BaseVector { get; }

        public Axis(string label,Vector baseVector, Color color)
        {
            _font = new Font("Arial", 10);
            _pen = new Pen(color);

            

            _fontBrush = new SolidBrush(color);


            Label = label;
            BaseVector = baseVector;
        }

        public void Draw(Graphics graphics, Matrix viewMatrix)
        {
            Vector nullVector = Vector.Transform(Vector.NullVector, viewMatrix);
            nullVector = Vector.Transform(nullVector, Matrix.CreateProjection(2, nullVector.z));
            // Transform to screen space
            nullVector.x = (nullVector.x + 1f) * graphics.ClipBounds.Width * 0.5f;
            nullVector.y = (1f - nullVector.y) * graphics.ClipBounds.Height * 0.5f;

            Vector baseVector = Vector.Transform(BaseVector, viewMatrix);
            baseVector = Vector.Transform(baseVector, Matrix.CreateProjection(2, baseVector.z));
            // Transform to screen space
            baseVector.x = (baseVector.x + 1f) * graphics.ClipBounds.Width * 0.5f;
            baseVector.y = (1f - baseVector.y) * graphics.ClipBounds.Height * 0.5f;

            // Draw axis line
            graphics.DrawLine(_pen, nullVector.x, nullVector.y, baseVector.x, baseVector.y);

            // Draw label
            PointF labelPosition = new PointF(baseVector.x, baseVector.y);
            graphics.DrawString(Label, _font, _fontBrush, labelPosition);
        }
    }
}