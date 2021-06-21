using System;

namespace CubeAssignment.Gui
{
    /// <summary>
    ///     Vector with 4 floats.
    /// </summary>
    public struct Vector
    {
        /// <summary>
        ///     Float values.
        /// </summary>
        public float x, y, z, w;

        /// <summary>
        ///     Creates a vector with 4 floats.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public Vector(float x = 0, float y = 0, float z = 0, float w = 1)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        ///     Vector with the values 0.
        /// </summary>
        public static Vector NullVector { get; } = new Vector(0);

        /// <summary>
        ///     Adds two vectors and returns a new vector.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z, v1.w + v2.w);
        }

        /// <summary>
        ///     Subtracts two vectors and returns a new vector.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z, v1.w - v2.w);
        }

        /// <summary>
        ///     Multiplies two vectors and returns a new vector.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector operator *(Vector v1, float value)
        {
            return new Vector(v1.x * value, v1.y * value, v1.z * value, v1.w * value);
        }

        /// <summary>
        ///     Returns the dot product of two vectors.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static float Dot(Vector vector1, Vector vector2)
        {
            return vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z;
        }

        /// <summary>
        ///     Returns the normalized vector.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Vector Normalize(Vector value)
        {
            var factor = (float) Math.Sqrt(value.x * value.x + value.y * value.y + value.z * value.z);
            factor = 1f / factor;
            return new Vector(value.x * factor, value.y * factor, value.z * factor);
        }

        /// <summary>
        ///     Transforms a given vector with the given matrix.
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static Vector Transform(Vector vector, Matrix matrix)
        {
            return new Vector(
                vector.x * matrix[0, 0] + vector.y * matrix[1, 0] + vector.z * matrix[2, 0] + vector.w * matrix[3, 0],
                vector.x * matrix[0, 1] + vector.y * matrix[1, 1] + vector.z * matrix[2, 1] + vector.w * matrix[3, 1],
                vector.x * matrix[0, 2] + vector.y * matrix[1, 2] + vector.z * matrix[2, 2] + vector.w * matrix[3, 2],
                vector.x * matrix[0, 3] + vector.y * matrix[1, 3] + vector.z * matrix[2, 3] + vector.w * matrix[3, 3]);
        }

        /// <summary>
        ///     Returns the cross product of the two given vectors.
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns></returns>
        public static Vector Cross(Vector vector1, Vector vector2)
        {
            var x = vector1.y * vector2.z - vector2.y * vector1.z;
            var y = -(vector1.x * vector2.z - vector2.x * vector1.z);
            var z = vector1.x * vector2.y - vector2.x * vector1.y;

            return new Vector(x, y, z);
        }

        public override string ToString()
        {
            return $"X:{x:F}, Y:{y:F}, Z:{z:F}";
        }
    }
}