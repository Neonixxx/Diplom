using System;
using Fractions;

namespace Core.StraightLineTaskGenerators
{
    // 2
    public class TwoPointsOnLineTaskGenerator : StraightLineTaskGenerator
    {
        public TwoPointsOnLineTaskGenerator()
        {
            TaskName = "Точки на прямой";
        }

        public override void Initialize(Random random)
        {
            do
            {
                var x1 = new Fraction(random.Next(-10, 11));
                var y1 = new Fraction(random.Next(-10, 11));
                var x2 = new Fraction(random.Next(-10, 11));
                var y2 = new Fraction(random.Next(-10, 11));

                A = y1 - y2;
                B = x2 - x1;
                C = x1 * y2 - x2 * y1;
            } while (!IsLineRight(A, B, C));

            NormalizeLine();
        }

        public override bool CheckResult(string answer)
        {
            var answers = answer.ToFractions();

            if (answers.Length != 4)
                return false;

            return IsPointOnLine(answers[0], answers[1])
                && IsPointOnLine(answers[2], answers[3]);
        }

        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Найти две точки, лежащие на этой прямой." +
                   $"{Environment.NewLine}Ответ введите в формате: \"x1, y1, x2, y2\".";
        }
    }
}