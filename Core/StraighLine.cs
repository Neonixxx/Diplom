using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Fractions;

namespace Core
{
    public class StraightLine
    {
        public StraightLine(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;

            if (!IsRight())
                throw new ArgumentException();

            Normalize();
        }

        public StraightLine()
        {
        }

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public void Randomize(Random random)
        {
            do
            {
                A = random.Next(-10, 11);
                B = random.Next(-10, 11);
                C = random.Next(-1000, 1001);
            } while (!IsRight());

            Normalize();
        }

        public void Normalize()
        {
            var multiplier = 1;
            if (A < 0)
                multiplier *= -1;

            var gcd = MathHelper.GetGreatestCommonDevisor(A, B, C);
            multiplier *= Math.Abs(gcd);

            A /= multiplier;
            B /= multiplier;
            C /= multiplier;
        }

        public bool IsRight()
            => A != 0 && B != 0 && C != 0;

        public bool IsPointOnLine(Point point)
            => A * point.X + B * point.Y + C == 0;

        public bool IsParallelTo(StraightLine line)
            => A * line.B - B * line.A == 0;

        public bool IsParallelTo(Vector vector)
        {
            Normalize();
            vector.Normalize();

            return vector.X == B * -1 && vector.Y == A
                   || vector.X == B && vector.Y == A * -1;
        }

        public bool IsNormalTo(StraightLine line)
            => A * line.A + B * line.B == 0;

        public bool IsNormalTo(Vector vector)
        {
            Normalize();
            vector.Normalize();

            return vector.X == B && vector.Y == A * -1
                || vector.X == B * -1 && vector.Y == A;
        }

        public bool IsIntersect(Segment segment)
        {
            var y1 = ((A * segment.A.X + C) / B).Multiply(-1);
            var y2 = ((A * segment.B.X + C) / B).Multiply(-1);

            var list = new List<(int, bool)>
                {
                    (segment.A.Y.ToInt32(), true),
                    (segment.B.Y.ToInt32(), true),
                    (y1.ToInt32(), false),
                    (y2.ToInt32(), false)
                }.OrderBy(t => t.Item1)
                .ToList();

            if (list[0].Item2 && list[1].Item2 || list[2].Item2 && list[3].Item2)
                return false;

            return true;
        }

        public Fraction GetDistanceFromPoint(Point point)
            => (A * point.X + B * point.Y + C).Abs() / new Fraction(Math.Sqrt(A * A + B + B));

        public override string ToString()
        {
            Normalize();

            var lineStringBuilder = new StringBuilder();
            if (A != 0)
                lineStringBuilder.Append($"{A.ToString().EmptyIfOne()}x ");
            if (B != 0)
                lineStringBuilder.Append($"{B.ToStringWithPlus().EmptyIfOne()}y ");
            if (C != 0)
                lineStringBuilder.Append($"{C.ToStringWithPlus()} ");
            if (lineStringBuilder[0] == '+')
                lineStringBuilder.Remove(0, 1);
            lineStringBuilder.Remove(lineStringBuilder.Length - 1, 1);

            return lineStringBuilder.ToString();
        }
    }
}