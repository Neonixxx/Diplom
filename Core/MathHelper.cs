using System;
using System.Linq;

namespace Core
{
    public static class MathHelper
    {
        public static int GetGreatestCommonDevisor(params int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException();

            if (numbers.Length == 1)
                return numbers[0];

            if (numbers.Length == 2)
                return GetGreatestCommonDevisor(numbers[0], numbers[1]);

            var numbersWithoutLastOne = numbers.Take(numbers.Length - 1).ToArray();
            return GetGreatestCommonDevisor(GetGreatestCommonDevisor(numbersWithoutLastOne), numbers[numbers.Length - 1]);
        }

        public static int GetGreatestCommonDevisor(int first, int second)
        {
            var a = first;
            var b = second;
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}