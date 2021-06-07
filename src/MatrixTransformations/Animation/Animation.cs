using System;
using System.Collections.Generic;
using System.Linq;
using MatrixTransformations.Math;
using MatrixTransformations.World;

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
        Phase3,
        Phase1Inverse,
        Phase2Inverse,
        Phase3Inverse,
        NotActive
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

   public interface IAnimationFiniteStateMachine
    {
        void Tick();
        void Start();

    }
    public class AnimationFiniteStateMachine : IAnimationFiniteStateMachine
    {
        private readonly Action[,] _fsm;

        private MeshSceneObject _meshSceneObject;

        /// <summary>
        ///     The state that is currently active.
        /// </summary>
        private IState ActiveState { get; set; }

        public AnimationFiniteStateMachine(MeshSceneObject meshSceneObject)
        {
            _fsm = new Action[7, 2]
            {
                // Start, Finish 
                {null, EnterPhaseTwo}, // PhaseOne
                {null, EnterPhaseThree}, // PhaseTwo
                {null, EnterPhaseThreeInverse}, // PhaseThree
                {null, EnterNotActive}, // PhaseOneInverse 
                {null, EnterPhaseOneInverse}, // PhaseTwoInverse
                {null, EnterPhaseTwoInverse}, // PhaseThreeInverse 
                {null, EnterNotActive}, // NotActive 
            };

            _meshSceneObject = meshSceneObject;
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

        private void EnterPhaseOneInverse()
        {
            EnterState(new FirstPhaseInverse());
        }

        private void EnterPhaseTwoInverse()
        {
            EnterState(new SecondPhaseInverse());
        }

        private void EnterPhaseThreeInverse()
        {
            EnterState(new ThirdPhaseInverse());
        }

        private void EnterNotActive()
        {
            EnterState(new NotActiveState());
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
        public void Tick()
        {
            // If no state is set, start the state machine.
            if (ActiveState == null) Start();

            // If some state is finished, try to advance.
            if (ActiveState.Tick(new CubeAnimationData(_meshSceneObject.Rotation, _meshSceneObject.Scale, _meshSceneObject.Position))) ProcessEvent(Events.Finished);
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