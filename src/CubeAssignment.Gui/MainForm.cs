using System;
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
        private readonly Renderer _renderer;

        private DateTime _previousTick = DateTime.Now;

        public MainForm()
        {
            Instance = this;
            InitializeComponent();

            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            _renderer = new Renderer(Canvas.Width, Canvas.Height);
            var cube = new VertexLabeledMeshSceneObject(Mesh.Cube, _renderer);
            var ape = new MeshSceneObject(Mesh.FromObj("Models/Suzanne.obj", Color.FromArgb(244, 154, 56)), _renderer);

            // Camera UI property bindings
            theValuetaLabel.DataBindings.Add(new Binding(nameof(Label.Text), _mainScene.Camera, nameof(Camera.Theta)));
            dValueLabel.DataBindings.Add(new Binding(nameof(Label.Text), _mainScene.Camera, nameof(Camera.Distance)));
            rValueLabel.DataBindings.Add(new Binding(nameof(Label.Text), _mainScene.Camera, nameof(Camera.R)));
            phiValueLabel.DataBindings.Add(new Binding(nameof(Label.Text), _mainScene.Camera, nameof(Camera.Phi)));

            // Mesh UI property bindings
            var rotationBinding = new Binding(nameof(Label.Text), cube, nameof(MeshSceneObject.Rotation));
            rotationBinding.Format += FormatRotationVectorToDegrees;

            RotateValueLabel.DataBindings.Add(rotationBinding);
            ScaleValueLabel.DataBindings.Add(new Binding(nameof(Label.Text), cube, nameof(MeshSceneObject.Scale)));
            TranslateValueLabel.DataBindings.Add(
                new Binding(nameof(Label.Text), cube, nameof(MeshSceneObject.Position)));

            _mainScene.Add(new CoordinateSystem(_renderer));
            _mainScene.Add(cube);
            _mainScene.Add(ape);

            _mainScene.AddAnimationStateMachines(new AnimationFiniteStateMachine(cube, _mainScene.Camera));
            _mainScene.AddAnimationStateMachines(new AnimationFiniteStateMachine(ape, _mainScene.Camera));
        }

        internal static Form Instance { get; private set; }

        private void FormatRotationVectorToDegrees(object sender, ConvertEventArgs args)
        {
            var rotation = (Vector) args.Value;
            args.Value = new Vector(Utils.RadiansToDegrees(rotation.x), Utils.RadiansToDegrees(rotation.y),
                Utils.RadiansToDegrees(rotation.z)).ToString();
        }

        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject);
        }

        /// <summary>
        ///     Calculates the time between the current frame and the previous frame.
        /// </summary>
        /// <returns></returns>
        private float CalculateDeltaTime()
        {
            var currentTick = DateTime.Now;
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

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            _renderer.ScreenWidth = Canvas.Width;
            _renderer.ScreenHeight = Canvas.Height;
        }
    }
}