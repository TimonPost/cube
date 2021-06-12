using System;

namespace CubeAssignment.Gui.Animation
{
    public class ThirdPhaseRotationYIncrease : IState
    {
        public float StepSize { get; set; } = (float) System.Math.PI / 60;

        public static double ToRadians(double val)
        {
            return System.Math.PI / 180 * val;
        }

        public virtual States State => States.Phase3RotationYIncrease;

        public void Enter()
        {
            Console.WriteLine("enter phase 3");
        }

        public void Leave()
        {
            Console.WriteLine("enter phase 3");
        }

        public virtual bool Tick(CubeAnimationData cubeAnimationData)
        {
            PerformAction(cubeAnimationData);
            return cubeAnimationData.MeshSceneObject.Rotation.y >= ToRadians(45);
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData)
        {
            Vector newRotation = cubeAnimationData.MeshSceneObject.Rotation;
            newRotation.y += StepSize;
            cubeAnimationData.MeshSceneObject.Rotation = newRotation;
            cubeAnimationData.Camera.Phi += Program.PHI_STEP_SIZE;
        }
    }
}