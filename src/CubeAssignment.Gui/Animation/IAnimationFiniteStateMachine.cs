namespace CubeAssignment.Gui.Animation
{
    public interface IAnimationFiniteStateMachine
    {
        void Tick();
        void Start();
        void ProcessEvent(Events theEvent);
    }
}