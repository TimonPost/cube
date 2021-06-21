using System;
using PropertyChanged;

namespace CubeAssignment.Gui.Scene
{
    /// <summary>
    ///     An basic camera.
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class Camera
    {
        /// <summary>
        ///     Default value for <see cref="Theta" />.
        /// </summary>
        public static float DefaultTheta = -100;

        /// <summary>
        ///     Default value for <see cref="Phi" />.
        /// </summary>
        public static float DefaultPhi = -10;

        /// <summary>
        ///     Default value for <see cref="Distance" />
        /// </summary>
        public static float DefaultD = 800;

        /// <summary>
        ///     Default value for <see cref="R" />
        /// </summary>
        public static float DefaultR = 10;

        /// <summary>
        ///     The distance from origin to the camera lens.
        /// </summary>
        public float Distance { get; set; } = DefaultD;

        public float R { get; set; } = DefaultR;

        /// <summary>
        ///     The theta value of the camera.
        /// </summary>
        public float Theta { get; set; } = DefaultTheta;

        /// <summary>
        ///     The PHI value of the camera.
        /// </summary>

        public float Phi { get; set; } = DefaultPhi;

        /// <summary>
        ///     Returns the view matrix of this camera.
        /// </summary>
        /// <returns></returns>
        public Matrix GetMatrix()
        {
            var thetaRadians = Utils.DegreesToRadians(Theta);
            var phiRadians = Utils.DegreesToRadians(Phi);

            var camera = Matrix.Identity();
            camera[0, 0] = -MathF.Sin(thetaRadians);
            camera[0, 1] = MathF.Cos(thetaRadians);

            camera[1, 0] = -MathF.Cos(thetaRadians) * MathF.Cos(phiRadians
            );
            camera[1, 1] = -MathF.Cos(phiRadians
            ) * MathF.Sin(thetaRadians);
            camera[1, 2] = MathF.Sin(phiRadians
            );

            camera[2, 0] = MathF.Cos(thetaRadians) * MathF.Sin(phiRadians
            );
            camera[2, 1] = MathF.Sin(thetaRadians) * MathF.Sin(phiRadians
            );
            camera[2, 2] = MathF.Cos(phiRadians
            );
            camera[2, 3] = -R;

            return camera;
        }

        /// <summary>
        ///     Resets the camera values: position, theta, phi, R, and D to be default values.
        /// </summary>
        public void Reset()
        {
            Theta = DefaultTheta;
            Phi = DefaultPhi;
            R = DefaultR;
            Distance = DefaultD;
        }
    }
}