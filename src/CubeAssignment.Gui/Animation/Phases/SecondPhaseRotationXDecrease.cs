using System;

namespace CubeAssignment.Gui.Animation.Phases
{
    /// <summary>
    /// Animation phase that decreases the rotation along the X down to 0 degrees and meanwhile decreases the camera 'THETA'.  
    /// </summary>
    public class SecondPhaseRotationXDecrease : IState
    {
        public virtual AnimationStates AnimationState => AnimationStates.Phase2RotationXDecrease;

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
            return cubeAnimationData.MeshSceneObject.Rotation.x <= ToRadians(0);
        }

        public static double ToRadians(double val)
        {
            return System.Math.PI / 180 * val;
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData, float deltaTime)
        {
            Vector newRotation = cubeAnimationData.MeshSceneObject.Rotation;
            newRotation.x -= Utils.DeltaChange(deltaTime);
            cubeAnimationData.MeshSceneObject.Rotation = newRotation;
            cubeAnimationData.Camera.Theta -= Utils.DeltaChange(deltaTime);
        }
    }
}