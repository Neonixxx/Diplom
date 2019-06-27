using Fractions;

namespace Core
{
    public class Point
    {
        public Point(Fraction x, Fraction y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {
        }

        public Fraction X { get; set; }
        public Fraction Y { get; set; }

        public override string ToString()
            => $"({X}, {Y})";
    }
}