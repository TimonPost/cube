using System.ComponentModel;
using System.Runtime.CompilerServices;
using CubeAssignment.Gui.Annotations;

namespace CubeAssignment.Gui.Scene
{
    public class Camera : INotifyPropertyChanged
    {
        private float _d = 800;
        private float _r = 10;
        private float _theta = -100;
        private float _phi = -10;
        public Vector Position { get; set; } = new Vector(0, 0, 3);

        public float D
        {
            get => _d;
            set
            {
                if (value.Equals(_d)) return;
                _d = value;
                OnPropertyChanged();
            }
        }
        public float R
        {
            get => _r;
            set
            {
                if (value.Equals(_r)) return;
                _r = value;
                OnPropertyChanged();
            }
        }
        public float Theta
        {
            get => _theta;
            set
            {
                if (value.Equals(_theta)) return;
                _theta = value;
                OnPropertyChanged();
            }
        }
        public float Phi
        {
            get => _phi;
            set
            {
                if (value.Equals(_phi)) return;
                _phi = value;
                OnPropertyChanged();
            }
        }

        public Matrix GetMatrix()
        {
            Matrix camera = Matrix.Identity();
            camera[0, 3] = R * (float) System.Math.Sin(Phi) * (float) System.Math.Cos(Theta);
            camera[1, 3] = R * (float) System.Math.Sin(Phi) * (float) System.Math.Sin(Theta);
            camera[2, 3] = R * (float) System.Math.Cos(Phi);
            camera[3, 3] = 1;

            Matrix rotateZ = Matrix.RotateZ(Theta + (float) Utils.DegreesToRadians(90));
            Matrix rotateX = Matrix.RotateX(Phi);
            Matrix result = rotateX * rotateZ * camera;

            return result.Invert();
        }
        
        public void Reset()
        {
            Position = new Vector(0, 0, 3);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}