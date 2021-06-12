using System;

namespace CubeAssignment.Gui
{
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
    }
}