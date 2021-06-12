using System.ComponentModel;
using System.Runtime.CompilerServices;
using CubeAssignment.Gui.Annotations;
using PropertyChanged;

namespace CubeAssignment.Gui.Scene
{
    [AddINotifyPropertyChangedInterface]
    public class Camera : INotifyPropertyChanged
    {
        public Vector Position { get; set; } = new Vector(0, 0, 3);

        public float D { get; set; } = 800;

        public float R { get; set; } = 10;

        public float Theta { get; set; } = -100;

        public float Phi { get; set; } = -10;


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
            Theta = -100;
            Phi = -10;
            R = 10;
            D = 800;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}