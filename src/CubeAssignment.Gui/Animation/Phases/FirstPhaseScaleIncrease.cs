using System;

namespace CubeAssignment.Gui.Animation.Phases
{
    /// <summary>
    /// Animation phase that increases the scale and meanwhile decreases the camera 'theta'.  
    /// </summary>
    public class FirstPhaseScaleIncrease : IState
    {
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
            newScale.x += Utils.DeltaChange001(deltaTime);
            newScale.y += Utils.DeltaChange001(deltaTime);
            newScale.z += Utils.DeltaChange001(deltaTime);
            cubeAnimationData.MeshSceneObject.Scale = newScale;

            cubeAnimationData.Camera.Theta -= Utils.DeltaChangeStepSize1(deltaTime);
        }
    }
}