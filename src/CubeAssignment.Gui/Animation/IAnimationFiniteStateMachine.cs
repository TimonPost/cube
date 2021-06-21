namespace CubeAssignment.Gui.Animation
{
    /// <summary>
    ///     Interface for an animation state-machine.
    /// </summary>
    public interface IAnimationFiniteStateMachine
    {
        /// <summary>
        ///     Make the current animation state run.
        /// </summary>
        void Tick(float deltaTime);

        /// <summary>
        ///     Starts the state-machine.
        /// </summary>
        void Start();

        /// <summary>
        ///     Fires an event to trigger the state-machine such that it can switch to an other state.
        /// </summary>
        /// <param name="theEvent"></param>
        void ProcessEvent(Events theEvent);
    }
}