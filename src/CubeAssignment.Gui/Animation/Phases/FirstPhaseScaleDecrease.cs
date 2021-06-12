﻿using System;

namespace CubeAssignment.Gui.Animation
{
    /// <summary>
    /// Animation phase that decreases the scale and meanwhile decreases the camera 'theta'.  
    /// </summary>
    public class FirstPhaseScaleDecrease : IState
    {
        public float StepSize { get; set; } = 0.01f;

        public virtual States State => States.Phase1ScaleDecrease;

        public void Enter()
        {
            Console.WriteLine("enter phase 1");
        }

        public void Leave()
        {
            Console.WriteLine("exit phase 1");
        }

        public virtual bool Tick(CubeAnimationData cubeAnimationData)
        {
            PerformAction(cubeAnimationData);
            return cubeAnimationData.MeshSceneObject.Scale.x <= 1.0f;
        }

        protected void PerformAction(CubeAnimationData cubeAnimationData)
        {
            Vector newScale = cubeAnimationData.MeshSceneObject.Scale;
            newScale.x -= StepSize;
            newScale.y -= StepSize;
            newScale.z -= StepSize;
            cubeAnimationData.MeshSceneObject.Scale = newScale;
           cubeAnimationData.Camera.Theta -= Program.THETA_STEP_SIZE;
        }
    }
}