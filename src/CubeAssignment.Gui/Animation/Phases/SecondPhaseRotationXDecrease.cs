﻿using System;

namespace CubeAssignment.Gui.Animation.Phases
{
    /// <summary>
    /// Animation phase that decreases the rotation along the X down to 0 degrees and meanwhile decreases the camera 'THETA'.  
    /// </summary>
    public class SecondPhaseRotationXDecrease : IState
    {
        public float StepSize { get; set; } = (float) System.Math.PI / 60;

        public virtual AnimationStates AnimationState => AnimationStates.Phase2RotationXDecrease;

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
            return cubeAnimationData.MeshSceneObject.Rotation.x <= ToRadians(0);
        }

        public static double ToRadians(double val)
        {
            return System.Math.PI / 180 * val;
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData)
        {
            Vector newRotation = cubeAnimationData.MeshSceneObject.Rotation;
            newRotation.x -= StepSize;
            cubeAnimationData.MeshSceneObject.Rotation = newRotation;
            cubeAnimationData.Camera.Theta -= Settings.THETA_STEP_SIZE;
        }
    }
}