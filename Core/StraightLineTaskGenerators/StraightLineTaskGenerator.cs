using System;
using System.Text;
using Fractions;

namespace Core.StraightLineTaskGenerators
{
    public abstract class StraightLineTaskGenerator
    {
        public string TaskName { get; protected set; }

        protected Fraction A;
        protected Fraction B;
        protected Fraction C;

        public virtual void Initialize(Random random)
        {
            do
            {
                A = new Fraction(random.Next(-10, 11));
                B = new Fraction(random.Next(-10, 11));
                C = new Fraction(random.Next(-1000, 1001));
            } while (!IsLineRight(A, B, C));

            NormalizeLine();
        }

        public abstract bool CheckResult(string answer);
        public virtual string GetString()
            => $"Прямая задана уравнением: {GetLineString(A, B, C)} = 0.";

        protected bool IsPointOnLine(Fraction x, Fraction y)
            => A.Multiply(x) + B.Multiply(y) + C == 0;

        protected bool IsLineRight(Fraction a, Fraction b, Fraction c)
            => !a.IsZero && !b.IsZero && !c.IsZero;

        protected string GetLineString(Fraction a, Fraction b, Fraction c)
        {
            var lineStringBuilder = new StringBuilder();
            if (!a.IsZero)
                lineStringBuilder.Append($"{a.ToStringWithZero().EmptyInOne()}x ");
            if (!b.IsZero)
                lineStringBuilder.Append($"{b.ToStringWithPlus().EmptyInOne()}y ");
            if (!c.IsZero)
                lineStringBuilder.Append($"{c.ToStringWithPlus()} ");
            if (lineStringBuilder[0] == '+')
                lineStringBuilder.Remove(0, 1);
            lineStringBuilder.Remove(lineStringBuilder.Length - 1, 1);

            return lineStringBuilder.ToString();
        }

        protected void NormalizeLine()
        {
            var multiplier = 1;
            if (A.IsNegative)
                multiplier *= -1;

            var greatestCommonDevisor = MathHelper.GetGreatestCommonDevisor(A.ToInt32(), B.ToInt32(), C.ToInt32());
            multiplier *= greatestCommonDevisor;

            A /= multiplier;
            B /= multiplier;
            C /= multiplier;
        }

        protected string FormatPoint(Fraction x, Fraction y)
            => $"({x.ToStringWithZero()}, {y.ToStringWithZero()})";
    }
}
