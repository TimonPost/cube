namespace CubeAssignment.Gui.Animation
{
    /// <summary>
    ///     State for the shark finite state-machine.
    /// </summary>
    public interface IState
    {
        /// <summary>
        ///     State identifier.
        /// </summary>
        AnimationStates AnimationState { get; }

        /// <summary>
        ///     Enter the state.
        /// </summary>
        void Enter();

        /// <summary>
        ///     Leave the state.
        /// </summary>
        void Leave();

        /// <summary>
        ///     Checks if the state is finished.
        /// </summary>
        /// <returns>if the state is finished</returns>
        bool Tick(CubeAnimationData cubeAnimationData);
    }
}