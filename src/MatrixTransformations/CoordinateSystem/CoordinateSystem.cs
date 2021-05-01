using System.Drawing;
using MatrixTransformations.World;

namespace MatrixTransformations.CoordinateSystem
{
    public class CoordinateSystem
    {
        public AxisX AxisX { get; set; }
        public AxisY AxisY { get; set; }
        public AxisZ AxisZ { get; set; }

        public CoordinateSystem(float xSize, float ySize, float zSize)
        {
            AxisX = new AxisX(xSize);
            AxisY = new AxisY(ySize);
            AxisZ = new AxisZ(zSize);
        }

        public void Draw(Graphics g, Render render, float width, float height)
        {
            AxisX.Draw(g, render, width, height);
            AxisY.Draw(g, render, width, height);
            AxisZ.Draw(g, render, width, height);
        }
    }
}