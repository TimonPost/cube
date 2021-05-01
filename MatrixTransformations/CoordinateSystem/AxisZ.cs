using System.Collections.Generic;
using System.Drawing;
using MatrixTransformations.Math;

namespace MatrixTransformations.CoordinateSystem
{
    public class AxisZ : Axis
    {
        public AxisZ(float size = 1) : base("z", Color.Blue)
        {
            VertexBuffer = new List<Vector> { new Vector(0, 0, 0, 1), new Vector(0, 0, -size, 1) };
        }
    }
}