using System;
using MatrixTransformations.MathCustom;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTransformation.Tests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void TestRotationXMatrix()
        {
            var rotationMatrix = Matrix.RotateX((float)(Math.PI / 2f));
            var vector = new Vector(0f, 5f, 0f, 0);
            var rotatedVector = Vector.Transform(vector, rotationMatrix);
            Assert.AreEqual(0, rotatedVector.x, 0.01);
            Assert.AreEqual(0, rotatedVector.y, 0.01);
            Assert.AreEqual(-5, rotatedVector.z, 0.01);
        }

        [TestMethod]
        public void TestRotationYMatrix()
        {
            var rotationMatrix = Matrix.RotateY((float)(Math.PI / 2f));
            var vector = new Vector(5f, 0f, 0f, 0);
            var rotatedVector = Vector.Transform(vector, rotationMatrix);
            Assert.AreEqual(0, rotatedVector.x, 0.01);
            Assert.AreEqual(0, rotatedVector.y, 0.01);
            Assert.AreEqual(5, rotatedVector.z, 0.01);
        }

        [TestMethod]
        public void TestRotationZMatrix()
        {
            var rotationMatrix = Matrix.RotateZ((float)(Math.PI / 2f));
            var vector = new Vector(0f, 5f, 0f, 0);
            var rotatedVector = Vector.Transform(vector, rotationMatrix);
            Assert.AreEqual(5, rotatedVector.x, 0.01);
            Assert.AreEqual(0, rotatedVector.y, 0.01);
            Assert.AreEqual(0, rotatedVector.z, 0.01);
        }

        [TestMethod]
        public void TestScaleMatrix()
        {
            var scaleMatrix = Matrix.Scale(new Vector(2, 2, 2));
            var vector = new Vector(1f, 1f, 1f, 0);
            var scaledVector = Vector.Transform(vector, scaleMatrix);
            Assert.AreEqual(2, scaledVector.x);
            Assert.AreEqual(2, scaledVector.y);
            Assert.AreEqual(2, scaledVector.z);
        }

        [TestMethod]
        public void TestTranslateMatrix()
        {
            var translateMatrix = Matrix.CreateTranslation(new Vector(2, 2, 2));
            var vector = new Vector(1f, 1f, 1f, 1);
            var translatedVector = Vector.Transform(vector, translateMatrix);
            Assert.AreEqual(3, translatedVector.x);
            Assert.AreEqual(3, translatedVector.y);
            Assert.AreEqual(3, translatedVector.z);
        }

        [TestMethod]
        public void TestMultiplicationMatrix()
        {
            var matrix1 = new Matrix(
                2, 3, 4, 5,
                6, 7, 8, 9,
                10, 11, 12, 13, 
                14, 16, 16, 17
            );

            var matrix2 = new Matrix(
                10, 22, 35, 64,
                11, 25, 22, 36,
                25, 85, 95, 95,
                36, 69, 58, 48
            );

            var result = matrix1 * matrix2;
            
            Assert.AreEqual(result[0,0],  333);
            Assert.AreEqual(result[0, 1], 804);
            Assert.AreEqual(result[0, 2], 806);
            Assert.AreEqual(result[0, 3], 856);

            Assert.AreEqual(result[1, 0], 661);
            Assert.AreEqual(result[1, 1], 1608);
            Assert.AreEqual(result[1, 2], 1646);
            Assert.AreEqual(result[1, 3], 1828);

            Assert.AreEqual(result[2, 0], 989);
            Assert.AreEqual(result[2, 1], 2412);
            Assert.AreEqual(result[2, 2], 2486);
            Assert.AreEqual(result[2, 3], 2800);

            Assert.AreEqual(result[3, 0], 1328);
            Assert.AreEqual(result[3, 1], 3241);
            Assert.AreEqual(result[3, 2], 3348);
            Assert.AreEqual(result[3, 3], 3808);
        }

        [TestMethod]
        public void TestMultiplicationFloatMatrix()
        {
            var matrix1 = new Matrix(
                2, 3, 4, 5,
                6, 7, 8, 9,
                10, 11, 12, 13,
                14, 15, 16, 17
            );
            
            var result = matrix1 * 5;

            Assert.AreEqual(result[0, 0], 10);
            Assert.AreEqual(result[0, 1], 15);
            Assert.AreEqual(result[0, 2], 20);
            Assert.AreEqual(result[0, 3], 25);

            Assert.AreEqual(result[1, 0], 30);
            Assert.AreEqual(result[1, 1], 35);
            Assert.AreEqual(result[1, 2], 40);
            Assert.AreEqual(result[1, 3], 45);

            Assert.AreEqual(result[2, 0], 50);
            Assert.AreEqual(result[2, 1], 55);
            Assert.AreEqual(result[2, 2], 60);
            Assert.AreEqual(result[2, 3], 65);

            Assert.AreEqual(result[3, 0], 70);
            Assert.AreEqual(result[3, 1], 75);
            Assert.AreEqual(result[3, 2], 80);
            Assert.AreEqual(result[3, 3], 85);
        }

        [TestMethod]
        public void TestMatrixAddition()
        {
            var matrix1 = new Matrix(
                2, 3, 4, 5,
                6, 7, 8, 9,
                10, 11, 12, 13,
                14, 15, 16, 17
            );

            var matrix2 = new Matrix(
                10, 22, 35, 64,
                11, 25, 22, 36,
                25, 85, 95, 95,
                36, 69, 58, 48
            );

            var result = matrix1 + matrix2;

            Assert.AreEqual(result[0, 0], 12);
            Assert.AreEqual(result[0, 1], 25);
            Assert.AreEqual(result[0, 2], 39);
            Assert.AreEqual(result[0, 3], 69);

            Assert.AreEqual(result[1, 0], 17);
            Assert.AreEqual(result[1, 1], 32);
            Assert.AreEqual(result[1, 2], 30);
            Assert.AreEqual(result[1, 3], 45);

            Assert.AreEqual(result[2, 0], 35);
            Assert.AreEqual(result[2, 1], 96);
            Assert.AreEqual(result[2, 2], 107);
            Assert.AreEqual(result[2, 3], 108);

            Assert.AreEqual(result[3, 0], 50);
            Assert.AreEqual(result[3, 1], 84);
            Assert.AreEqual(result[3, 2], 74);
            Assert.AreEqual(result[3, 3], 65);
        }

        [TestMethod]
        public void TestMatrixSubtraction()
        {
            var matrix1 = new Matrix(
                10, 22, 35, 64,
                11, 25, 22, 36,
                25, 85, 95, 95,
                36, 69, 58, 48
            );

            var matrix2 = new Matrix(
                2, 3, 4, 5,
                6, 7, 8, 9,
                10, 11, 12, 13,
                14, 15, 16, 17
            );
            
            var result = matrix1 - matrix2;

            Assert.AreEqual(result[0, 0], 8);
            Assert.AreEqual(result[0, 1], 19);
            Assert.AreEqual(result[0, 2], 31);
            Assert.AreEqual(result[0, 3], 59);

            Assert.AreEqual(result[1, 0], 5);
            Assert.AreEqual(result[1, 1], 18);
            Assert.AreEqual(result[1, 2], 14);
            Assert.AreEqual(result[1, 3], 27);

            Assert.AreEqual(result[2, 0], 15);
            Assert.AreEqual(result[2, 1], 74);
            Assert.AreEqual(result[2, 2], 83);
            Assert.AreEqual(result[2, 3], 82);

            Assert.AreEqual(result[3, 0], 22);
            Assert.AreEqual(result[3, 1], 54);
            Assert.AreEqual(result[3, 2], 42);
            Assert.AreEqual(result[3, 3], 31);
        }

        [TestMethod]
        public void TestMatrixIndex()
        {
            var matrix1 = new Matrix(
                10, 22, 35, 64,
                11, 25, 22, 36,
                25, 85, 95, 95,
                36, 69, 58, 48
            );
            
            Assert.AreEqual(matrix1[0, 0], 10);
            Assert.AreEqual(matrix1[0, 1], 22);
            Assert.AreEqual(matrix1[0, 2], 35);
            Assert.AreEqual(matrix1[0, 3], 64);
                            
            Assert.AreEqual(matrix1[1, 0], 11);
            Assert.AreEqual(matrix1[1, 1], 25);
            Assert.AreEqual(matrix1[1, 2], 22);
            Assert.AreEqual(matrix1[1, 3], 36);
                            
            Assert.AreEqual(matrix1[2, 0], 25);
            Assert.AreEqual(matrix1[2, 1], 85);
            Assert.AreEqual(matrix1[2, 2], 95);
            Assert.AreEqual(matrix1[2, 3], 95);
                            
            Assert.AreEqual(matrix1[3, 0], 36);
            Assert.AreEqual(matrix1[3, 1], 69);
            Assert.AreEqual(matrix1[3, 2], 58);
            Assert.AreEqual(matrix1[3, 3], 48);
        }

        [TestMethod]
        public void MatrixInversion()
        {
            var matrix1 = new Matrix(
                1, 1, 1, -1,
                1, 1, -1, 1,
                1, -1, 1, 1,
                -1, 1, 1, 1
            );

            var a = matrix1.Invert();
        }
    }
}
