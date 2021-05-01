using MatrixTransformations.Math;

namespace MatrixTransformations.Animation
{
    public class SecondPhase : IPhase
    {
        public float StepSize { get; set; } = (float)System.Math.PI / 60;
        
        public void Advance(Vector rotate, Vector scale, Vector translate)
        {
            rotate.x += StepSize;
        }

        public virtual bool Finished(Vector rotate, Vector scale, Vector translate)
        {
            return rotate.x >= ToRadians(45);
        }

        public static double ToRadians(double val)
        {
            return (System.Math.PI / 180) * val;
        }
    }

    public class SecondPhaseInverse : SecondPhase
    {
        public SecondPhaseInverse()
        {
            StepSize = -StepSize;
        }
        
        public override bool Finished(Vector rotate, Vector scale, Vector translate)
        {
            return rotate.x <= ToRadians(0);
        }
    }
}