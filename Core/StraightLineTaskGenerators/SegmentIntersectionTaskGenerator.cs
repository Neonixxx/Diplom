using System;
using System.Collections.Generic;
using System.Linq;
using Fractions;

namespace Core.StraightLineTaskGenerators
{
    // 13
    public class SegmentIntersectionTaskGenerator : StraightLineTaskGenerator
    {
        private Fraction _ax;
        private Fraction _ay;
        private Fraction _bx;
        private Fraction _by;

        public SegmentIntersectionTaskGenerator()
        {
            TaskName = "Пересечение прямой с отрезком";
        }

        public override void Initialize(Random random)
        {
            base.Initialize(random);

            do
            {
                C = random.Next(-9, 10);
                _ax = new Fraction(random.Next(-10, 11));
                _ay = new Fraction(random.Next(-10, 11));
                _bx = new Fraction(random.Next(-10, 11));
                _by = new Fraction(random.Next(-10, 11));
            } while (IsPointOnLine((_ax), _ay) || IsPointOnLine(_bx, _by) || !IsLineRight(A, B, C));
        }

        public override bool CheckResult(string answer)
        {
            bool ans;
            switch (answer.Trim().ToLower())
            {
                case "да": ans = true; break;
                case "нет": ans = false; break;
                default: return false;
            }

            return ans == IsIntersected();
        }

        private bool IsIntersected()
        {
            var y1 = ((A * _ax + C) / B).Multiply(-1);
            var y2 = ((A * _bx + C) / B).Multiply(-1);

            var list = new List<(int, bool)>
            {
                (_ay.ToInt32(), true),
                (_by.ToInt32(), true),
                (y1.ToInt32(), false),
                (y2.ToInt32(), false)
            }.OrderBy(t => t.Item1)
                .ToList();

            if (list[0].Item2 && list[1].Item2 || list[2].Item2 && list[3].Item2)
                return false;

            return true;
        }

        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Пересекает ли эта прямая отрезок [AB], если " +
                   $"A{FormatPoint(_ax,_ay)}, B{FormatPoint(_bx, _by)} (Да, Нет)?";
        }
    }
}