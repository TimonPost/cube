namespace MatrixTransformations.Math
{
    public class Matrix
    {
        public float[,] mat = new float[4, 4];

        public Matrix()
        {
            mat[0, 0] = 1;
            mat[1, 1] = 1;
            mat[2, 2] = 1;
            mat[3, 3] = 1;
        }

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

        public static Matrix CreateProjection(float distance, float z)
        {
            float projectedZ = 1 / (distance - z);
            var projectionMatrix = new Matrix(
                projectedZ, 0, 0, 0,
                0, projectedZ, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
            );
            return projectionMatrix;
        }

        public static Matrix CreateLookAt(Vector cameraPosition, Vector cameraTarget, Vector cameraUpVector)
        {
            Vector zaxis = Vector.Normalize(cameraPosition - cameraTarget);
            Vector xaxis = Vector.Normalize(Vector.Cross(cameraUpVector, zaxis));
            Vector yaxis = Vector.Cross(zaxis, xaxis);

            Matrix result = new Matrix();

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

        public float this[int index1, int index2]
        {
            get => mat[index1, index2];
            set => mat[index1, index2] = value;
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            var resultMatrix = new Matrix();

            for (int k = 0; k < m1.mat.GetLength(0); k++)
                for (int l = 0; l < m2.mat.GetLength(1); l++)
                    resultMatrix[k, l] = m1[k, l] + m2[k, l];

            return resultMatrix;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            var resultMatrix = new Matrix();

            for (int k = 0; k < m1.mat.GetLength(0); k++)
                for (int l = 0; l < m2.mat.GetLength(1); l++)
                    resultMatrix[k, l] = m1[k, l] - m2[k, l];

            return resultMatrix;
        }
        public static Matrix operator *(Matrix m1, float f)
        {
            var resultMatrix = new Matrix();

            for (int k = 0; k < m1.mat.GetLength(0); k++)
                for (int l = 0; l < m1.mat.GetLength(1); l++)
                    resultMatrix[k, l] = m1[k, l] * f;

            return resultMatrix;
        }

        public static Matrix operator *(float f, Matrix m1)
        {
            return m1 * f;
        }

        public static Matrix Scale(Vector vector)
        {
            var matrix = new Matrix();
            matrix[0, 0] = vector.x;
            matrix[1, 1] = vector.y;
            matrix[2, 2] = vector.z;
            matrix[3, 3] = 1;
            return matrix;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            var resultMatrix = new Matrix();

            for (var row = 0; row < 4; ++row)
            {
                for (var column = 0; column < 4; ++column)
                {
                    float s = 0.0f;
                    for (var index = 0; index < 4; ++index)
                    {
                        s += m1[row, index] * m2[index, column];
                    }
                    resultMatrix[row, column] = s;
                }
            }

            return resultMatrix;
        }

        public static Matrix CreateTranslation(Vector position)
        {
            Matrix result = new Matrix();

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

        public static Matrix RotateX(float radians)
        {
            var newMatrix = new Matrix
            {
                [0, 0] = 1,
                [1, 1] = (float)System.Math.Cos(radians),
                [1, 2] = (float)-System.Math.Sin(radians),
                [2, 1] = (float)System.Math.Sin(radians),
                [2, 2] = (float)System.Math.Cos(radians)
            };

            return newMatrix;
        }

        public static Matrix RotateY(float radians)
        {
            var newMatrix = new Matrix
            {
                [0, 0] = (float)System.Math.Cos(radians),
                [0, 2] = (float)System.Math.Sin(radians),
                [1, 1] = 1f,
                [2, 0] = (float)-System.Math.Sin(radians),
                [2, 2] = (float)System.Math.Cos(radians)
            };

            return newMatrix;
        }

        public static Matrix RotateZ(float radians)
        {
            var newMatrix = new Matrix
            {
                [0, 0] = (float)System.Math.Cos(radians),
                [0, 1] = (float)-System.Math.Sin(radians),
                [1, 0] = (float)System.Math.Sin(radians),
                [1, 1] = (float)System.Math.Cos(radians),
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
