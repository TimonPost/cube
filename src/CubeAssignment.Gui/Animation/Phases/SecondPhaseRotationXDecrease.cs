using System;

namespace CubeAssignment.Gui.Animation
{
    public class SecondPhaseRotationXDecrease : IState
    {
        public float StepSize { get; set; } = (float) System.Math.PI / 60;

        public virtual States State => States.Phase2RotationXDecrease;

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
            return cubeAnimationData.MeshSceneObject.Rotation.x <= ToRadians(0);
        }

        public static double ToRadians(double val)
        {
            return System.Math.PI / 180 * val;
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData)
        {
            cubeAnimationData.MeshSceneObject.Rotation.x -= StepSize;
            cubeAnimationData.Camera.Phi -= Program.THETA_STEP_SIZE;
        }
    }
}