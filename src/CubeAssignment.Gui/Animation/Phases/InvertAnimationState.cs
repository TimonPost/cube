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
}