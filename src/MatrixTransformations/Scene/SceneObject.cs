using System.Drawing;

namespace MatrixTransformations
{
    public abstract class SceneObject
    {
        public abstract void Draw(Graphics graphics, Matrix viewMatrix);

        public abstract void Update();
    }
}