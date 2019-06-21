using System;
using Fractions;

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
            var answers = answer.ToFractions();

            if (answers.Length != 2)
                return false;

            return IsVectorParallelToLine(answers[0], answers[1]);
        }

        private bool IsVectorParallelToLine(Fraction x, Fraction y)
            => x == B.Multiply(-1) && y == A
               || x == B && y == A.Multiply(-1);

        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Найти направляющий вектор M(x, y)." +
                   $"{Environment.NewLine}Ответ введите в формате: \"x, y\".";
        }
    }
}