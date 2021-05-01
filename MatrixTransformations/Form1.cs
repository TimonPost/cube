using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MatrixTransformations.Math;
using MatrixTransformations.World;

namespace MatrixTransformations
{
    public partial class From1 : Form
    {
        private readonly Cube _cube;
        private WindesheimLogo _windesheimLogo;
        private readonly CoordinateSystem.CoordinateSystem _worldCoordinateSystem;

        private readonly Animation.Animation _animation;
        private bool _animationEnabled = false;
        private readonly Render _render;


        private Vector _scale = new Vector(1, 1, 1);
        private Vector _translate = new Vector();
        private Vector _rotate = new Vector();

        private readonly float _cameraDelta = (float)0.20;
        private readonly float _rotationDelta = (float)System.Math.PI / 60;
        private readonly float _translateDelta = 0.02f;
        private readonly Vector _scaleDelta = new Vector(0.02f, 0.02f, 0.02f);

        public From1()
        {
            InitializeComponent();

            rotate_txt.Text = $"(X: {_rotate.x:##.##} Y: {_rotate.y:##.##} Z: {_rotate.z:##.##})";
            translate_txt.Text = $"(X: {_translate.x:##.##} Y: {_translate.y:##.##} Z: {_translate.z:##.##})";
            scale_txt.Text = $"({_scale})";

            this.DoubleBuffered = true;
            _cube = new Cube(Color.Blue);
            _worldCoordinateSystem = new CoordinateSystem.CoordinateSystem(1, 1, 1);
            _windesheimLogo = new WindesheimLogo();

            _animation = new Animation.Animation();
            _render = new Render(new Camera());

            this.PreviewKeyDown += new PreviewKeyDownEventHandler(form_keyDown);
            this.Focus();
        }

        private void form_keyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Form1_KeyDown(sender, new KeyEventArgs(e.KeyData));
        }

        public IReadOnlyList<Vector> GetNextTransform(IReadOnlyList<Vector> vertexes)
        {
            if (_animationEnabled)
            {
                if (_animation.HasPhase() || _animation.CurrentPhase != null)
                {
                    return _render.Transform(vertexes, Width, Height, _scale, _rotate, _translate);
                }
                else
                {
                    SetAnimation(false);
                }
            }
            
            return _render.Transform(vertexes, Width, Height, _scale, _rotate, _translate);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            _cube.Draw(e.Graphics, GetNextTransform(_cube.Vertexbuffer));
            _worldCoordinateSystem.Draw(e.Graphics, _render, Width, Height);
            _windesheimLogo.Draw(e.Graphics, GetNextTransform(_windesheimLogo.Vertexbuffer));

            base.OnPaint(e);
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();

            // Scaling
            if (e.KeyCode == Keys.S && ((e.Modifiers & Keys.Shift) != 0))
                _scale += _scaleDelta;
            else if (e.KeyCode == Keys.S)
                _scale -= _scaleDelta;

            // Translating x
            if (e.KeyCode == Keys.I)
                _translate.y += _translateDelta;
            else if (e.KeyCode == Keys.J)
                _translate.x -= _translateDelta;
            else if (e.KeyCode == Keys.K)
                _translate.y -= _translateDelta;
            else if (e.KeyCode == Keys.L)
                _translate.x += _translateDelta;

            // Translating y
            if (e.KeyCode == Keys.Up)
                _translate.y += _translateDelta;
            else if (e.KeyCode == Keys.Down)
                _translate.y -= _translateDelta;

            // Translating z
            if (e.KeyCode == Keys.PageUp)
                _translate.z += _rotationDelta;
            else if (e.KeyCode == Keys.PageDown)
                _translate.z -= _rotationDelta;

            // Rotating x
            if (e.KeyCode == Keys.X && ((e.Modifiers & Keys.Shift) != 0))
                _rotate.x += _rotationDelta;
            else if (e.KeyCode == Keys.X)
                _rotate.x -= _rotationDelta;

            // Rotating y
            if (e.KeyCode == Keys.Y && ((e.Modifiers & Keys.Shift) != 0))
                _rotate.y += _rotationDelta;
            else if (e.KeyCode == Keys.Y)
                _rotate.y -= _rotationDelta;

            // Rotating z
            if (e.KeyCode == Keys.Z && ((e.Modifiers & Keys.Shift) != 0))
                _rotate.z += _rotationDelta;
            else if (e.KeyCode == Keys.Z)
                _rotate.z -= _rotationDelta;

            // Animation
            if (e.KeyCode == Keys.A)
            {
                checkBox1.Checked = true;
                StartAnimation();
            } else if (e.KeyCode == Keys.C)
            {
                checkBox1.Checked = false;
                ResetValues();
            }

            // Camera x
            if (e.KeyCode == Keys.Q && ((e.Modifiers & Keys.Shift) != 0))
                _render.Camera.Position += new Vector(_cameraDelta, 0, 0);
            else if (e.KeyCode == Keys.Q)
                _render.Camera.Position -= new Vector(_cameraDelta, 0, 0);

            // Camera y
            if (e.KeyCode == Keys.W && ((e.Modifiers & Keys.Shift) != 0))
                _render.Camera.Position += new Vector(0, _cameraDelta, 0);
            else if (e.KeyCode == Keys.W)
                _render.Camera.Position -= new Vector(0, _cameraDelta, 0);

            // Camera z
            if (e.KeyCode == Keys.E && ((e.Modifiers & Keys.Shift) != 0))
                _render.Camera.Position += new Vector(0, 0, _cameraDelta);
            else if (e.KeyCode == Keys.E)
                _render.Camera.Position -= new Vector(0, 0, _cameraDelta);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_animationEnabled)
            {
                if (!_animation.Tick(_rotate, _scale, _translate))
                {
                    SetAnimation(false);
                }
            }

            rotate_txt.Text = $"(X: {_rotate.x:##.##} Y: {_rotate.y:##.##} Z: {_rotate.z:##.##})";
            translate_txt.Text = $"(X: {_translate.x:##.##} Y: {_translate.y:##.##} Z: {_translate.z:##.##})";
            scale_txt.Text = $"(X: {_scale.x:##.##} Y: {_scale.y:##.##} Z: {_scale.z:##.##})";
            camera_txt.Text = $"(X: {_render.Camera.Position.x:##.##} Y: {_render.Camera.Position.y:##.##} Z: {_render.Camera.Position.z:##.##})";

            Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = ((CheckBox) sender).Checked;
            
            if (!isChecked)
            {
                ResetValues();
            }
            else
            {
                StartAnimation();
            }
        }

        private void ResetValues()
        {
            SetAnimation(false);
            _animation.Reset();
            _rotate = new Vector();
            _translate = new Vector();
            _scale = new Vector(1, 1, 1);
            _render.Camera.Position = new Vector(0, 0, 3);
        }

        private void StartAnimation()
        {
            ResetValues();
            _animation.Start();
            _animationEnabled = true;
        }

        private void SetAnimation(bool enabled)
        {
            _animationEnabled = enabled;
        }
        
        private void From1_MouseDown(object sender, MouseEventArgs e)
        {
        }
    }
}
