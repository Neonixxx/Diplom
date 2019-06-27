using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.StraightLineTaskGenerators
{
    public class LinesIntersectionPointTaskGenerator : StraightLineTaskGenerator
    {
        private StraightLine _line = new StraightLine();

        public LinesIntersectionPointTaskGenerator()
        {
            TaskName = "Точка пересечения двух прямых.";
        }

        public override void Initialize(Random random)
        {
            base.Initialize(random);
            _line.Randomize(random);

            do
            {
                var part1 = Line.B * _line.A;
                part1--;
                if (part1 == 0)
                    continue;

                var multipliers = MathHelper.GetSimpleMultipliers(part1);
                multipliers.Add(1);
                var first = new List<int> {1};
                var second = new List<int> {1};

                while (multipliers.Any())
                {
                    var item = multipliers[0];
                    multipliers.RemoveAt(0);
                    if (random.FlipCoin())
                        first.Add(item);
                    else
                        second.Add(item);
                }

                Line.A = first.Aggregate((r, c) => r * c);
                _line.B = second.Aggregate((r, c) => r * c);


            } while (Line.IsParallelTo(_line));

            Line.Normalize();
            _line.Normalize();
        }

        public override bool CheckResult(string answer)
        {
            var answers = answer.ToFractions();

            if (answers.Length != 2)
                return false;

            var point = new Point(answers[0], answers[1]);

            return Line.IsPointOnLine(point) && _line.IsPointOnLine(point);
        }
        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Найти координаты точки пересечения данной прямой с прямой {_line}." +
                   $"{Environment.NewLine}Ответ введите в формате: \"x, y\".";
        }
    }
}