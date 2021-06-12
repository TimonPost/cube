using MatrixTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTransformation.Tests
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void VectorAdd()
        {
            var vector1 = new Vector(2, 3, 4);
            var vector2 = new Vector(2, 3, 4);

            var actual = vector1 + vector2;

            Assert.AreEqual(actual.x, 4);
            Assert.AreEqual(actual.y, 6);
            Assert.AreEqual(actual.z, 8);
        }

        [TestMethod]
        public void VectorSub()
        {
            var vector1 = new Vector(2, 3, 4);
            var vector2 = new Vector(2, 3, 4);

            var actual = vector1 - vector2;

            Assert.AreEqual(actual.x, 0);
            Assert.AreEqual(actual.y, 0);
            Assert.AreEqual(actual.z, 0);
        }


        [TestMethod]
        public void VectorMultiply()
        {
            var vector1 = new Vector(2, 3, 4);

            var actual = vector1 * 2;

            Assert.AreEqual(actual.x, 4);
            Assert.AreEqual(actual.y, 6);
            Assert.AreEqual(actual.z, 8);
        }

        [TestMethod]
        public void VectorNormalize()
        {
            var vector1 = new Vector(3, 1, 2);

            var actual = Vector.Normalize(vector1);

            Assert.AreEqual(actual.x, 0.801783681f);
            Assert.AreEqual(actual.y, 0.267261237f);
            Assert.AreEqual(actual.z, 0.534522474f);
        }

        [TestMethod]
        public void VectorCross()
        {
            var vector1 = new Vector(62, 10, 11);
            var vector2 = new Vector(19, 5, 58);

            var actual = Vector.Cross(vector1, vector2);

            Assert.AreEqual(actual.x, 525);
            Assert.AreEqual(actual.y, -3387);
            Assert.AreEqual(actual.z, 120);
        }

        [TestMethod]
        public void VectorDot()
        {
            var vector1 = new Vector(22, 10, 13);
            var vector2 = new Vector(9, 75, 57);

            var actual = Vector.Dot(vector1, vector2);

            Assert.AreEqual(actual, 1689);
        }
    }
}