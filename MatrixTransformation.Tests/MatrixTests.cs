using System;
using MatrixTransformations.Math;
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
    }
}
