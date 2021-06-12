using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTransformations
{
    internal static class Utils
    {
        public static float DegreesToRadians(float val)
        {
            return (float) (Math.PI / 180f * val);
        }
    }
}