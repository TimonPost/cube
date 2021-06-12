using System.Drawing;

namespace CubeAssignment.Gui.Scene
{
    public abstract class SceneObject
    {
        public abstract void Draw(Graphics graphics, Camera camera);

        public abstract void Update();
    }
}