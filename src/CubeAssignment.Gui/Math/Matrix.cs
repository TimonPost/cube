using System;

namespace CubeAssignment.Gui
{
    /// <summary>
    ///     4 dimensional Matrix
    /// </summary>
    public class Matrix
    {
        /// <summary>
        ///     Underlying 4x4 multidimensional matrix array.
        /// </summary>
        public float[,] mat = new float[4, 4];

        /// <summary>
        ///     Creates default identity matrix.
        /// </summary>
        public Matrix()
        {
            mat[0, 0] = 1;
            mat[1, 1] = 1;
            mat[2, 2] = 1;
            mat[3, 3] = 1;
        }

        public Matrix(Vector v)
        {
            mat[0, 0] = v.x;
            mat[0, 1] = 0;
            mat[0, 2] = 0;
            mat[0, 3] = 0;
            mat[1, 0] = v.y;
            mat[1, 1] = 1;
            mat[1, 2] = 0;
            mat[1, 3] = 0;
            mat[2, 0] = v.z;
            mat[2, 1] = 0;
            mat[2, 2] = 1;
            mat[2, 3] = 0;
            mat[3, 0] = v.w;
            mat[3, 1] = 0;
            mat[3, 2] = 0;
            mat[3, 3] = 1;
        }

        /// <summary>
        ///     Creates Matrix with the given values.
        /// </summary>
        /// <param name="m11"></param>
        /// <param name="m12"></param>
        /// <param name="m13"></param>
        /// <param name="m14"></param>
        /// <param name="m21"></param>
        /// <param name="m22"></param>
        /// <param name="m23"></param>
        /// <param name="m24"></param>
        /// <param name="m31"></param>
        /// <param name="m32"></param>
        /// <param name="m33"></param>
        /// <param name="m34"></param>
        /// <param name="m41"></param>
        /// <param name="m42"></param>
        /// <param name="m43"></param>
        /// <param name="m44"></param>
        public Matrix(
            float m11, float m12, float m13, float m14,
            float m21, float m22, float m23, float m24,
            float m31, float m32, float m33, float m34,
            float m41, float m42, float m43, float m44
        )
        {
            mat[0, 0] = m11;
            mat[0, 1] = m12;
            mat[0, 2] = m13;
            mat[0, 3] = m14;
            mat[1, 0] = m21;
            mat[1, 1] = m22;
            mat[1, 2] = m23;
            mat[1, 3] = m24;
            mat[2, 0] = m31;
            mat[2, 1] = m32;
            mat[2, 2] = m33;
            mat[2, 3] = m34;
            mat[3, 0] = m41;
            mat[3, 1] = m42;
            mat[3, 2] = m43;
            mat[3, 3] = m44;
        }

        /// <summary>
        ///     Gets a value from the matrix using two indices.
        /// </summary>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <returns></returns>
        public float this[int index1, int index2]
        {
            get => mat[index1, index2];
            set => mat[index1, index2] = value;
        }

        /// <summary>
        ///     Creates a transformation matrix that can be used for scaling, rotating, and translating.
        /// </summary>
        /// <param name="scale"></param>
        /// <param name="rotate"></param>
        /// <param name="translate"></param>
        /// <returns></returns>
        public static Matrix ModelTransformation(Vector scale, Vector rotate, Vector translate)
        {
            var scaleMatrix = Scale(scale);
            var rotationMatrixX = RotateX(rotate.x);
            var rotationMatrixY = RotateY(rotate.y);
            var rotationMatrixZ = RotateZ(rotate.z);

            var translateMatrix = CreateTranslation(translate);

            return translateMatrix * rotationMatrixX * rotationMatrixY * rotationMatrixZ * scaleMatrix;
        }

        /// <summary>
        ///     Returns the result of two matrices added.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            var resultMatrix = new Matrix();

            for (var k = 0; k < m1.mat.GetLength(0); k++)
            for (var l = 0; l < m2.mat.GetLength(1); l++)
                resultMatrix[k, l] = m1[k, l] + m2[k, l];

            return resultMatrix;
        }

        /// <summary>
        ///     Returns the result of two matrices subtracted.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            var resultMatrix = new Matrix();

            for (var k = 0; k < m1.mat.GetLength(0); k++)
            for (var l = 0; l < m2.mat.GetLength(1); l++)
                resultMatrix[k, l] = m1[k, l] - m2[k, l];

