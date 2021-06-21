using System;

namespace CubeAssignment.Gui
{
    /// <summary>
    /// Helper utilities. 
    /// </summary>
    internal static class Utils
    {
        /// <summary>
        /// Converts degrees to radians
        /// </summary>
        /// <param name="degrees"></param>
        /// <returns></returns>
        public static float DegreesToRadians(float degrees)
        {
            return MathF.PI / 180f * degrees;
        }

        /// <summary>
        /// Converts radians to degrees
        /// </summary>
        /// <param name="degrees"></param>
        /// <returns></returns>
        public static float RadiansToDegrees(float radians)
        {
            return radians * (180 / MathF.PI);
        }

        public static float DeltaChange(float deltaTime)
        {
            return deltaTime * Settings.StepSize * Settings.Speed;
        }
    }
}