using System;
using System.Collections.Generic;
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
    }
}

