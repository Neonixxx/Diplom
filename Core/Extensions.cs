using System;
using System.Collections.Generic;
using System.Linq;
using Fractions;

namespace Core
{
    public static class Extensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> enumerable)
        {
            var random = new Random();
            var source = enumerable.ToList();
            var result = new T[source.Count];

            for (var i = source.Count - 1; i >= 0; i--)
            {
                var itemIndex = random.Next(0, source.Count);
                result[i] = source[itemIndex];
                source.RemoveAt(itemIndex);
            }

            return result;
        }

        public static Fraction[] ToFractions(this string str)
            => str.Split(new string[] { ",", ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(Fraction.FromString)
                .ToArray();

        public static string ToStringWithPlus(this Fraction fraction)
            => fraction.IsPositive
                ? $"+{fraction.ToString()}"
                : fraction.ToStringWithZero();

        public static string ToStringWithZero(this Fraction fraction)
            => fraction.IsZero
                ? "0"
                : fraction.ToString();

        public static bool FlipCoin(this Random random)
            => random.Next() % 2 == 1;
    }
}