using System;

namespace CubeAssignment.Gui.Animation.Phases
{
    /// <summary>
    /// Animation phase that decreases the scale and meanwhile decreases the camera 'theta'.  
    /// </summary>
    public class FirstPhaseScaleDecrease : IState
    {
        public virtual AnimationStates AnimationState => AnimationStates.Phase1ScaleDecrease;

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
            return cubeAnimationData.MeshSceneObject.Scale.x <= 1.0f;
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData, float deltaTime)
        {
            Vector newScale = cubeAnimationData.MeshSceneObject.Scale;
            newScale.x -= Utils.DeltaChange(deltaTime);
            newScale.y -= Utils.DeltaChange(deltaTime);
            newScale.z -= Utils.DeltaChange(deltaTime);
            cubeAnimationData.MeshSceneObject.Scale = newScale;

           cubeAnimationData.Camera.Theta -= Utils.DeltaChange(deltaTime);
        }
    }
}