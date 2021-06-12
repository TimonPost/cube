using System;

namespace CubeAssignment.Gui.Animation
{
    public class InvertAnimationState : IState
    {
        public States State => States.InvertAnimation;

        public void Enter()
        {
            Console.WriteLine("enter phase not active");
        }

        public void Leave()
        {
            Console.WriteLine("exit phase 1 not active");
        }

        public virtual bool Tick(CubeAnimationData cubeAnimationData)
        {
            if (cubeAnimationData.Camera.THETA < -100)
            {
                cubeAnimationData.Camera.THETA += 0.030f;
            }

            if (cubeAnimationData.Camera.PHI > -10)
            {
                cubeAnimationData.Camera.PHI -= 0.00000001f;
            }

            return false;
        }
    }


    public class NotActiveState : IState
    {
        public States State => States.NotActive;

        public void Enter()
        {
            Console.WriteLine("enter phase not active");
        }

        public void Leave()
        {
            Console.WriteLine("exit phase 1 not active");
        }

        public virtual bool Tick(CubeAnimationData cubeAnimationData)
        {
            return false;
        }
    }

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

            //cubeAnimationData.Camera.THETA -= Program.THETA_STEP_SIZE;
        }
    }
}