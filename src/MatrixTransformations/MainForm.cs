using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;
using MatrixTransformations.Animation;
using MatrixTransformations.Math;
using MatrixTransformations.World;

namespace MatrixTransformations
{
    public partial class MainForm : Form
    {

        private readonly Scene _scene = new Scene();
        
        private DateTime _previousTick = DateTime.Now;

        public MainForm()
        {
            var renderer = new Renderer(Width, Height);

            var stateMachine = new AnimationFiniteStateMachine();
            stateMachine.Start();

            InitializeComponent();
            _scene.Add(new CoordinateSystem.CoordinateSystem());
            _scene.Add(new MeshSceneObject(Mesh.Cube, renderer, stateMachine));
        }
        
        /// <summary>
        /// Calculates the time between the current frame and the previous frame.
        /// </summary>
        /// <returns></returns>
        private float CalculateDeltaTime()
        {
            DateTime currentTick = DateTime.Now;
            float deltaTime = (float) (currentTick - _previousTick).TotalSeconds;
            _previousTick = currentTick;
            return deltaTime;
        }

        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            // Redraw scene
            Canvas.Invalidate();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            var deltaTime = CalculateDeltaTime();
            _scene.Update(deltaTime);
            _scene.Draw(e.Graphics);
        }

        private void tableLayoutPanel2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
            {
                // increase z
            } else if (e.KeyCode == Keys.PageUp)
            {
                // decrease z
            }

            if (e.KeyCode == Keys.S && !e.Shift)
            {
                // increase scale
            }
            else if (e.KeyCode == Keys.S && e.Shift)
            {
                // decrease scale
            }

            if (e.KeyCode == Keys.X && !e.Shift)
            {
                // increase rotate x
            }
            else if (e.KeyCode == Keys.X && e.Shift)
            {
                // decrease rotate x
            }

            if (e.KeyCode == Keys.Y && !e.Shift)
            {
                // increase rotate y
            }
            else if (e.KeyCode == Keys.Y && e.Shift)
            {
                // decrease rotate y
            }

            if (e.KeyCode == Keys.Z && !e.Shift)
            {
                // increase rotate z
            }
            else if (e.KeyCode == Keys.Z && e.Shift)
            {
                // decrease rotate z
            }

            if (e.KeyCode == Keys.C)
            {
                // reset to default
            }

            if (e.KeyCode == Keys.A)
            {
                // start animation.
            }
        }
    }
}

