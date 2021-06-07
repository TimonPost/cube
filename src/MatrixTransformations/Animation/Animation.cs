using System;
using System.Collections.Generic;
using System.Linq;
using MatrixTransformations.MathCustom;
using MatrixTransformations.World;

namespace MatrixTransformations.Animation
{
    /// <summary>
    ///     Events to change the state-machine state.
    /// </summary>
    public enum Events
    {
        Start,
        Finished,
        Stop
    }

    public enum States
    {
        Phase1,
        Phase2,
        Phase3,
        Phase1Inverse,
        Phase2Inverse,
        Phase3Inverse,
        NotActive,
        InvertAnimation
    }

    public class CubeAnimationData
    {
        public MeshSceneObject MeshSceneObject { get; }
        public Camera Camera { get; }

        public CubeAnimationData(MeshSceneObject meshSceneObject, Camera camera)
        {
            MeshSceneObject = meshSceneObject;
            Camera = camera;
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
        void ProcessEvent(Events theEvent);
    }

    public class AnimationFiniteStateMachine : IAnimationFiniteStateMachine
    {
        private readonly Action[,] _fsm;

        private MeshSceneObject _meshSceneObject;
        private readonly Camera _camera;

        /// <summary>
        ///     The state that is currently active.
        /// </summary>
        private IState ActiveState { get; set; }

        public AnimationFiniteStateMachine(MeshSceneObject meshSceneObject, Camera camera)
        {
            _fsm = new Action[8, 3]
            {
                // Start, Finish, Stop
                {null, EnterPhaseTwo, EnterNotActive}, // PhaseOne
                {null, EnterPhaseThree, EnterNotActive}, // PhaseTwo
                {null, InverseAnimation, EnterNotActive}, // PhaseThree
                {null, EnterPhaseOne, EnterNotActive}, // PhaseOneInverse 
                {null, EnterPhaseOneInverse, EnterNotActive}, // PhaseTwoInverse
                {null, EnterPhaseTwoInverse, EnterNotActive}, // PhaseThreeInverse 
                {null, EnterNotActive, EnterNotActive}, // NotActive 
                {null, EnterPhaseOne, EnterNotActive}, // InverseAnimation 
            };

            _meshSceneObject = meshSceneObject;
            _camera = camera;

            EnterNotActive();
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

        private void InverseAnimation()
        {
            EnterState(new InvertAnimationState());
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
            // If some state is finished, try to advance.
            if (ActiveState?.Tick(new CubeAnimationData(_meshSceneObject, _camera)) ?? false) ProcessEvent(Events.Finished);
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