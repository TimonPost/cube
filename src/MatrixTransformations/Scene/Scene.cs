using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MatrixTransformations.Animation;

namespace MatrixTransformations
{
    public class Scene
    {
        private readonly List<SceneObject> _sceneObjects = new List<SceneObject>();

        private readonly List<IAnimationFiniteStateMachine> _animationStateMachines =
            new List<IAnimationFiniteStateMachine>();

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
            CheckKeyPress();

            foreach (SceneObject sceneObject in _sceneObjects)
            {
                sceneObject.Update();
            }

            foreach (IAnimationFiniteStateMachine animation in _animationStateMachines)
            {
                if (animation != null)
                {
                    animation.Tick();
                }
            }
        }

        private void CheckKeyPress()
        {
            if (Keyboard.IsKeyDown(Keys.PageUp))
                // decrease z
            {
                ApplyEffect((ms) => ms.Position.z -= 2f);
            }

            if (Keyboard.IsKeyDown(Keys.PageUp))
                // increase z
            {
                ApplyEffect((ms) => ms.Position.z += 2f);
            }

            if ((Control.ModifierKeys & Keys.Shift) != 0)
            {
                if (Keyboard.IsKeyDown(Keys.S))
                    // decrease scale
                {
                    ApplyEffect((ms) => ms.Scale = ms.Scale * 0.9f);
                }

                if (Keyboard.IsKeyDown(Keys.X))
                    // decrease rotate x
                {
                    ApplyEffect((ms) => ms.Rotation.x -= 0.1f);
                }

                if (Keyboard.IsKeyDown(Keys.Y))
                    // decrease rotate y
                {
                    ApplyEffect((ms) => ms.Rotation.y -= 0.1f);
                }

                if (Keyboard.IsKeyDown(Keys.Z))
                    // decrease rotate z
                {
                    ApplyEffect((ms) => ms.Rotation.z -= 0.1f);
                }
            }
            else
            {
                if (Keyboard.IsKeyDown(Keys.S))
                    // increase scale
                {
                    ApplyEffect((ms) => ms.Scale = ms.Scale * 1.1f);
                }

                if (Keyboard.IsKeyDown(Keys.X))
                    // increase rotate x
                {
                    ApplyEffect((ms) => ms.Rotation.x += 0.1f);
                }

                if (Keyboard.IsKeyDown(Keys.Y))
                    // increase rotate y
                {
                    ApplyEffect((ms) => ms.Rotation.y += 0.1f);
                }

                if (Keyboard.IsKeyDown(Keys.Z))
                    // increase rotate z
                {
                    ApplyEffect((ms) => ms.Rotation.z += 0.1f);
                }

                if (Keyboard.IsKeyDown(Keys.C))
                {
                    ApplyEffect(ms =>
                    {
                        ms.Scale = new Vector(1, 1, 1);
                        ms.Rotation = new Vector();
                        ms.Position = new Vector();
                    });

                    Camera.Reset();

                    // reset to default
                    foreach (IAnimationFiniteStateMachine animationFiniteStateMachine in _animationStateMachines)
                    {
                        animationFiniteStateMachine.ProcessEvent(Events.Stop);
                    }
                }

                if (Keyboard.IsKeyDown(Keys.A))
                {
                    // reset to default
                    foreach (IAnimationFiniteStateMachine animationFiniteStateMachine in _animationStateMachines)
                    {
                        animationFiniteStateMachine.Start();
                    }
                }
            }
        }

        private void ApplyEffect(Action<MeshSceneObject> func)
        {
            _sceneObjects.ForEach(x =>
            {
                if (x is MeshSceneObject ms)
                {
                    func(ms);
                }
            });
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