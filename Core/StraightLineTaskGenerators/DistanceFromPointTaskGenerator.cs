using System;
using Fractions;

namespace Core.StraightLineTaskGenerators
{
    // 12
    public class DistanceFromPointTaskGenerator : StraightLineTaskGenerator
    {
        private readonly (int, int)[] _possiblePairs = {(3, 4), (5, 12), (6, 8), (8, 15), (9, 12), (12, 16)};

        private Point _point = new Point();

        public DistanceFromPointTaskGenerator()
        {
            TaskName = "Расстояние от точки до прямой";
        }

        public override void Initialize(Random random)
        {
            base.Initialize(random);

            var (x, y) = _possiblePairs[random.Next(0, _possiblePairs.Length)];
            if (random.FlipCoin())
            {
                var temp = x;
                x = y;
                y = temp;
            }
            if (random.FlipCoin())
                x *= -1;
            if (random.FlipCoin())
                y *= -1;

            Line.A = x;
            Line.B = y;
            Line.Normalize();

            do
            {
                _point.X = new Fraction(random.Next(-10, 11));
                _point.Y = new Fraction(random.Next(-10, 11));
            } while (Line.IsPointOnLine(_point));
        }

        public override bool CheckResult(string answer)
        {
            var answers = answer.ToFractions();

            if (answers.Length != 1)
                return false;

            return answers[0] == Line.GetDistanceFromPoint(_point);
        }

        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Найти расстояние от точки M{_point}" +
                   $"{Environment.NewLine}(Пример: 16/3).";
        }
    }
}