using System;

namespace CubeAssignment.Gui.Animation.Phases
{
    /// <summary>
    /// Animation phase that increases the scale and meanwhile decreases the camera 'theta'.  
    /// </summary>
    public class FirstPhaseScaleIncrease : IState
    {
        public float StepSize { get; set; } = 0.01f;

        public virtual AnimationStates AnimationState => AnimationStates.Phase1ScaleIncrease;

        public void Enter()
        {
            Console.WriteLine("enter phase 1");
        }

        public void Leave()
        {
            Console.WriteLine("exit phase 1");
        }

        public virtual bool Tick(CubeAnimationData cubeAnimationData, float deltaTime)
        {
            PerformAction(cubeAnimationData, deltaTime);
            return cubeAnimationData.MeshSceneObject.Scale.x >= 1.5f;
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData, float deltaTime)
        {
            Vector newScale = cubeAnimationData.MeshSceneObject.Scale;
            newScale.x += StepSize;
            newScale.y += StepSize;
            newScale.z += StepSize;
            cubeAnimationData.MeshSceneObject.Scale = newScale;
            cubeAnimationData.Camera.Theta -= Utils.DeltaChange(deltaTime);
        }
    }
}