using System;
using Fractions;

namespace Core.StraightLineTaskGenerators
{
    // 3
    public class NormalVectorTaskGenerator: StraightLineTaskGenerator
    {
        public NormalVectorTaskGenerator()
        {
            TaskName = "Нормальный вектор прямой";
        }

        public override bool CheckResult(string answer)
        {
            var answers = answer.ToFractions();

            if (answers.Length != 2)
                return false;

            return IsVectorNormalToLine(answers[0], answers[1]);
        }

        private bool IsVectorNormalToLine(Fraction x, Fraction y)
            => x == B && y == A.Multiply(-1)
               || x == B.Multiply(-1) && y == A;

        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Найти нормальный вектор N(x, y)." +
                   $"{Environment.NewLine}Ответ введите в формате: \"x, y\".";
        }
    }
}