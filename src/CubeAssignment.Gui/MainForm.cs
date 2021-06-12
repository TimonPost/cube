﻿using System;
using System.Drawing;
using System.Windows.Forms;
using CubeAssignment.Gui.Animation;
using CubeAssignment.Gui.Scene;
using CubeAssignment.Gui.Scene.CoordinateSystem;

namespace CubeAssignment.Gui
{
    public partial class MainForm : Form
    {
        private readonly MainScene _mainScene = new MainScene();

        private DateTime _previousTick = DateTime.Now;

        public MainForm()
        {
            InitializeComponent();

            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            var renderer = new Renderer(Canvas.Width, Canvas.Height);
            var cube = new VertexLabeledMeshSceneObject(Mesh.Cube, renderer);
            var ape = new MeshSceneObject(Mesh.FromObj("Models/Suzanne.obj", Color.Chocolate), renderer);
            theValuetaLabel.DataBindings.Add(new Binding(nameof(Label.Text), _mainScene.Camera, nameof(Camera.Theta)));
            dValueLabel.DataBindings.Add(new Binding(nameof(Label.Text), _mainScene.Camera, nameof(Camera.D)));
            rValueLabel.DataBindings.Add(new Binding(nameof(Label.Text), _mainScene.Camera, nameof(Camera.R)));
            phiValueLabel.DataBindings.Add(new Binding(nameof(Label.Text), _mainScene.Camera, nameof(Camera.Phi)));


            _mainScene.Add(new CoordinateSystem(renderer));
            _mainScene.Add(cube);
            _mainScene.Add(ape);

            _mainScene.AddAnimationStateMachines(new AnimationFiniteStateMachine(cube, _mainScene.Camera));
            _mainScene.AddAnimationStateMachines(new AnimationFiniteStateMachine(ape, _mainScene.Camera));
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
            var deltaTime = (float) (currentTick - _previousTick).TotalSeconds;
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
            _mainScene.Update(deltaTime);
            _mainScene.Draw(e.Graphics);
        }
    }
}