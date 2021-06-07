using System.Drawing;

using MatrixTransformations.MathCustom;
using MatrixTransformations.World;

namespace MatrixTransformations.CoordinateSystem
{
    public class CoordinateSystem : SceneObject
    {
        private readonly Renderer _renderer;

        public CoordinateSystem(Renderer renderer)
        {
            _axises = new Axis[]
            {
                new Axis(renderer, "X", new Vector(1, 0, 0), Color.Red),
                new Axis(renderer, "Y", new Vector(0, 1, 0), Color.Green),
                new Axis(renderer, "Z", new Vector(0, 0, -1), Color.Blue),
            };
        }

        private Axis[] _axises;

        public override void Draw(Graphics graphics, Matrix viewMatrix)
        {
            foreach (Axis axis in _axises)
            {
                axis.Draw(graphics, viewMatrix);
            }
        }

        public override void Update()
        {
            // Ignore
        }
    }
}