using System.Drawing;

namespace CubeAssignment.Gui.Scene
{
    /// <summary>
    /// Represents an object that can be added to a <see cref="Scene"/>
    /// </summary>
    public abstract class SceneObject
    {
        public abstract void Draw(Graphics graphics, Matrix viewMatrix);

        public abstract void Update();
    }
}