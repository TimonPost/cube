using System;
using System.CodeDom;
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
        public void FirstPhase_Theta_Decrease_Test_1()
        {
            FirstPhaseScaleIncrease phase = new FirstPhaseScaleIncrease();

            int timesToTick = 20;

            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
            {
                phase.Tick(animationState, deltaTime);
            }

            Assert.AreEqual(camera.Theta, Camera.DefaultTheta - (Utils.DeltaChange001(deltaTime) * timesToTick), 0.01f);
        }

        [TestMethod]
        public void FirstPhase_Theta_Decrease_Test_2()
        {
            FirstPhaseScaleDecrease phase = new FirstPhaseScaleDecrease();

            int timesToTick = 20;

            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
            {
                phase.Tick(animationState, deltaTime);
            }

            Assert.AreEqual(camera.Theta, Camera.DefaultTheta - (Utils.DeltaChange001(deltaTime) * timesToTick), 0.01f);
        }

        [TestMethod]
        public void FirstPhase_Scale_Decrease_Test()
        {
            FirstPhaseScaleDecrease phase = new FirstPhaseScaleDecrease();

            int timesToTick = 500;
            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState, deltaTime);

            Assert.IsTrue(meshObject.Scale.x <= 1.0);
            Assert.IsTrue(meshObject.Scale.y <= 1.0);
            Assert.IsTrue(meshObject.Scale.z <= 1.0);
        }


        [TestMethod]
        public void FirstPhase_Scale_Increase_Test()
        {
            FirstPhaseScaleIncrease phase = new FirstPhaseScaleIncrease();

            int timesToTick = 500;
            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState, deltaTime);

            Assert.IsTrue(meshObject.Scale.x >= 1.5);
            Assert.IsTrue(meshObject.Scale.y >= 1.5);
            Assert.IsTrue(meshObject.Scale.z >= 1.5);
        }

        [TestMethod]
        public void SecondPhase_Theta_Decrease_Test_1()
        {
            SecondPhaseRotationXDecrease phase = new SecondPhaseRotationXDecrease();

            int timesToTick = 20;

            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
            {
                phase.Tick(animationState, deltaTime);
            }

            Assert.AreEqual(camera.Theta, Camera.DefaultTheta - (Utils.DeltaChange001(deltaTime) * timesToTick), 0.01f);
        }

        [TestMethod]
        public void SecondPhase_Theta_Decrease_Test_2()
        {
            SecondPhaseRotationXIncrease phase = new SecondPhaseRotationXIncrease();

            int timesToTick = 20;

            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
            {
                phase.Tick(animationState, deltaTime);
            }

            Assert.AreEqual(camera.Theta, Camera.DefaultTheta - (Utils.DeltaChange001(deltaTime) * timesToTick), 0.01f);
        }

        [TestMethod]
        public void SecondPhase_Rotation_45_degrees_Test()
        {
            SecondPhaseRotationXIncrease phase = new SecondPhaseRotationXIncrease();

            int timesToTick = 500;
            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState, deltaTime);

            Assert.IsTrue(meshObject.Rotation.x >= (Utils.DeltaChange001(deltaTime) * timesToTick));
        }

        [TestMethod]
        public void SecondPhase_Rotation_Minus_45_degrees_Test()
        {
            SecondPhaseRotationXDecrease phase = new SecondPhaseRotationXDecrease();

            int timesToTick = 500;
            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState, deltaTime);

            Assert.AreEqual(meshObject.Rotation.x + (Utils.DeltaChange001(deltaTime) * timesToTick), 0, 0.01f);
        }

        [TestMethod]
        public void ThirdPhasePhase_PHI_Decrease_Test_1()
        {
            ThirdPhaseRotationYDecrease phase = new ThirdPhaseRotationYDecrease();

            int timesToTick = 20;

            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
            {
                phase.Tick(animationState, deltaTime);
            }

            Assert.AreEqual(camera.Phi, Camera.DefaultPhi +  (Utils.DeltaChange001(deltaTime) * timesToTick), 0.00001f);
        }

        [TestMethod]
        public void ThirdPhasePhase_PHI_Decrease_Test_2()
        {
            ThirdPhaseRotationYIncrease phase = new ThirdPhaseRotationYIncrease();

            int timesToTick = 20;

            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
            {
                phase.Tick(animationState, deltaTime);
            }

            Assert.AreEqual(camera.Phi, Camera.DefaultPhi + (Utils.DeltaChange001(deltaTime) * timesToTick), 0.00001f);
        }

        [TestMethod]
        public void ThirdPhase_Rotation_Y_45_degrees_Test()
        {
            ThirdPhaseRotationYIncrease phase = new ThirdPhaseRotationYIncrease();

            int timesToTick = 500;
            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState, deltaTime);

            Assert.IsTrue(meshObject.Rotation.y >= (Utils.DeltaChange001(deltaTime) * timesToTick));
        }

        [TestMethod]
        public void ThirdPhase_Rotation_Y_Minus_45_degrees_Test()
        {
            ThirdPhaseRotationYDecrease phase = new ThirdPhaseRotationYDecrease();

            int timesToTick = 500;
            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
                phase.Tick(animationState, deltaTime);

            Assert.AreEqual(meshObject.Rotation.y + (Utils.DeltaChange001(deltaTime) * timesToTick), 0, 0.01f);
        }

        [TestMethod]
        public void InvertPhase_Inverts_PHI_THETA_TEST()
        {
            var phase1 = new FirstPhaseScaleIncrease();
            var phase2 = new SecondPhaseRotationXIncrease();
            var phase3 = new ThirdPhaseRotationYIncrease();
            
            InvertAnimationState phase4 = new InvertAnimationState();

            int timesToTick = 500;
            float deltaTime = 1f / 60f;

            for (int i = 0; i < timesToTick; i++)
            {
                phase1.Tick(animationState, deltaTime);
                phase2.Tick(animationState, deltaTime);
                phase3.Tick(animationState, deltaTime);
            }

            int count = 0;
            while (!phase4.Tick(animationState, deltaTime))
            {
                count++;
            }

            Assert.AreEqual(camera.Phi, Camera.DefaultPhi);
            Assert.AreEqual(camera.Theta, Camera.DefaultTheta);
        }

        [TestMethod]
        public void AnimationStateMachine_State_Order()
        {
            AnimationFiniteStateMachine afsm = new AnimationFiniteStateMachine(meshObject, camera);

            afsm.Start();

            Assert.AreSame(afsm.ActiveState.GetType(), typeof(FirstPhaseScaleIncrease));

            afsm.ProcessEvent(Events.Finished);
            Assert.AreSame(afsm.ActiveState.GetType(), typeof(FirstPhaseScaleDecrease));

            afsm.ProcessEvent(Events.Finished);
            Assert.AreSame(afsm.ActiveState.GetType(), typeof(SecondPhaseRotationXIncrease));

            afsm.ProcessEvent(Events.Finished);
            Assert.AreSame(afsm.ActiveState.GetType(), typeof(SecondPhaseRotationXDecrease));

            afsm.ProcessEvent(Events.Finished);
            Assert.AreSame(afsm.ActiveState.GetType(), typeof(ThirdPhaseRotationYIncrease));

            afsm.ProcessEvent(Events.Finished);
            Assert.AreSame(afsm.ActiveState.GetType(), typeof(ThirdPhaseRotationYDecrease));

            afsm.ProcessEvent(Events.Finished);
            Assert.AreSame(afsm.ActiveState.GetType(), typeof(InvertAnimationState));
        }
    }
}