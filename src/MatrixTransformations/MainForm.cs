﻿using System;
using System.Collections.Generic;
using System.Drawing;
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

            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            var renderer = new Renderer(Canvas.Width, Canvas.Height);

            var cube = new VertexLabeledMeshSceneObject(Mesh.Cube, renderer);
            
            _scene.Add(new CoordinateSystem.CoordinateSystem(renderer));
            _scene.Add(cube);

            _scene.Add(new MeshSceneObject(Mesh.FromObj("Models/Suzanne.obj", Color.Chocolate), renderer));

            _scene.AddAnimationStateMachines(new AnimationFiniteStateMachine(cube, _scene.Camera));

        }

        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject);
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

            //phiTrack.Value = (int)_scene.Camera.PHI;
            phiLabel.Text = $"PHI {_scene.Camera.PHI}";
            // thetaTrack.Value = (int)_scene.Camera.THETA;
            thetaLabel.Text = $"THETA {_scene.Camera.THETA}";
            //rTrack.Value = (int)_scene.Camera.R;
            rLabel.Text = $"R {_scene.Camera.R}";

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