            return resultMatrix;
        }

        /// <summary>
        ///     Returns the result of a matrix multiplied by a float value.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static Matrix operator *(Matrix m1, float f)
        {
            var resultMatrix = new Matrix();

            for (var k = 0; k < m1.mat.GetLength(0); k++)
            for (var l = 0; l < m1.mat.GetLength(1); l++)
                resultMatrix[k, l] = m1[k, l] * f;

            return resultMatrix;
        }

        /// <summary>
        ///     Returns the result of a float multiplied by a matrix.
        /// </summary>
        /// <param name="f"></param>
        /// <param name="m1"></param>
        /// <returns></returns>
        public static Matrix operator *(float f, Matrix m1)
        {
            return m1 * f;
        }

        public static Vector operator *(Matrix m1, Vector v)
        {
            var vector = new Matrix(v);
            var result = m1 * vector;
            return result.ToVector();
        }

        public static Vector operator *(Vector v, Matrix m1)
        {
            var vectormatrix = new Matrix(v);
            var answer = m1 * vectormatrix;
            return answer.ToVector();
        }

        /// <summary>
        ///     Returns a scale matrix with the given scale vector.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static Matrix Scale(Vector vector)
        {
            var matrix = new Matrix();
            matrix[0, 0] = vector.x;
            matrix[1, 1] = vector.y;
            matrix[2, 2] = vector.z;
            matrix[3, 3] = 1;
            return matrix;
        }

        /// <summary>
        ///     Returns the result of two matrices multiplied.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            var resultMatrix = new Matrix();

            resultMatrix.mat[0, 0] = m1.mat[0, 0] * m2.mat[0, 0] + m1.mat[0, 1] * m2.mat[1, 0] +
                                     m1.mat[0, 2] * m2.mat[2, 0] + m1.mat[0, 3] * m2.mat[3, 0];
            resultMatrix.mat[0, 1] = m1.mat[0, 0] * m2.mat[0, 1] + m1.mat[0, 1] * m2.mat[1, 1] +
                                     m1.mat[0, 2] * m2.mat[2, 1] + m1.mat[0, 3] * m2.mat[3, 1];
            resultMatrix.mat[0, 2] = m1.mat[0, 0] * m2.mat[0, 2] + m1.mat[0, 1] * m2.mat[1, 2] +
                                     m1.mat[0, 2] * m2.mat[2, 2] + m1.mat[0, 3] * m2.mat[3, 2];
            resultMatrix.mat[0, 3] = m1.mat[0, 0] * m2.mat[0, 3] + m1.mat[0, 1] * m2.mat[1, 3] +
                                     m1.mat[0, 2] * m2.mat[2, 3] + m1.mat[0, 3] * m2.mat[3, 3];

            resultMatrix.mat[1, 0] = m1.mat[1, 0] * m2.mat[0, 0] + m1.mat[1, 1] * m2.mat[1, 0] +
                                     m1.mat[1, 2] * m2.mat[2, 0] + m1.mat[1, 3] * m2.mat[3, 0];
            resultMatrix.mat[1, 1] = m1.mat[1, 0] * m2.mat[0, 1] + m1.mat[1, 1] * m2.mat[1, 1] +
                                     m1.mat[1, 2] * m2.mat[2, 1] + m1.mat[1, 3] * m2.mat[3, 1];
            resultMatrix.mat[1, 2] = m1.mat[1, 0] * m2.mat[0, 2] + m1.mat[1, 1] * m2.mat[1, 2] +
                                     m1.mat[1, 2] * m2.mat[2, 2] + m1.mat[1, 3] * m2.mat[3, 2];
            resultMatrix.mat[1, 3] = m1.mat[1, 0] * m2.mat[0, 3] + m1.mat[1, 1] * m2.mat[1, 3] +
                                     m1.mat[1, 2] * m2.mat[2, 3] + m1.mat[1, 3] * m2.mat[3, 3];

            resultMatrix.mat[2, 0] = m1.mat[2, 0] * m2.mat[0, 0] + m1.mat[2, 1] * m2.mat[1, 0] +
                                     m1.mat[2, 2] * m2.mat[2, 0] + m1.mat[2, 3] * m2.mat[3, 0];
            resultMatrix.mat[2, 1] = m1.mat[2, 0] * m2.mat[0, 1] + m1.mat[2, 1] * m2.mat[1, 1] +
                                     m1.mat[2, 2] * m2.mat[2, 1] + m1.mat[2, 3] * m2.mat[3, 1];
            resultMatrix.mat[2, 2] = m1.mat[2, 0] * m2.mat[0, 2] + m1.mat[2, 1] * m2.mat[1, 2] +
                                     m1.mat[2, 2] * m2.mat[2, 2] + m1.mat[2, 3] * m2.mat[3, 2];
            resultMatrix.mat[2, 3] = m1.mat[2, 0] * m2.mat[0, 3] + m1.mat[2, 1] * m2.mat[1, 3] +
                                     m1.mat[2, 2] * m2.mat[2, 3] + m1.mat[2, 3] * m2.mat[3, 3];

            resultMatrix.mat[3, 0] = m1.mat[3, 0] * m2.mat[0, 0] + m1.mat[3, 1] * m2.mat[1, 0] +
                                     m1.mat[3, 2] * m2.mat[2, 0] + m1.mat[3, 3] * m2.mat[3, 0];
            resultMatrix.mat[3, 1] = m1.mat[3, 0] * m2.mat[0, 1] + m1.mat[3, 1] * m2.mat[1, 1] +
                                     m1.mat[3, 2] * m2.mat[2, 1] + m1.mat[3, 3] * m2.mat[3, 1];
            resultMatrix.mat[3, 2] = m1.mat[3, 0] * m2.mat[0, 2] + m1.mat[3, 1] * m2.mat[1, 2] +
                                     m1.mat[3, 2] * m2.mat[2, 2] + m1.mat[3, 3] * m2.mat[3, 2];
            resultMatrix.mat[3, 3] = m1.mat[3, 0] * m2.mat[0, 3] + m1.mat[3, 1] * m2.mat[1, 3] +
                                     m1.mat[3, 2] * m2.mat[2, 3] + m1.mat[3, 3] * m2.mat[3, 3];

            return resultMatrix;
        }

        /// <summary>
        ///     Returns a translation matrix with the given translation vector.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public static Matrix CreateTranslation(Vector position)
        {
            var matrix = new Matrix();
            matrix.mat[0, 3] = position.x;
            matrix.mat[1, 3] = position.y;
            matrix.mat[2, 3] = position.z;

            return matrix;
        }

        /// <summary>
        ///     Returns an identity matrix.
        /// </summary>
        /// <returns></returns>
        public static Matrix Identity()
        {
            var newMatrix = new Matrix
            {
                [0, 0] = 1,
                [1, 1] = 1,
                [2, 2] = 1,
                [3, 3] = 1
            };

            return newMatrix;
        }

        public Vector ToVector()
        {
            return new Vector(mat[0, 0], mat[1, 0], mat[2, 0]);
        }

        /// <summary>
        ///     Returns a matrix that rotates N radians around the x axis.
        /// </summary>
        /// <param name="radians"></param>
        /// <returns></returns>
        public static Matrix RotateX(float radians)
        {
            var newMatrix = new Matrix
            {
                [0, 0] = 1,
                [1, 1] = (float) Math.Cos(radians),
                [1, 2] = (float) -Math.Sin(radians),
                [2, 1] = (float) Math.Sin(radians),
                [2, 2] = (float) Math.Cos(radians)
            };

            return newMatrix;
        }

        /// <summary>
        ///     Returns a matrix that rotates N radians around the y axis.
        /// </summary>
        /// <param name="radians"></param>
        /// <returns></returns>
        public static Matrix RotateY(float radians)
        {
            var newMatrix = new Matrix
            {
                [0, 0] = (float) Math.Cos(radians),
                [0, 2] = (float) Math.Sin(radians),
                [1, 1] = 1f,
                [2, 0] = (float) -Math.Sin(radians),
                [2, 2] = (float) Math.Cos(radians)
            };

            return newMatrix;
        }

        /// <summary>
        ///     Returns a matrix that rotates N radians around the z axis.
        /// </summary>
        /// <param name="radians"></param>
        /// <returns></returns>
        public static Matrix RotateZ(float radians)
        {
            var newMatrix = new Matrix
            {
                [0, 0] = (float) Math.Cos(radians),
                [0, 1] = (float) -Math.Sin(radians),
                [1, 0] = (float) Math.Sin(radians),
                [1, 1] = (float) Math.Cos(radians),
                [2, 2] = 1f
            };

            return newMatrix;
        }

        public override string ToString()
        {
            return $@"[ {mat[0, 0]} {mat[0, 1]}, {mat[1, 0]}, {mat[1, 1]}]";
        }
    }
}