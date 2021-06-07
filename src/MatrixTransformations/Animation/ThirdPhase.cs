using System;
using MatrixTransformations.Math;

namespace MatrixTransformations.Animation
{
    public class ThirdPhase : IState
    {
        public float StepSize { get; set; } = (float)System.Math.PI / 60;
        
        public static double ToRadians(double val)
        {
            return (System.Math.PI / 180) * val;
        }

        public virtual States State => States.Phase3;

        public void Enter()
        {
            Console.WriteLine("enter phase 3");
        }

        public void Leave()
        {
            Console.WriteLine("enter phase 3");
        }

        public virtual bool Tick(CubeAnimationData cubeAnimationData)
        {
            PerformAction(cubeAnimationData);
            return cubeAnimationData.Rotate.y >= ToRadians(45);
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData)
        {
            cubeAnimationData.Rotate.y += StepSize;
        }
    }

    public class ThirdPhaseInverse : ThirdPhase
    {
        public override States State => States.Phase3Inverse;

        public ThirdPhaseInverse()
        {
            StepSize = -StepSize;
        }

        public override bool Tick(CubeAnimationData cubeAnimationData)
        {
           PerformAction(cubeAnimationData);
            return cubeAnimationData.Rotate.y <= ToRadians(0);
        }
    }
}