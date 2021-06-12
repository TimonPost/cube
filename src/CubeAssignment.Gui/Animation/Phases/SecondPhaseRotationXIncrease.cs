using System;

namespace CubeAssignment.Gui.Animation
{
    /// <summary>
    /// Animation phase that increases the rotation along the X and meanwhile increases the camera 'PHI'.  
    /// </summary>
    public class SecondPhaseRotationXIncrease : IState
    {
        public float StepSize { get; set; } = (float) System.Math.PI / 60;

        public virtual States State => States.Phase2RotationXIncrease;

        public void Enter()
        {
            Console.WriteLine("enter phase 2");
        }

        public void Leave()
        {
            Console.WriteLine("exit phase 2");
        }

        public virtual bool Tick(CubeAnimationData cubeAnimationData)
        {
            PerformAction(cubeAnimationData);
            return cubeAnimationData.MeshSceneObject.Rotation.x >= ToRadians(45);
        }

        public static double ToRadians(double val)
        {
            return System.Math.PI / 180 * val;
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData)
        {
            Vector newRotation = cubeAnimationData.MeshSceneObject.Rotation;
            newRotation.x += StepSize;
            cubeAnimationData.MeshSceneObject.Rotation = newRotation;
            cubeAnimationData.Camera.Phi -= Program.THETA_STEP_SIZE;
        }
    }
}