using System;
using MatrixTransformations.MathCustom;

namespace MatrixTransformations.Animation
{
    public class SecondPhase : IState
    {
        public float StepSize { get; set; } = (float)System.Math.PI / 60;

        public virtual  States State => States.Phase2;

        public void Enter()
        {
            Console.WriteLine("enter phase 2");
        }

        public void Leave()
        {
            Console.WriteLine("exit phase 2");
        }

        public virtual bool Tick(CubeAnimationData cubeAnimationData)
        {
            PerformAction(cubeAnimationData);
            return cubeAnimationData.Rotate.x >= ToRadians(45);
        }
        
        public static double ToRadians(double val)
        {
            return (System.Math.PI / 180) * val;
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData)
        {
            cubeAnimationData.Rotate.x += StepSize;
        }
    }

    public class SecondPhaseInverse : SecondPhase
    {
        public override States State => States.Phase2Inverse;

        public SecondPhaseInverse()
        {
            StepSize = -StepSize;
        }
        public override bool Tick(CubeAnimationData cubeAnimationData)
        {
            PerformAction(cubeAnimationData);
            return cubeAnimationData.Rotate.x <= ToRadians(0);
        }
    }
}