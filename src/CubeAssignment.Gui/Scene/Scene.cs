using System.Collections.Generic;
using System.Drawing;

namespace CubeAssignment.Gui.Scene
{
    /// <summary>
    /// An Environment that contains SceneObjects
    /// </summary>
    public class Scene
    {
        private readonly List<SceneObject> _sceneObjects = new List<SceneObject>();

        public IReadOnlyCollection<SceneObject> SceneObjects => _sceneObjects;

        public Camera Camera { get; } = new Camera();
        
        /// <summary>
        /// Adds the <see cref="SceneObjects"/> to <see cref="SceneObjects"/>
        /// </summary>
        /// <param name="sceneObject"></param>
        public void Add(SceneObject sceneObject)
        {
            _sceneObjects.Add(sceneObject);
        }
        
        /// <summary>
        /// Updates every SceneObject.
        /// </summary>
        /// <param name="deltaTime"></param>
        public virtual void Update(float deltaTime)
        {
            foreach (SceneObject sceneObject in _sceneObjects)
            {
                sceneObject.Update();
            }
        }

        /// <summary>
        /// Renders the <see cref="SceneObjects"/> using <see cref="Graphics"/>
        /// </summary>
        /// <param name="graphics"></param>
        public void Draw(Graphics graphics)
        {
            foreach (SceneObject sceneObject in _sceneObjects)
            {
                sceneObject.Draw(graphics, Camera);
            }
        }
    }
}