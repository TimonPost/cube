using System;
using System.Collections.Generic;
using System.Linq;
using MatrixTransformations.Math;

namespace MatrixTransformations.Animation
{
    /// <summary>
    ///     Events to change the state-machine state.
    /// </summary>
    public enum Events
    {
        Start,
        Finished
    }

    public enum States
    {
        Phase1,
        Phase2,
        Phase3
    }

    public class CubeAnimationData
    {
        public Vector Rotate { get; }
        public Vector Scale { get; }
        public Vector Translate { get; }

        public CubeAnimationData(Vector rotate, Vector scale, Vector translate)
        {
            Rotate = rotate;
            Scale = scale;
            Translate = translate;
        }
    }

    /// <summary>
    ///     State for the shark finite state-machine.
    /// </summary>
    public interface IState
    {
        /// <summary>
        ///     State identifier.
        /// </summary>
        States State { get; }

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

    class AnimationFiniteStateMachine
    {
        private readonly Action[,] _fsm;

        /// <summary>
        ///     The state that is currently active.
        /// </summary>
        private IState ActiveState { get; set; }

        public AnimationFiniteStateMachine()
        {
            _fsm = new Action[3,2]
            {
                // Start, Finish 
                {null,  EnterPhaseTwo},   // PhaseOne
                {null,  EnterPhaseThree}, // PhaseTwo,
                {null,  EnterPhaseOne}  // PhaseThree,   
            };
        }

        private void EnterPhaseOne()
        {
            EnterState(new FirstPhase());
        }

        private void EnterPhaseTwo()
        {
            EnterState(new SecondPhase());
        }

        private void EnterPhaseThree()
        {
            EnterState(new ThirdPhase());
        }

        /// <summary>
        ///     Starts the finite state-machine.
        ///     This will make the shark look for a vetex to go to.
        /// </summary>
        public void Start()
        {
            EnterPhaseOne();
        }

        /// <summary>
        ///     Update logic for the state-machine.
        /// </summary>
        public void Tick(CubeAnimationData cubeAnimationData)
        {
            // If no state is set, start the state machine.
            if (ActiveState == null) Start();

            // If some state is finished, try to advance.
            if (ActiveState.Tick(cubeAnimationData)) ProcessEvent(Events.Finished);
        }

        /// <summary>
        ///     Process the event which will trigger internal state changes.
        ///     Nothing will happen if event is not supported for the given state
        /// </summary>
        /// <param name="theEvent"></param>
        public void ProcessEvent(Events theEvent)
        {
            var enterNextState = _fsm[(int)ActiveState.State, (int)theEvent];
            enterNextState?.Invoke();
        }

        private void EnterState(IState state)
        {
            ActiveState?.Leave();
            ActiveState = state;
            ActiveState.Enter();
        }
    }
}