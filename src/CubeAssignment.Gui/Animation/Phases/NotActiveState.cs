using System;

namespace CubeAssignment.Gui.Animation.Phases
{
    /// <summary>
    /// Animation phase that does nothing. 
    /// </summary>
    public class NotActiveState : IState
    {
        public AnimationStates AnimationState => AnimationStates.NotActive;

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
            return false;
        }
    }
}