using System.ComponentModel;
using System.Runtime.CompilerServices;
using CubeAssignment.Gui.Annotations;
using PropertyChanged;

namespace CubeAssignment.Gui.Scene
{
    /// <summary>
    /// An basic camera.
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class Camera
    {
        /// <summary>
        /// Default value for <see cref="Theta"/>. 
        /// </summary>
        public static float DefaultTheta = -100;

        /// <summary>
        /// Default value for <see cref="Phi"/>.
        /// </summary>
        public static float DefaultPhi = -10;

        /// <summary>
        /// Default value for <see cref="Position"/>
        /// </summary>
        public static Vector DefaultPosition = new Vector(0, 0, 3);

        /// <summary>
        /// Default value for <see cref="D"/>
        /// </summary>
        public static float DefaultD = 5;

        /// <summary>
        /// Default value for <see cref="R"/>
        /// </summary>
        public static float DefaultR = 10;

        /// <summary>
        /// The position of the camera in world space. 
        /// </summary>
        public Vector Position { get; set; } = DefaultPosition;

        /// <summary>
        /// The distance from origin to the camera lens.
        /// </summary>
        public float D { get; set; } = DefaultD;
        
        public float R { get; set; } = DefaultR;

        /// <summary>
        /// The theta value of the camera. 
        /// </summary>
        public float Theta { get; set; } = DefaultTheta;

        /// <summary>
        /// The PHI value of the camera. 
        /// </summary>

        public float Phi { get; set; } = DefaultPhi;
        
        /// <summary>
        /// Returns the view matrix of this camera.
        /// </summary>
        /// <returns></returns>
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
        
        /// <summary>
        /// Resets the camera values: position, theta, phi, R, and D to be default values. 
        /// </summary>
        public void Reset()
        {
            Position = DefaultPosition;
            Theta = DefaultTheta;
            Phi = DefaultPhi;
            R = DefaultR;
            D = DefaultD;
        }
    }
}