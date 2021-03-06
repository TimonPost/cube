using System;

namespace CubeAssignment.Gui.Animation.Phases
{
    /// <summary>
    ///     Animation phase that increases the rotation along the Y up to 45 degrees and meanwhile increases the camera 'PHI'.
    /// </summary>
    public class ThirdPhaseRotationYIncrease : IState
    {
        public virtual AnimationStates AnimationState => AnimationStates.Phase3RotationYIncrease;

        public void Enter()
        {
            Console.WriteLine("enter phase 3");
        }

        public void Leave()
        {
            Console.WriteLine("enter phase 3");
        }

        public virtual bool Tick(CubeAnimationData cubeAnimationData, float deltaTime)
        {
            PerformAction(cubeAnimationData, deltaTime);
            return cubeAnimationData.MeshSceneObject.Rotation.y >= ToRadians(45);
        }

        public static double ToRadians(double val)
        {
            return Math.PI / 180 * val;
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData, float deltaTime)
        {
            var newRotation = cubeAnimationData.MeshSceneObject.Rotation;
            newRotation.y += Utils.DeltaChange001(deltaTime);
            cubeAnimationData.MeshSceneObject.Rotation = newRotation;
            cubeAnimationData.Camera.Phi += Utils.DeltaChangeStepSize1(deltaTime);
        }
    }
}