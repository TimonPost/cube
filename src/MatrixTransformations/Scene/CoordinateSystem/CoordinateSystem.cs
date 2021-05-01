using System.Drawing;
using MatrixTransformations.Math;
using MatrixTransformations.World;

namespace MatrixTransformations.CoordinateSystem
{
    public class CoordinateSystem : SceneObject
    {
        private Axis[] _axises = new Axis[3]
        {
            new Axis("X", new Vector(1, 0, 0), Color.Red),
            new Axis("Y", new Vector(0, 1, 0), Color.Green),
            new Axis("Z", new Vector(0, 0, 1), Color.Blue)
        };
        
        public override void Draw(Graphics graphics, Matrix viewMatrix)
        {
            foreach (Axis axis in _axises)
            {
                axis.Draw(graphics, viewMatrix);
            }
        }

        public override void Update()
        {
            
        }
    }
}