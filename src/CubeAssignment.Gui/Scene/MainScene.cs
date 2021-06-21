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
            if (Input.IsKeyDown(Keys.Q))
                // decrease scale
            {
                ApplyEffect((ms) => Camera.D += 1);
            }
            if (Input.IsKeyDown(Keys.W))
                // decrease scale
            {
                ApplyEffect((ms) => Camera.D -= 1);
            }


            if (Input.IsKeyDown(Keys.PageUp))
                // decrease z
            {
                ApplyEffect((ms) =>
                {
                    Vector newPosition = ms.Position;
                    newPosition.z -= 2f;
                    ms.Position = newPosition;
                });
            }

            if (Input.IsKeyDown(Keys.PageUp))
                // increase z
            {
                ApplyEffect((ms) =>
                {
                    Vector newPosition = ms.Position;
                    newPosition.z += 2f;
                    ms.Position = newPosition;
                });
            }

            // If shift is pressed
            if ((Control.ModifierKeys & Keys.Shift) != 0)
            {
                if (Input.IsKeyDown(Keys.S))
                    // decrease scale
                {
                    ApplyEffect((ms) => ms.Scale = ms.Scale * 0.9f);
                }

                if (Input.IsKeyDown(Keys.X))
                    // decrease rotate x
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newRotation = ms.Rotation;
                        newRotation.x -= 0.1f;
                        ms.Rotation = newRotation;
                    });
                }

                if (Input.IsKeyDown(Keys.Y))
                    // decrease rotate y
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newRotation = ms.Rotation;
                        newRotation.y -= 0.1f;
                        ms.Rotation = newRotation;
                    });
                }

                if (Input.IsKeyDown(Keys.Z))
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
                if (Input.IsKeyDown(Keys.S))
                    // increase scale
                {
                    ApplyEffect((ms) => ms.Scale = ms.Scale * 1.1f);
                }

                if (Input.IsKeyDown(Keys.X))
                    // increase rotate x
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newRotation = ms.Rotation;
                        newRotation.x += 0.1f;
                        ms.Rotation = newRotation;
                    });
                }

                if (Input.IsKeyDown(Keys.Y))
                    // increase rotate y
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newRotation = ms.Rotation;
                        newRotation.y += 0.1f;
                        ms.Rotation = newRotation;
                    });
                }

                if (Input.IsKeyDown(Keys.Z))
                    // increase rotate z
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newRotation = ms.Rotation;
                        newRotation.z += 0.1f;
                        ms.Rotation = newRotation;
                    });
                }

                if (Input.IsKeyDown(Keys.C))
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

                if (Input.IsKeyDown(Keys.A))
                {
                    // reset to default
                    foreach (IAnimationFiniteStateMachine animationFiniteStateMachine in _animationStateMachines)
                    {
                        animationFiniteStateMachine.Start();
                    }
                }

                // Translation

                // Translate Y+
                if (Input.IsKeyDown(Keys.Up))
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newPosition = ms.Position;
                        newPosition.y += Settings.TranslationSpeed;
                        ms.Position = newPosition;
                    });
                }

                // Translate X-
                if (Input.IsKeyDown(Keys.Left))
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newPosition = ms.Position;
                        newPosition.x -= Settings.TranslationSpeed;
                        ms.Position = newPosition;
                    });
                }

                // Translate X+
                if (Input.IsKeyDown(Keys.Right))
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newPosition = ms.Position;
                        newPosition.x += Settings.TranslationSpeed;
                        ms.Position = newPosition;
                    });
                }

                // Translate Y-
                if (Input.IsKeyDown(Keys.Down))
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newPosition = ms.Position;
                        newPosition.y -= Settings.TranslationSpeed;
                        ms.Position = newPosition;
                    });
                }

                // Translate Z-
                if (Input.IsKeyDown(Keys.PageUp))
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newPosition = ms.Position;
                        newPosition.z -= Settings.TranslationSpeed;
                        ms.Position = newPosition;
                    });
                }

                // Translate Z+
                if (Input.IsKeyDown(Keys.PageDown))
                {
                    ApplyEffect((ms) =>
                    {
                        Vector newPosition = ms.Position;
                        newPosition.z += Settings.TranslationSpeed;
                        ms.Position = newPosition;
                    });
                }
            }
        }
    }
}