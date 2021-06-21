using System;
using System.Diagnostics;
using CubeAssignment.Gui;
using CubeAssignment.Gui.Animation;
using CubeAssignment.Gui.Animation.Phases;
using CubeAssignment.Gui.Scene;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeAssignment.Tests
{
    [TestClass]
    public class AnimationTests
    {
        [TestMethod]
        public void TestAnimationFirstPhase()
        {
            Mesh mesh = new Mesh(new ArraySegment<Vertex>(), new ArraySegment<int>());
            Renderer renderer = new Renderer(0, 0);
            MeshSceneObject meshObject = new MeshSceneObject(mesh, renderer);
            Camera camera = new Camera();

            var animationState = new CubeAnimationData(meshObject, camera);
            FirstPhaseScaleDecrease phase = new FirstPhaseScaleDecrease();

            int timesToTick = 20;

            for (int i = 0; i < timesToTick; i++)
            {
                phase.Tick(animationState);
            }

            Assert.AreEqual(camera.Theta, Camera.DEFAULT_THETA - (phase.StepSize * timesToTick));
        }
    }
}