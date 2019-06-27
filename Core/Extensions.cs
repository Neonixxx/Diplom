using System;
using System.Collections.Generic;
using System.Globalization;
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
        {
            try
            {
                return str.Split(new[] {",", ", "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(Fraction.FromString)
                    .ToArray();
            }
            catch
            {
                return new Fraction[0];
            }
        }

        public static int[] ToInts(this string str)
        {
            try
            {
                return str.Split(new[] { ",", ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => Convert.ToInt32(s))
                    .ToArray();
            }
            catch
            {
                return new int[0];
            }
        }

        public static string ToStringWithPlus(this int number)
            => number > 0
                ? $"+{number}"
                : number.ToString();

        public static string EmptyIfOne(this string str)
        {
            switch (str)
            {
                case "1": return "";
                case "+1": return "+";
                case "-1": return "-";
                default: return str;
            }
        }

        public static bool FlipCoin(this Random random)
            => random.Next() % 2 == 1;

        public static string ToPercent(this double percent, int decimalDigits = 2)
        {
            var numberFormat = new CultureInfo("en-US").NumberFormat;
            numberFormat.PercentDecimalDigits = decimalDigits;
            return percent.ToString("P", numberFormat);
        }
    }
}