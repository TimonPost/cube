using System;

namespace CubeAssignment.Gui
{
    internal static class Utils
    {
        public static float DegreesToRadians(float val)
        {
            return MathF.PI / 180f * val;
        }
    }
}