using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
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
            CheckKeyPress();

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

        private void CheckKeyPress()
        {
            if (Keyboard.IsKeyDown(Keys.S))
                Console.WriteLine("S is pressed");


            //Console.WriteLine(Control.ModifierKeys);

            if (Keyboard.IsKeyDown(Keys.PageUp))
            {
                // decrease z
            }

            if (Keyboard.IsKeyDown(Keys.PageUp))
            {
                // increase z
            }

            if ((Control.ModifierKeys & Keys.Shift) != 0)
            {
                Console.WriteLine("SHIFT");
                if (Keyboard.IsKeyDown(Keys.S))
                {
                    Console.WriteLine("S");
                    // decrease scale
                    ApplyEffect((ms) => ms.Scale = ms.Scale * 0.9f);
                }

                if (Keyboard.IsKeyDown(Keys.Y))
                {
                    // decrease rotate y
                }

                if (Keyboard.IsKeyDown(Keys.Z))
                {
                    // decrease rotate z
                }

                if (Keyboard.IsKeyDown(Keys.X))
                {
                    // decrease rotate x
                }
            }
            else
            {
                if (Keyboard.IsKeyDown(Keys.S))
                {
                    // increase scale
                    ApplyEffect((ms) => ms.Scale = ms.Scale * 1.1f);
                }

                if (Keyboard.IsKeyDown(Keys.X))
                {
                    // increase rotate x
                }


                if (Keyboard.IsKeyDown(Keys.Y))
                {
                    // increase rotate y
                }


                if (Keyboard.IsKeyDown(Keys.Z))
                {
                    // increase rotate z
                }


                if (Keyboard.IsKeyDown(Keys.C))
                {
                    // reset to default
                }

                if (Keyboard.IsKeyDown(Keys.A) )
                {
                    // start animation.
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