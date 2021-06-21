using System;

namespace CubeAssignment.Gui.Animation.Phases
{
    /// <summary>
    /// Animation phase that increases the rotation along the X up to 45 degrees and meanwhile decreases the camera 'THETA'.  
    /// </summary>
    public class SecondPhaseRotationXIncrease : IState
    {
        public virtual AnimationStates AnimationState => AnimationStates.Phase2RotationXIncrease;

        public void Enter()
        {
            Console.WriteLine("enter phase 2");
        }

        public void Leave()
        {
            Console.WriteLine("exit phase 2");
        }

        public virtual bool Tick(CubeAnimationData cubeAnimationData, float deltaTime)
        {
            PerformAction(cubeAnimationData, deltaTime);
            return cubeAnimationData.MeshSceneObject.Rotation.x >= ToRadians(45);
        }

        public static double ToRadians(double val)
        {
            return System.Math.PI / 180 * val;
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData, float deltaTime)
        {
            Vector newRotation = cubeAnimationData.MeshSceneObject.Rotation;
            newRotation.x += Utils.DeltaChange001(deltaTime);
            cubeAnimationData.MeshSceneObject.Rotation = newRotation;
            cubeAnimationData.Camera.Theta -= Utils.DeltaChangeStepSize1(deltaTime);
        }
    }
}