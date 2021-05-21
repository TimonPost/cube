using System;
using MatrixTransformations.Math;

namespace MatrixTransformations.Animation
{
    public class FirstPhase : IState
    {
        public float StepSize { get; set; } = 0.01f;

        public States State => States.Phase1;

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
            return cubeAnimationData.Scale.x >= 1.5f;
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData)
        {
            cubeAnimationData.Scale.x += StepSize;
            cubeAnimationData.Scale.y += StepSize;
            cubeAnimationData.Scale.z += StepSize;
        }
    }

    public class FirstPhaseInverse : FirstPhase
    {
        public FirstPhaseInverse()
        {
            StepSize = -StepSize;
        }

        public override bool Tick(CubeAnimationData cubeAnimationData)
        {
            PerformAction(cubeAnimationData);
            return cubeAnimationData.Scale.x <= 1.0f;
        }
    }
}