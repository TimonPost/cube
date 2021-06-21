using System.ComponentModel;
using System.Runtime.CompilerServices;
using CubeAssignment.Gui.Annotations;
using PropertyChanged;

namespace CubeAssignment.Gui.Scene
{
    [AddINotifyPropertyChangedInterface]
    public class Camera : INotifyPropertyChanged
    {
        public const float DefaultTheta = -100;

        public const float DefaultPhi = -10;

        public const float DefaultR = 10;
        
        public const float DefaultD = 5;

        public static readonly Vector DefaultPosition = new Vector(0, 0, 3);

        public Vector Position { get; set; } = DefaultPosition;

        public float D { get; set; } = DefaultD;

        public float R { get; set; } = DefaultR;

        public float Theta { get; set; } = DefaultTheta;

        public float Phi { get; set; } = DefaultPhi;
        
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
            Position = DefaultPosition;
            Theta = DefaultTheta;
            Phi = DefaultPhi;
            R = DefaultR;
            D = DefaultD;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}