using System;
using CubeAssignment.Gui.Scene;

namespace CubeAssignment.Gui.Animation.Phases
{
    /// <summary>
    /// Animation phase that inverts the animation from other phases.  
    /// </summary>
    public class InvertAnimationState : IState
    {
        private bool ThetaReverted;
        private bool PHIReverted;

        public AnimationStates AnimationState => AnimationStates.InvertAnimation;

        public void Enter()
        {
            Console.WriteLine("enter phase not active");
        }

        public void Leave()
        {
            Console.WriteLine("exit phase 1 not active");
        }

        public virtual bool Tick(CubeAnimationData cubeAnimationData, float deltaTime)
        {
            if (cubeAnimationData.Camera.Theta < Camera.DefaultTheta)
            {
                cubeAnimationData.Camera.Theta += Utils.DeltaChange(deltaTime);
            }
            else
            {
                cubeAnimationData.Camera.Theta = Camera.DefaultTheta;
                ThetaReverted = true;
            }

            if (cubeAnimationData.Camera.Phi > Camera.DefaultPhi)
            {
                cubeAnimationData.Camera.Phi -= Utils.DeltaChange(deltaTime);
            }
            else
            {
                cubeAnimationData.Camera.Phi = Camera.DefaultPhi;
                PHIReverted = true;
            }

            return ThetaReverted && PHIReverted;
        }
    }
}