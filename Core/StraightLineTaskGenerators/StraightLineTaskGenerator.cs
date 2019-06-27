using System;

namespace Core.StraightLineTaskGenerators
{
    public abstract class StraightLineTaskGenerator
    {
        public string TaskName { get; protected set; }

        protected StraightLine Line = new StraightLine();

        public virtual void Initialize(Random random)
        {
            Line.Randomize(random);
        }

        public abstract bool CheckResult(string answer);

        public virtual string GetString()
            => $"Прямая задана уравнением: {Line} = 0.";
    }
}
