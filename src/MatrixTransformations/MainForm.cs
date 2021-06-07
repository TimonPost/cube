using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;
using MatrixTransformations.Animation;
using MatrixTransformations.MathCustom;
using MatrixTransformations.World;

namespace MatrixTransformations
{
    public partial class MainForm : Form
    {
        private readonly Scene _scene = new Scene();
        
        private DateTime _previousTick = DateTime.Now;

        public MainForm()
        {
            InitializeComponent();

            var renderer = new Renderer(Canvas.Width, Canvas.Height);

            var cube = new MeshSceneObject(Mesh.Cube, renderer);
            
            _scene.Add(new CoordinateSystem.CoordinateSystem(renderer));
            _scene.Add(cube);
            _scene.AddAnimationStateMachines(new AnimationFiniteStateMachine(cube));

            phiLabel.Text = $"PHI {_scene.Camera.PHI}";
            thetaLabel.Text = $"THETA {_scene.Camera.THETA}";
            rLabel.Text = $"R {_scene.Camera.R}";
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

        private void phiTrack_ValueChanged(object sender, EventArgs e)
        {
            _scene.Camera.PHI = ((TrackBar) sender).Value;
            phiLabel.Text = "PHI: " + _scene.Camera.PHI;
        }

        private void thetaTrack_ValueChanged(object sender, EventArgs e)
        {
            _scene.Camera.THETA = ((TrackBar)sender).Value;
            thetaLabel.Text = "THETA: " + _scene.Camera.THETA;
        }

        private void rTrack_ValueChanged(object sender, EventArgs e)
        {
            _scene.Camera.R = ((TrackBar)sender).Value;
            rLabel.Text = "R: " + _scene.Camera.R;
        }

        private void dTrack_ValueChanged(object sender, EventArgs e)
        {
            _scene.Camera.D = ((TrackBar)sender).Value;
            dLabel.Text = "D: " + _scene.Camera.D;
        }

        private void phiTrack_Scroll(object sender, EventArgs e)
        {

        }
    }
}

