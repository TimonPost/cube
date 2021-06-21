using System.Drawing;

namespace CubeAssignment.Gui.Scene.CoordinateSystem
{
    /// <summary>
    /// Drawable cartesian coordinate system with x, y and z axis. 
    /// </summary>
    public class CoordinateSystem : SceneObject
    {
        private readonly Axis[] _axises;

        public CoordinateSystem(Renderer renderer)
        {
            _axises = new Axis[]
            {
                new Axis(renderer, "X", new Vector(4, 0, 0), Color.Red),
                new Axis(renderer, "Y", new Vector(0, 4, 0), Color.Green),
                new Axis(renderer, "Z", new Vector(0, 0, -4), Color.Blue)
            };
        }
        
        public override void Draw(Graphics graphics, Camera camera)
        {
            foreach (Axis axis in _axises)
            {
                axis.Draw(graphics, camera);
            }
        }

        public override void Update(float deltaTime)
        {
            // Ignore
        }
    }
}