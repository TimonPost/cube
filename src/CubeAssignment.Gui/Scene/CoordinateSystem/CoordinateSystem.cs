using System.Drawing;

namespace CubeAssignment.Gui.Scene.CoordinateSystem
{
    public class CoordinateSystem : SceneObject
    {
        private readonly Axis[] _axises;

        public CoordinateSystem(Renderer renderer)
        {
            _axises = new Axis[]
            {
                new Axis(renderer, "X", new Vector(1, 0, 0), Color.Red),
                new Axis(renderer, "Y", new Vector(0, 1, 0), Color.Green),
                new Axis(renderer, "Z", new Vector(0, 0, -1), Color.Blue)
            };
        }

        public override void Draw(Graphics graphics, Camera camera)
        {
            foreach (Axis axis in _axises)
            {
                axis.Draw(graphics, camera);
            }
        }

        public override void Update()
        {
            // Ignore
        }
    }
}