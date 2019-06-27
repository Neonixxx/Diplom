using System;

namespace Core.StraightLineTaskGenerators
{
    // 8
    public class ParallelVectorTaskGenerator : StraightLineTaskGenerator
    {
        public ParallelVectorTaskGenerator()
        {
            TaskName = "Направляющий вектор прямой";
        }

        public override bool CheckResult(string answer)
        {
            var answers = answer.ToInts();

            if (answers.Length != 2)
                return false;

            var vector = new Vector(answers[0], answers[1]);

            return Line.IsParallelTo(vector);
        }

        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Найти направляющий вектор M(x, y)." +
                   $"{Environment.NewLine}Ответ введите в формате: \"x, y\".";
        }
    }
}