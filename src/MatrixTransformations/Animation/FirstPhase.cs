using MatrixTransformations.Math;

namespace MatrixTransformations.Animation
{
    public class FirstPhase : IPhase
    {
        public float StepSize { get; set; } = 0.01f;
        
        public void Advance(Vector rotate, Vector scale, Vector translate)
        {
            scale.x += StepSize;
            scale.y += StepSize;
            scale.z += StepSize;
        }

        public virtual bool Finished(Vector rotate, Vector scale, Vector translate)
        {
            return scale.x >= 1.5f;
        }
    }

    public class FirstPhaseInverse : FirstPhase
    {
        public FirstPhaseInverse()
        {
            StepSize = -StepSize;
        }

        public override bool Finished(Vector rotate, Vector scale, Vector translate)
        {
            return scale.x <= 1.0f;
        }
    }
}