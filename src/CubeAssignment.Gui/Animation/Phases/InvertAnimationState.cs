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
            if (cubeAnimationData.Camera.Theta < -100.000000)
            {
                cubeAnimationData.Camera.Theta += Program.THETA_STEP_SIZE;
            }

            if (cubeAnimationData.Camera.Phi > -10.0000000)
            {
                cubeAnimationData.Camera.Phi -= Program.PHI_STEP_SIZE;
            }

            return false;
        }
    }
}