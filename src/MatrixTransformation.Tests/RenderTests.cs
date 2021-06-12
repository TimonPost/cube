using System;
using MatrixTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTransformation.Tests
{
    [TestClass]
    public class RenderTests
    {
        // [TestMethod]
        // public void TestProjectionTransformation()
        // {
        //     var projectionMatrix = Renderer.ProjectionTransformation(10, 5);
        //     
        //     Assert.AreEqual(Math.Round(projectionMatrix[0, 0], 1), 0.2);
        //     Assert.AreEqual(Math.Round(projectionMatrix[1, 1], 1), 0.2);
        //     Assert.AreEqual(Math.Round(projectionMatrix[2, 2], 1), 1);
        //     Assert.AreEqual(Math.Round(projectionMatrix[3, 3], 1), 1);
        // }
        //
        // [TestMethod]
        // public void TestModelTransformationScale()
        // {
        //     var matrix1 = new Matrix(
        //         1, 2, 3, 4, 
        //         5, 6, 7, 8, 
        //         9, 10, 11, 12, 
        //         13, 14, 15, 16
        //     );
        //     
        //     var transformMatrix = Renderer.ModelTransformation(new Vector(2,2,2), new Vector(0,0,0), new Vector(0,0,0));
        //
        //     var result = matrix1* transformMatrix;
        //
        //     Assert.AreEqual(result[0, 0], 2);
        //     Assert.AreEqual(result[0, 1], 4);
        //     Assert.AreEqual(result[0, 2], 6);
        //     Assert.AreEqual(result[0, 3], 4);
        //
        //     Assert.AreEqual(result[1, 0], 10);
        //     Assert.AreEqual(result[1, 1], 12);
        //     Assert.AreEqual(result[1, 2], 14);
        //     Assert.AreEqual(result[1, 3], 8);
        //
        //     Assert.AreEqual(result[2, 0], 18);
        //     Assert.AreEqual(result[2, 1], 20);
        //     Assert.AreEqual(result[2, 2], 22);
        //     Assert.AreEqual(result[2, 3], 12);
        //
        //     Assert.AreEqual(result[3, 0], 26);
        //     Assert.AreEqual(result[3, 1], 28);
        //     Assert.AreEqual(result[3, 2], 30);
        //     Assert.AreEqual(result[3, 3], 16);
        // }
        //
        // [TestMethod]
        // public void TestModelTransformationRotation()
        // {
        //     var result = Renderer.ModelTransformation(new Vector(1,1,1), new Vector(90, 90, 90), new Vector(0, 0, 0));
        //
        //     Assert.AreEqual(Math.Round(result[0, 0], 3), 0.201);
        //     Assert.AreEqual(Math.Round(result[0, 1],3), 0.401);
        //     Assert.AreEqual(Math.Round(result[0, 2],3), 0.894);
        //     Assert.AreEqual(Math.Round(result[0, 3],3), 0);
        //      
        //     Assert.AreEqual(Math.Round(result[1, 0],3), -0.759);
        //     Assert.AreEqual(Math.Round(result[1, 1],3), -0.514);
        //     Assert.AreEqual(Math.Round(result[1, 2],3), 0.401);
        //     Assert.AreEqual(Math.Round(result[1, 3],3), 0);
        //                     
        //     Assert.AreEqual(Math.Round(result[2, 0],3), 0.620);
        //     Assert.AreEqual(Math.Round(result[2, 1],3), -0.759);
        //     Assert.AreEqual(Math.Round(result[2, 2],3), 0.201);
        //     Assert.AreEqual(Math.Round(result[2, 3],3), 0);
        // }
        //
        // [TestMethod]
        // public void TestModelTransformationTranslate()
        // {
        //     var result = Renderer.ModelTransformation(new Vector(1, 1, 1), new Vector(0, 0, 0), new Vector(5, 5, 5));
        //
        //     Assert.AreEqual(Math.Round(result[0, 0], 3), 1);
        //     Assert.AreEqual(Math.Round(result[0, 1], 3), 0);
        //     Assert.AreEqual(Math.Round(result[0, 2], 3), 0);
        //     Assert.AreEqual(Math.Round(result[0, 3], 3), 0);
        //
        //     Assert.AreEqual(Math.Round(result[1, 0], 3), 0);
        //     Assert.AreEqual(Math.Round(result[1, 1], 3), 1);
        //     Assert.AreEqual(Math.Round(result[1, 2], 3), 0);
        //     Assert.AreEqual(Math.Round(result[1, 3], 3), 0);
        //
        //     Assert.AreEqual(Math.Round(result[2, 0], 3), 0);
        //     Assert.AreEqual(Math.Round(result[2, 1], 3), 0);
        //     Assert.AreEqual(Math.Round(result[2, 2], 3), 1);
        //     Assert.AreEqual(Math.Round(result[2, 3], 3), 0);
        //
        //     Assert.AreEqual(Math.Round(result[3, 0], 3), 5);
        //     Assert.AreEqual(Math.Round(result[3, 1], 3), 5);
        //     Assert.AreEqual(Math.Round(result[3, 2], 3), 5);
        //     Assert.AreEqual(Math.Round(result[3, 3], 3), 1);
        // }
    }
}
