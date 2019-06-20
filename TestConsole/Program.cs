using System;
using System.Text;
using Core.StraightLineTaskGenerators;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = i + 1; j < 20; j++)
                {
                    Console.WriteLine($"({i}; {j}) = {Math.Sqrt(i * i + j * j)}");
                }
            }

            Console.ReadKey();
        }
    }
}
