using System.Drawing;

namespace CubeAssignment.Gui.Scene
{
    public abstract class SceneObject
    {
        public abstract void Draw(Graphics graphics, Matrix viewMatrix);

        public abstract void Update();
    }
}