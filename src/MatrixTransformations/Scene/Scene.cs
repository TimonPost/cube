using System.Collections.Generic;
using System.Drawing;
using MatrixTransformations.Math;
using MatrixTransformations.World;

namespace MatrixTransformations
{
    public class Scene
    {
        private readonly List<SceneObject> _sceneObjects = new List<SceneObject>();
        public Camera Camera { get; } = new Camera();

        public void Add(SceneObject sceneObject)
        {
            _sceneObjects.Add(sceneObject);
        }

        public void Update(float deltaTime)
        {
            foreach (SceneObject sceneObject in _sceneObjects)
            {
                sceneObject.Update();
            }
        }

        public void Draw(Graphics graphics)
        {
            foreach (SceneObject sceneObject in _sceneObjects)
            {
                sceneObject.Draw(graphics, Camera.GetMatrix());
            }
        }
    }
}