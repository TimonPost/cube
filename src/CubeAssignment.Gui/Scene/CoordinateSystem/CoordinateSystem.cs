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
                new Axis(renderer, "X", new Vector(4, 0, 0), Color.FromArgb(246, 54, 82)),
                new Axis(renderer, "Y", new Vector(0, 4, 0), Color.FromArgb(111, 162, 26)),
                new Axis(renderer, "Z", new Vector(0, 0, -4), Color.FromArgb(46, 131, 227))
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