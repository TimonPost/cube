using System;
using CubeAssignment.Gui.Animation.Phases;
using CubeAssignment.Gui.Scene;

namespace CubeAssignment.Gui.Animation
{
    /// <summary>
    ///     An animation state-machine animates a given Mesh Object.
    /// </summary>
    public class AnimationFiniteStateMachine : IAnimationFiniteStateMachine
    {
        private readonly Camera _camera;
        private readonly Action[,] _fsm;
        private readonly MeshSceneObject _meshSceneObject;

        public AnimationFiniteStateMachine(MeshSceneObject meshSceneObject, Camera camera)
        {
            _fsm = new Action[8, 3]
            {
                // Start, Finish, Stop
                {null, EnterFirstPhaseScaleDecrease, EnterNotActive}, // FirstPhaseScaleIncrease
                {null, EnterSecondPhaseRotationXIncrease, EnterNotActive}, // FirstPhaseScaleDecrease

                {null, EnterSecondPhaseRotationXDecrease, EnterNotActive}, // EnterSecondPhaseRotationXIncrease
                {null, EnterThirdPhaseRotationYIncrease, EnterNotActive}, // EnterSecondPhaseRotationXDecrease

                {null, EnterThirdPhaseRotationYDecrease, EnterNotActive}, // EnterThirdPhaseRotationYIncrease
                {null, InverseAnimation, EnterNotActive}, // EnterThirdPhaseRotationYDecrease

                {null, EnterNotActive, EnterNotActive}, // NotActive 
                {null, EnterFirstPhaseScaleIncrease, EnterNotActive} // InverseAnimation 
            };

            _meshSceneObject = meshSceneObject;
            _camera = camera;

            EnterNotActive();
        }

        /// <summary>
        ///     The state that is currently active.
        /// </summary>
        public IState ActiveState { get; private set; }

        /// <summary>
        ///     Starts the finite state-machine.
        ///     This will make the shark look for a vetex to go to.
        /// </summary>
        public void Start()
        {
            EnterFirstPhaseScaleIncrease();
        }

        /// <summary>
        ///     Update logic for the state-machine.
        /// </summary>
        public void Tick(float deltaTime)
        {
            // If some state is finished, try to advance.
            if (ActiveState?.Tick(new CubeAnimationData(_meshSceneObject, _camera), deltaTime) ?? false)
                ProcessEvent(Events.Finished);
        }

        /// <summary>
        ///     Process the event which will trigger internal state changes.
        ///     Nothing will happen if event is not supported for the given state
        /// </summary>
        /// <param name="theEvent"></param>
        public void ProcessEvent(Events theEvent)
        {
            var enterNextState = _fsm[(int) ActiveState.AnimationState, (int) theEvent];
            enterNextState?.Invoke();
        }


        private void EnterFirstPhaseScaleIncrease()
        {
            EnterState(new FirstPhaseScaleIncrease());
        }

        private void EnterFirstPhaseScaleDecrease()
        {
            EnterState(new FirstPhaseScaleDecrease());
        }

        private void EnterSecondPhaseRotationXIncrease()
        {
            EnterState(new SecondPhaseRotationXIncrease());
        }

        private void EnterSecondPhaseRotationXDecrease()
        {
            EnterState(new SecondPhaseRotationXDecrease());
        }

        private void EnterThirdPhaseRotationYIncrease()
        {
            EnterState(new ThirdPhaseRotationYIncrease());
        }

        private void EnterThirdPhaseRotationYDecrease()
        {
            EnterState(new ThirdPhaseRotationYDecrease());
        }

        private void EnterNotActive()
        {
            EnterState(new NotActiveState());
        }

        private void InverseAnimation()
        {
            EnterState(new InvertAnimationState());
        }

        private void EnterState(IState state)
        {
            ActiveState?.Leave();
            ActiveState = state;
            ActiveState.Enter();
        }
    }
}