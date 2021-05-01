using System.Drawing;
using MatrixTransformations.Math;

namespace MatrixTransformations.World
{
    public abstract class SceneObject
    {
        public abstract void Draw(Graphics graphics, Matrix viewMatrix);

        public abstract void Update();
    }
}
