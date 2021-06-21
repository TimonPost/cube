using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
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
        private Mesh mesh;
        private Renderer renderer;
        private MeshSceneObject meshObject;
        private Camera camera;
        private CubeAnimationData animationState;
      
        [TestInitialize]
        public void Setup()
        {
            mesh = new Mesh(new ArraySegment<Vertex>(), new ArraySegment<int>());
            renderer = new Renderer(0, 0);
            meshObject = new MeshSceneObject(mesh, renderer);
            camera = new Camera();
            animationState = new CubeAnimationData(meshObject, camera);
        }

        [TestMethod]
        public void FirstPhaseTheta_Decrease_Test()
        {
            FirstPhaseScaleDecrease phase = new FirstPhaseScaleDecrease();

            int timesToTick = 20;
            
            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState);

            Assert.AreEqual(Math.Round(camera.Theta, 4), Math.Round(Camera.DefaultTheta - (Settings.THETA_STEP_SIZE * timesToTick+1)), 4);
        }


        [TestMethod]
        public void FirstPhaseTheta_Increase_Test()
        {
            FirstPhaseScaleIncrease phase = new FirstPhaseScaleIncrease();

            int timesToTick = 20;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState);

            Assert.AreEqual(Math.Round(camera.Theta, 4), Math.Round(Camera.DefaultTheta - (Settings.THETA_STEP_SIZE * timesToTick + 1)), 4);
        }
    }
}