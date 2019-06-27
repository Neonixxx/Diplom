using System;
using System.Collections.Generic;
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

        public static List<int> GetSimpleMultipliers(int number)
        {
            var temp = number;
            var result = new List<int>();
            if (temp > 0)
                result.Add(1);
            else if (temp < 0)
            {
                result.Add(-1);
                temp *= -1;
            }
            else
                return result;

            while (temp != 1)
            {
                for (var i = 2; i <= temp; i++)
                {
                    if (temp % i == 0)
                    {
                        result.Add(i);
                        temp /= i;
                        break;
                    }
                }
            }

            return result;
        }
    }
}