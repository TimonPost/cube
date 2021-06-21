using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using CubeAssignment.Gui;
using CubeAssignment.Gui.Animation;
using CubeAssignment.Gui.Animation.Phases;
using CubeAssignment.Gui.Scene;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils = CubeAssignment.Gui.Utils;

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

            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState, deltaTime);

            Assert.AreEqual(camera.Theta, Camera.DefaultTheta - (Utils.DeltaChange(deltaTime) * timesToTick), 0.01f);
        }


        [TestMethod]
        public void FirstPhaseTheta_Increase_Test()
        {
            FirstPhaseScaleIncrease phase = new FirstPhaseScaleIncrease();

            int timesToTick = 20;

            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
            {
                phase.Tick(animationState, deltaTime);
            }

            Assert.AreEqual(camera.Theta, Camera.DefaultTheta - (Utils.DeltaChange(deltaTime) * timesToTick), 0.01f);
        }
    }
}