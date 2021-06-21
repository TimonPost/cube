using System;
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
            camera[0, 0] = -MathF.Sin(Theta);
            camera[0, 1] = MathF.Cos(Theta);

            camera[1, 0] = -MathF.Cos(Theta) * MathF.Cos(Phi);
            camera[1, 1] = -MathF.Cos(Phi) * MathF.Sin(Theta);
            camera[1, 2] = MathF.Sin(Phi);

            camera[2, 0] = MathF.Cos(Theta) * MathF.Sin(Phi);
            camera[2, 1] = MathF.Sin(Theta) * MathF.Sin(Phi);
            camera[2, 2] = MathF.Cos(Phi);
            camera[2, 3] = MathF.Cos(-R);

            return camera;
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