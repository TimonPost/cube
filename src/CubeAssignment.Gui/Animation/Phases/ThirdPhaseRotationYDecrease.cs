using System;

namespace CubeAssignment.Gui.Animation
{
    public class ThirdPhaseRotationYDecrease : IState
    {
        public float StepSize { get; set; } = (float)System.Math.PI / 60;

        public static double ToRadians(double val)
        {
            return System.Math.PI / 180 * val;
        }

        public virtual States State => States.Phase3RotationYDecrease;

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
            return cubeAnimationData.MeshSceneObject.Rotation.y <= ToRadians(0);
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData)
        {
            cubeAnimationData.MeshSceneObject.Rotation.y -= StepSize;
            cubeAnimationData.Camera.PHI += Program.PHI_STEP_SIZE;
        }
    }
}