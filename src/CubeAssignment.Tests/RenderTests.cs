using CubeAssignment.Gui;
using CubeAssignment.Gui.Scene;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeAssignment.Tests
{
    [TestClass]
    public class RenderTests
    {
        [TestMethod]
        public void TestProjectionTransformation()
        {
            Vector original = new Vector(2, 1, -5, 1);

            Matrix projectionMatrix = Renderer.ProjectionTransformation(50f, original.z);

            Assert.AreEqual(10 ,projectionMatrix[0,0]);
            Assert.AreEqual(10 ,projectionMatrix[1,1]);

            Vector result = Vector.Transform(original, projectionMatrix);
         
            Assert.AreEqual(20, result.x);
            Assert.AreEqual(10, result.y);
        }
    }
}
