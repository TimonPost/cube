using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CubeAssignment.Gui.Animation;

namespace CubeAssignment.Gui.Scene
{
    public class MainScene : Scene
    {
        public void AddAnimationStateMachines(IAnimationFiniteStateMachine stateMachine)
        {
            _animationStateMachines.Add(stateMachine);
        }

        private readonly List<IAnimationFiniteStateMachine> _animationStateMachines =
            new List<IAnimationFiniteStateMachine>();

        public override void Update(float deltaTime)
        {
            UpdateInput();
            foreach (IAnimationFiniteStateMachine animation in _animationStateMachines)
            {
                animation?.Tick();
            }
            base.Update(deltaTime);
        }

        private void ApplyEffect(Action<MeshSceneObject> effectCallback)
        {
            foreach (SceneObject sceneObject in SceneObjects)
            {
                if (sceneObject is MeshSceneObject ms)
                {
                    effectCallback(ms);
                }
            }
        }

        private void UpdateInput()
        {
            if (Keyboard.IsKeyDown(Keys.Q))
                // decrease scale
            {
                ApplyEffect((ms) => Camera.D += 1);
            }
            if (Keyboard.IsKeyDown(Keys.W))
                // decrease scale
            {
                ApplyEffect((ms) => Camera.D -= 1);
            }


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
    }
}