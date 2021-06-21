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
        public void FirstPhase_Theta_Decrease_Test_1()
        {
            FirstPhaseScaleDecrease phase = new FirstPhaseScaleDecrease();

            int timesToTick = 20;
            
            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState);

            Assert.AreEqual(Math.Round(camera.Theta, 4), Math.Round(Camera.DefaultTheta - (Settings.StepSize * timesToTick+1)), 4);
        }


        [TestMethod]
        public void FirstPhase_Theta_Decrease_Test_2()
        {
            FirstPhaseScaleIncrease phase = new FirstPhaseScaleIncrease();

            int timesToTick = 20;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState);

            Assert.AreEqual(Math.Round(camera.Theta, 4), Math.Round(Camera.DefaultTheta - (Settings.StepSize * timesToTick + 1)), 4);
        }

        [TestMethod]
        public void FirstPhase_Scale_Decrease_Test()
        {
            FirstPhaseScaleDecrease phase = new FirstPhaseScaleDecrease();

            int timesToTick = 500;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState);

            Assert.IsTrue(meshObject.Scale.x <= 1.0);
            Assert.IsTrue(meshObject.Scale.y <= 1.0);
            Assert.IsTrue(meshObject.Scale.z <= 1.0);
        }


        [TestMethod]
        public void FirstPhase_Scale_Increase_Test()
        {
            FirstPhaseScaleIncrease phase = new FirstPhaseScaleIncrease();

            int timesToTick = 500;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState);

            Assert.IsTrue(meshObject.Scale.x >= 1.5);
            Assert.IsTrue(meshObject.Scale.y >= 1.5);
            Assert.IsTrue(meshObject.Scale.z >= 1.5);
        }

        [TestMethod]
        public void SecondPhase_Theta_Decrease_Test_1()
        {
            SecondPhaseRotationXDecrease phase = new SecondPhaseRotationXDecrease();

            int timesToTick = 20;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState);

            Assert.AreEqual(Math.Round(camera.Theta, 4), Math.Round(Camera.DefaultTheta - (Settings.StepSize * timesToTick + 1)), 4);
        }

        [TestMethod]
        public void SecondPhase_Theta_Decrease_Test_2()
        {
            SecondPhaseRotationXIncrease phase = new SecondPhaseRotationXIncrease();

            int timesToTick = 20;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState);

            Assert.AreEqual(Math.Round(camera.Theta, 4), Math.Round(Camera.DefaultTheta - (Settings.StepSize * timesToTick + 1)), 4);
        }

        [TestMethod]
        public void SecondPhase_Rotation_45_degrees_Test()
        {
            SecondPhaseRotationXIncrease phase = new SecondPhaseRotationXIncrease();

            int timesToTick = 500;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState);

            Assert.IsTrue(meshObject.Rotation.x >= 0);
        }

        [TestMethod]
        public void SecondPhase_Rotation_Minus_45_degrees_Test()
        {
            SecondPhaseRotationXDecrease phase = new SecondPhaseRotationXDecrease();

            int timesToTick = 500;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState);

            Assert.IsTrue(meshObject.Scale.x <= 1.0);
            Assert.IsTrue(meshObject.Scale.y <= 1.0);
            Assert.IsTrue(meshObject.Scale.z <= 1.0);
        }

    }
}