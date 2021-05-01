using System.Collections.Generic;
using System.Linq;
using MatrixTransformations.Math;

namespace MatrixTransformations.Animation
{
    class Animation
    {
        private readonly List<IPhase> _originalPhases;

        private List<IPhase> _phases;
        public IPhase CurrentPhase;

        public Animation()
        {
            _originalPhases = new List<IPhase>() { new FirstPhase(), new SecondPhase(), new ThirdPhase(), new ThirdPhaseInverse(), new SecondPhaseInverse(), new FirstPhaseInverse() };
        }

        public bool Tick(Vector rotate, Vector scale, Vector translate)
        {
            if (CurrentPhase == null)
            {
                if (!SetNextPhase())
                    return false;
            }

            if (!CurrentPhase.Finished(rotate, scale, translate))
            {
                CurrentPhase.Advance(rotate, scale, translate);
            }
            else
            {
                if (!SetNextPhase())
                    return false;
            }

            return true;
        }

        private bool SetNextPhase()
        {
            var currentPhase = CurrentPhase;
            
            CurrentPhase = _phases.FirstOrDefault();
            if (CurrentPhase == null) return false;

            _phases.RemoveAt(0);

            return CurrentPhase != null;
        }

        public void Start()
        {
            _phases = _originalPhases.ToList();
            CurrentPhase = null;

            SetNextPhase();
        }

        public void Reset()
        {
            _phases = _originalPhases.ToList();
            CurrentPhase = null;
        }
        
        public bool HasPhase()
        {
            return _phases.Count != 0;
        }
    }
}