namespace CubeAssignment.Gui.Animation
{
    public interface IPhase
    {
        void Advance(Vector rotate, Vector scale, Vector translate);
        bool Finished(Vector rotate, Vector scale, Vector translate);
    }
}