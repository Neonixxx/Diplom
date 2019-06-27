using System;
using Fractions;

namespace Core.StraightLineTaskGenerators
{
    // 14
    public class NormalFromPointTaskGenerator : StraightLineTaskGenerator
    {
        private Point _point = new Point();

        public NormalFromPointTaskGenerator()
        {
            TaskName = "Перпендикуляр к прямой через точку";
        }

        public override void Initialize(Random random)
        {
            base.Initialize(random);

            do
            {
                _point.X = new Fraction(random.Next(-10, 11));
                _point.Y = new Fraction(random.Next(-10, 11));
            } while (Line.IsPointOnLine(_point));
        }

        public override bool CheckResult(string answer)
        {
            var answers = answer.ToInts();

            if (answers.Length != 3)
                return false;

            var answerLine = new StraightLine(answers[0], answers[1], answers[2]);

            return Line.IsNormalTo(answerLine) && answerLine.IsPointOnLine(_point);
        }

        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Составить уравнение перпендикуляра Ax + By + C = 0, опущенного на эту прямую из точки M{_point}." +
                   $"{Environment.NewLine}Ответ введите в формате: \"A, B, C\".";
        }
    }
}