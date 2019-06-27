using System;

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
            base.Initialize(random);

            do
            {
                Line.C = Line.A * Line.B * random.Next(-9, 10);
            } while (!Line.IsRight());

            Line.Normalize();
        }

        public override bool CheckResult(string answer)
        {
            var answers = answer.ToFractions();

            if (answers.Length != 4)
                return false;

            return Line.IsPointOnLine(new Point(answers[0], answers[1]))
                && Line.IsPointOnLine(new Point(answers[2], answers[3]));
        }

        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Найти две точки, лежащие на этой прямой." +
                   $"{Environment.NewLine}Ответ введите в формате: \"x1, y1, x2, y2\".";
        }
    }
}