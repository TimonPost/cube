using System.Collections.Generic;
using System.Drawing;
using MatrixTransformations.Math;

namespace MatrixTransformations.CoordinateSystem
{
    public class AxisX : Axis
    {
        public AxisX(float size = 1) : base("x", Color.Red)
        {
            VertexBuffer = new List<Vector> { new Vector(0, 0, 0, 1), new Vector(size, 0, 0, 1) };
        }
    }
}