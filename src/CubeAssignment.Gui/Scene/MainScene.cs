using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CubeAssignment.Gui.Animation;

namespace CubeAssignment.Gui.Scene
{
    /// <summary>
    /// The main scene of the game world. 
    /// </summary>
    public class MainScene : Scene
    {
        private readonly List<IAnimationFiniteStateMachine> _animationStateMachines =
            new List<IAnimationFiniteStateMachine>();

        /// <summary>
        /// Adds a given animation state machine that will animate a particular scene object. 
        /// </summary>
        /// <param name="stateMachine"></param>
        public void AddAnimationStateMachines(IAnimationFiniteStateMachine stateMachine)
        {
            _animationStateMachines.Add(stateMachine);
        }
        
        /// <summary>
        /// Updates the main scene.
        /// </summary>
        /// <param name="deltaTime"></param>
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
                ApplyEffect((ms) =>
                {
                    Vector newPosition = ms.Position;
                    newPosition.z -= 2f;
                    ms.Position = newPosition;
                });
            }

            if (Keyboard.IsKeyDown(Keys.PageUp))
                // increase z
            {
                ApplyEffect((ms) =>
                {
                    Vector newPosition = ms.Position;
                    newPosition.z += 2f;
                    ms.Position = newPosition;
                });
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
                    ApplyEffect((ms) =>
                    {
                        Vector newRotation = ms.Rotation;
                        newRotation.x -= 0.1f;
                        ms.Rotation = newRotation;
                    });
                }

                if (Keyboard.IsKeyDown(Keys.Y))
                    // decrease rotate y
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newRotation = ms.Rotation;
                        newRotation.y -= 0.1f;
                        ms.Rotation = newRotation;
                    });
                }

                if (Keyboard.IsKeyDown(Keys.Z))
                    // decrease rotate z
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newRotation = ms.Rotation;
                        newRotation.z -= 0.1f;
                        ms.Rotation = newRotation;
                    });
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
                    ApplyEffect((ms) =>
                    {
                        Vector newRotation = ms.Rotation;
                        newRotation.x += 0.1f;
                        ms.Rotation = newRotation;
                    });
                }

                if (Keyboard.IsKeyDown(Keys.Y))
                    // increase rotate y
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newRotation = ms.Rotation;
                        newRotation.y += 0.1f;
                        ms.Rotation = newRotation;
                    });
                }

                if (Keyboard.IsKeyDown(Keys.Z))
                    // increase rotate z
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newRotation = ms.Rotation;
                        newRotation.z += 0.1f;
                        ms.Rotation = newRotation;
                    });
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