﻿using System.Collections.Generic;
using System.Drawing;
using MatrixTransformations.Animation;
using MatrixTransformations.Math;
using MatrixTransformations.World;

namespace MatrixTransformations
{
    public class Scene
    {
        private readonly List<SceneObject> _sceneObjects = new List<SceneObject>();

        private readonly List<IAnimationFiniteStateMachine> _animationStateMachines = new List<IAnimationFiniteStateMachine>();

        public Camera Camera { get; } = new Camera();

        public void Add(SceneObject sceneObject)
        {
            _sceneObjects.Add(sceneObject);
        }

        public void AddAnimationStateMachines(IAnimationFiniteStateMachine stateMachine)
        {
            _animationStateMachines.Add(stateMachine);
        }

        public void Update(float deltaTime)
        {
            foreach (SceneObject sceneObject in _sceneObjects)
            {
                sceneObject.Update();
            }

            foreach (var animation in _animationStateMachines)
            {
                if (animation != null)
                {
                    animation.Tick();
                }
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