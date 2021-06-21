namespace CubeAssignment.Gui
{
    /// <summary>
    /// 4 dimensional Matrix 
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Underlying 4x4 multidimensional matrix array. 
        /// </summary>
        public float[,] mat = new float[4, 4];

        /// <summary>
        /// Creates default identity matrix.
        /// </summary>
        public Matrix()
        {
            mat[0, 0] = 1;
            mat[1, 1] = 1;
            mat[2, 2] = 1;
            mat[3, 3] = 1;
        }

        /// <summary>
        /// Creates Matrix with the given values.
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
        /// Creates a projection matrix with the given distance.
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static Matrix CreateProjection(float distance, float z)
        {
            var projectedZ = 1 / (distance - z);
            var projectionMatrix = new Matrix(
                projectedZ, 0, 0, 0,
                0, projectedZ, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
            );
            return projectionMatrix;
        }

        /// <summary>
        /// Creates a transformation matrix that can be used for scaling, rotating, and translating. 
        /// </summary>
        /// <param name="scale"></param>
        /// <param name="rotate"></param>
        /// <param name="translate"></param>
        /// <returns></returns>
        public static Matrix ModelTransformation(Vector scale, Vector rotate, Vector translate)
        {
            Matrix scaleMatrix = Scale(scale);
            Matrix rotationMatrixX = RotateX(rotate.x);
            Matrix rotationMatrixY = RotateY(rotate.y);
            Matrix rotationMatrixZ = RotateZ(rotate.z);
            
            var translateMatrix = CreateTranslation(translate);

            return translateMatrix * rotationMatrixX * rotationMatrixY * rotationMatrixZ * scaleMatrix;
        }

        /// <summary>
        /// Creates a matrix that looks from the given camera position towards a given target. 
        /// </summary>
        /// <param name="cameraPosition"></param>
        /// <param name="cameraTarget"></param>
        /// <param name="cameraUpVector"></param>
        /// <returns></returns>
        public static Matrix CreateLookAt(Vector cameraPosition, Vector cameraTarget, Vector cameraUpVector)
        {
            Vector zaxis = Vector.Normalize(cameraPosition - cameraTarget);
            Vector xaxis = Vector.Normalize(Vector.Cross(cameraUpVector, zaxis));
            Vector yaxis = Vector.Cross(zaxis, xaxis);

            var result = new Matrix();

            result[0, 0] = xaxis.x;
            result[0, 1] = yaxis.x;
            result[0, 2] = zaxis.x;
            result[0, 3] = 0.0f;
            result[1, 0] = xaxis.y;
            result[1, 1] = yaxis.y;
            result[1, 2] = zaxis.y;
            result[1, 3] = 0.0f;
            result[2, 0] = xaxis.z;
            result[2, 1] = yaxis.z;
            result[2, 2] = zaxis.z;
            result[2, 3] = 0.0f;
            result[3, 0] = -Vector.Dot(xaxis, cameraPosition);
            result[3, 1] = -Vector.Dot(yaxis, cameraPosition);
            result[3, 2] = -Vector.Dot(zaxis, cameraPosition);
            result[3, 3] = 1.0f;

            return result;
        }

        /// <summary>
        /// Gets a value from the matrix using two indices.
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
        /// Returns the result of two matrices added. 
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            var resultMatrix = new Matrix();

            for (var k = 0; k < m1.mat.GetLength(0); k++)
            for (var l = 0; l < m2.mat.GetLength(1); l++)
            {
                resultMatrix[k, l] = m1[k, l] + m2[k, l];
            }

            return resultMatrix;
        }

        /// <summary>
        /// Returns the result of two matrices subtracted. 
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            var resultMatrix = new Matrix();

            for (var k = 0; k < m1.mat.GetLength(0); k++)
            for (var l = 0; l < m2.mat.GetLength(1); l++)
            {
                resultMatrix[k, l] = m1[k, l] - m2[k, l];
            }

            return resultMatrix;
        }

        /// <summary>
        /// Returns the result of a matrix multiplied by a float value. 
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static Matrix operator *(Matrix m1, float f)
        {
            var resultMatrix = new Matrix();

            for (var k = 0; k < m1.mat.GetLength(0); k++)
            for (var l = 0; l < m1.mat.GetLength(1); l++)
            {
                resultMatrix[k, l] = m1[k, l] * f;
            }

            return resultMatrix;
        }

        /// <summary>
        /// Returns the result of a float multiplied by a matrix.
        /// </summary>
        /// <param name="f"></param>
        /// <param name="m1"></param>
        /// <returns></returns>
        public static Matrix operator *(float f, Matrix m1)
        {
            return m1 * f;
        }

        /// <summary>
        /// Returns a scale matrix with the given scale vector. 
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
        /// Returns the result of two matrices multiplied. 
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            var resultMatrix = new Matrix();

            for (var row = 0; row < 4; ++row)
            {
                for (var column = 0; column < 4; ++column)
                {
                    var s = 0.0f;
                    for (var index = 0; index < 4; ++index)
                    {
                        s += m1[row, index] * m2[index, column];
                    }

                    resultMatrix[row, column] = s;
                }
            }

            return resultMatrix;
        }

        /// <summary>
        ///  Returns a translation matrix with the given translation vector. 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public static Matrix CreateTranslation(Vector position)
        {
            var result = new Matrix();

            result[0, 0] = 1.0f;
            result[0, 1] = 0.0f;
            result[0, 2] = 0.0f;
            result[0, 3] = 0.0f;
            result[1, 0] = 0.0f;
            result[1, 1] = 1.0f;
            result[1, 2] = 0.0f;
            result[1, 3] = 0.0f;
            result[2, 0] = 0.0f;
            result[2, 1] = 0.0f;
            result[2, 2] = 1.0f;
            result[2, 3] = 0.0f;

            result[3, 0] = position.x;
            result[3, 1] = position.y;
            result[3, 2] = position.z;
            result[3, 3] = 1.0f;

            return result;
        }

        /// <summary>
        /// Returns an identity matrix.
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

        /// <summary>
        /// Returns a matrix that rotates N radians around the x axis. 
        /// </summary>
        /// <param name="radians"></param>
        /// <returns></returns>
        public static Matrix RotateX(float radians)
        {
            var newMatrix = new Matrix
            {
                [0, 0] = 1,
                [1, 1] = (float) System.Math.Cos(radians),
                [1, 2] = (float) -System.Math.Sin(radians),
                [2, 1] = (float) System.Math.Sin(radians),
                [2, 2] = (float) System.Math.Cos(radians)
            };

            return newMatrix;
        }

        /// <summary>
        /// Returns a matrix that rotates N radians around the y axis. 
        /// </summary>
        /// <param name="radians"></param>
        /// <returns></returns>
        public static Matrix RotateY(float radians)
        {
            var newMatrix = new Matrix
            {
                [0, 0] = (float) System.Math.Cos(radians),
                [0, 2] = (float) System.Math.Sin(radians),
                [1, 1] = 1f,
                [2, 0] = (float) -System.Math.Sin(radians),
                [2, 2] = (float) System.Math.Cos(radians)
            };

            return newMatrix;
        }

        /// <summary>
        /// Returns a matrix that rotates N radians around the z axis. 
        /// </summary>
        /// <param name="radians"></param>
        /// <returns></returns>
        public static Matrix RotateZ(float radians)
        {
            var newMatrix = new Matrix
            {
                [0, 0] = (float) System.Math.Cos(radians),
                [0, 1] = (float) -System.Math.Sin(radians),
                [1, 0] = (float) System.Math.Sin(radians),
                [1, 1] = (float) System.Math.Cos(radians),
                [2, 2] = 1f
            };

            return newMatrix;
        }

        public override string ToString()
        {
            return $@"[ {mat[0, 0]} {mat[0, 1]}, {mat[1, 0]}, {mat[1, 1]}]";
        }

        /// <summary>
        /// Inverts the current matrix return the result. 
        /// </summary>
        /// <returns></returns>
        public Matrix Invert()
        {
            // Use Laplace expansion theorem to calculate the inverse of a 4x4 matrix
            // 
            // 1. Calculate the 2x2 determinants needed the 4x4 determinant based on the 2x2 determinants 
            // 3. Create the adjugate matrix, which satisfies: A * adj(A) = det(A) * I
            // 4. Divide adjugate matrix with the determinant to find the inverse

            float det1, det2, det3, det4, det5, det6, det7, det8, det9, det10, det11, det12;
            float detMatrix;

            findDeterminants(this, out detMatrix, out det1, out det2, out det3, out det4, out det5, out det6,
                out det7, out det8, out det9, out det10, out det11, out det12);

            var invDetMatrix = 1f / detMatrix;

            var ret = new Matrix();

            ret[0, 0] = (mat[1, 1] * det12 - mat[1, 2] * det11 + mat[1, 3] * det10) * invDetMatrix;
            ret[0, 1] = (-mat[0, 1] * det12 + mat[0, 2] * det11 - mat[0, 3] * det10) * invDetMatrix;
            ret[0, 2] = (mat[3, 1] * det6 - mat[3, 2] * det5 + mat[3, 3] * det4) * invDetMatrix;
            ret[0, 3] = (-mat[2, 1] * det6 + mat[2, 2] * det5 - mat[2, 3] * det4) * invDetMatrix;
            ret[1, 0] = (-mat[1, 0] * det12 + mat[1, 2] * det9 - mat[1, 3] * det8) * invDetMatrix;
            ret[1, 1] = (mat[0, 0] * det12 - mat[0, 2] * det9 + mat[0, 3] * det8) * invDetMatrix;
            ret[1, 2] = (-mat[3, 0] * det6 + mat[3, 2] * det3 - mat[3, 3] * det2) * invDetMatrix;
            ret[1, 3] = (mat[2, 0] * det6 - mat[2, 2] * det3 + mat[2, 3] * det2) * invDetMatrix;
            ret[2, 0] = (mat[1, 0] * det11 - mat[1, 1] * det9 + mat[1, 3] * det7) * invDetMatrix;
            ret[2, 1] = (-mat[0, 0] * det11 + mat[0, 1] * det9 - mat[0, 3] * det7) * invDetMatrix;
            ret[2, 2] = (mat[3, 0] * det5 - mat[3, 1] * det3 + mat[3, 3] * det1) * invDetMatrix;
            ret[2, 3] = (-mat[2, 0] * det5 + mat[2, 1] * det3 - mat[2, 3] * det1) * invDetMatrix;
            ret[3, 0] = (-mat[1, 0] * det10 + mat[1, 1] * det8 - mat[1, 2] * det7) * invDetMatrix;
            ret[3, 1] = (mat[0, 0] * det10 - mat[0, 1] * det8 + mat[0, 2] * det7) * invDetMatrix;
            ret[3, 2] = (-mat[3, 0] * det4 + mat[3, 1] * det2 - mat[3, 2] * det1) * invDetMatrix;
            ret[3, 3] = (mat[2, 0] * det4 - mat[2, 1] * det2 + mat[2, 2] * det1) * invDetMatrix;

            return ret;
        }

        /// <summary>
        /// Find the determinants for the given matrix. 
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="major"></param>
        /// <param name="minor1"></param>
        /// <param name="minor2"></param>
        /// <param name="minor3"></param>
        /// <param name="minor4"></param>
        /// <param name="minor5"></param>
        /// <param name="minor6"></param>
        /// <param name="minor7"></param>
        /// <param name="minor8"></param>
        /// <param name="minor9"></param>
        /// <param name="minor10"></param>
        /// <param name="minor11"></param>
        /// <param name="minor12"></param>
        private static void findDeterminants(Matrix matrix, out float major,
            out float minor1, out float minor2, out float minor3, out float minor4, out float minor5, out float minor6,
            out float minor7, out float minor8, out float minor9, out float minor10, out float minor11,
            out float minor12)
        {
            var det1 = (double) matrix[0, 0] * (double) matrix[1, 1] - (double) matrix[0, 1] * (double) matrix[1, 0];
            var det2 = (double) matrix[0, 0] * (double) matrix[1, 2] - (double) matrix[0, 2] * (double) matrix[1, 0];
            var det3 = (double) matrix[0, 0] * (double) matrix[1, 3] - (double) matrix[0, 3] * (double) matrix[1, 0];
            var det4 = (double) matrix[0, 1] * (double) matrix[1, 2] - (double) matrix[0, 2] * (double) matrix[1, 1];
            var det5 = (double) matrix[0, 1] * (double) matrix[1, 3] - (double) matrix[0, 3] * (double) matrix[1, 1];
            var det6 = (double) matrix[0, 2] * (double) matrix[1, 3] - (double) matrix[0, 3] * (double) matrix[1, 2];
            var det7 = (double) matrix[2, 0] * (double) matrix[3, 1] - (double) matrix[2, 1] * (double) matrix[3, 0];
            var det8 = (double) matrix[2, 0] * (double) matrix[3, 2] - (double) matrix[2, 2] * (double) matrix[3, 0];
            var det9 = (double) matrix[2, 0] * (double) matrix[3, 3] - (double) matrix[2, 3] * (double) matrix[3, 0];
            var det10 = (double) matrix[2, 1] * (double) matrix[3, 2] - (double) matrix[2, 2] * (double) matrix[3, 1];
            var det11 = (double) matrix[2, 1] * (double) matrix[3, 3] - (double) matrix[2, 3] * (double) matrix[3, 1];
            var det12 = (double) matrix[2, 2] * (double) matrix[3, 3] - (double) matrix[2, 3] * (double) matrix[3, 2];

            major = (float) (det1 * det12 - det2 * det11 + det3 * det10 + det4 * det9 - det5 * det8 + det6 * det7);
            minor1 = (float) det1;
            minor2 = (float) det2;
            minor3 = (float) det3;
            minor4 = (float) det4;
            minor5 = (float) det5;
            minor6 = (float) det6;
            minor7 = (float) det7;
            minor8 = (float) det8;
            minor9 = (float) det9;
            minor10 = (float) det10;
            minor11 = (float) det11;
            minor12 = (float) det12;
        }
    }
}