using System.Drawing;

namespace CubeAssignment.Gui.Scene
{
    /// <summary>
    ///     Represents an object that can be added to a <see cref="Scene" />
    /// </summary>
    public abstract class SceneObject
    {
        /// <summary>
        ///     Draws the given scene object to the screen.
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="camera"></param>
        public abstract void Draw(Graphics graphics, Camera camera);

        /// <summary>
        ///     Updates the given scene object.
        /// </summary>
        public abstract void Update(float deltaTime);
    }
}