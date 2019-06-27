using System;
using System.Collections.Generic;
using System.Linq;
using Fractions;

namespace Core.StraightLineTaskGenerators
{
    // 13
    public class SegmentIntersectionTaskGenerator : StraightLineTaskGenerator
    {
        private Segment _segment = new Segment();

        public SegmentIntersectionTaskGenerator()
        {
            TaskName = "Пересечение прямой с отрезком";
        }

        public override void Initialize(Random random)
        {
            base.Initialize(random);

            do
            {
                Line.C = random.Next(-9, 10);
                _segment.A.X = new Fraction(random.Next(-10, 11));
                _segment.A.Y = new Fraction(random.Next(-10, 11));
                _segment.B.X = new Fraction(random.Next(-10, 11));
                _segment.B.Y = new Fraction(random.Next(-10, 11));
            } while (Line.IsPointOnLine(_segment.A) || Line.IsPointOnLine(_segment.B) || !Line.IsRight());
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

            return ans == Line.IsIntersect(_segment);
        }
        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Пересекает ли эта прямая отрезок [AB], если " +
                   $"A{_segment.A}, B{_segment.B} (Да, Нет)?";
        }
    }
}