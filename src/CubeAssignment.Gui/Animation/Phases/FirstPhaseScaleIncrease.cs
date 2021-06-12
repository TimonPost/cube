using System;

namespace CubeAssignment.Gui.Animation
{
    public class FirstPhaseScaleIncrease : IState
    {
        public float StepSize { get; set; } = 0.01f;

        public virtual States State => States.Phase1ScaleIncrease;

        public void Enter()
        {
            Console.WriteLine("enter phase 1");
        }

        public void Leave()
        {
            Console.WriteLine("exit phase 1");
        }

        public virtual bool Tick(CubeAnimationData cubeAnimationData)
        {
            PerformAction(cubeAnimationData);
            return cubeAnimationData.MeshSceneObject.Scale.x >= 1.5f;
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData)
        {
            cubeAnimationData.MeshSceneObject.Scale.x += StepSize;
            cubeAnimationData.MeshSceneObject.Scale.y += StepSize;
            cubeAnimationData.MeshSceneObject.Scale.z += StepSize;

            cubeAnimationData.Camera.THETA -= Program.THETA_STEP_SIZE;
        }
    }
}