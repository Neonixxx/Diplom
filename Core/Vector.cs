using Fractions;

namespace Core
{
    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;

            Normalize();
        }

        public void Normalize()
        {
            var gcd = MathHelper.GetGreatestCommonDevisor(X, Y);

            X /= gcd;
            Y /= gcd;
        }
    }
}