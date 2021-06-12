using System;

namespace CubeAssignment.Gui.Animation
{
    public class NotActiveState : IState
    {
        public States State => States.NotActive;

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
            return false;
        }
    }
}