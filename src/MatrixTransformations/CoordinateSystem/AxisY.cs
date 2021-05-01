using System.Collections.Generic;
using System.Drawing;
using MatrixTransformations.Math;

namespace MatrixTransformations.CoordinateSystem
{
    public class AxisY : Axis
    {
        public AxisY(float size = 1) : base("y", Color.Green)
        {
            VertexBuffer = new List<Vector> { new Vector(0, 0, 0, 1), new Vector(0, size, 0, 1) };
        }
    }
}