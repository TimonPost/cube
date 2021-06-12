using System;

namespace CubeAssignment.Gui.Animation
{
    public class ThirdPhase : IState
    {
        public float StepSize { get; set; } = (float) System.Math.PI / 60;

        public static double ToRadians(double val)
        {
            return System.Math.PI / 180 * val;
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
            return cubeAnimationData.MeshSceneObject.Rotation.y >= ToRadians(45);
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData)
        {
            cubeAnimationData.MeshSceneObject.Rotation.y += StepSize;
            cubeAnimationData.Camera.PHI += 0.00000001f;
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
            return cubeAnimationData.MeshSceneObject.Rotation.y <= ToRadians(0);
        }
    }
}