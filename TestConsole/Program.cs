using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Core.StraightLineTaskGenerators;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuples = new List<(int, int, int)>();
            for (int m = -5; m < 6; m++)
            {
                for (int n = -5; n < 6; n++)
                {
                    if (Math.Abs(m) == Math.Abs(n) || m == 0 || n == 0)
                        continue;

                    var x = m * m - n * n;
                    var y = 2 * m * n;
                    var z = m * m + n * n;

                    var gcd = MathHelper.GetGreatestCommonDevisor(x, y, z);
                    x /= gcd;
                    y /= gcd;
                    z /= gcd;

                    if (!tuples.Any(t => t.Item1 == x && t.Item2 == y && t.Item3 == z))
                        tuples.Add((x, y, z));
                }
            }

            foreach (var tuple in tuples.OrderBy(t => t.Item1).ThenBy(t => t.Item2).ThenBy(t => t.Item3))
            {
                Console.WriteLine($"{tuple.Item1}, {tuple.Item2}, {tuple.Item3}");
            }

            Console.ReadKey();
        }
    }
}
