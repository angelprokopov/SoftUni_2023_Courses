using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool shouldStop = false;

            for (int i = 1; i <= n && !shouldStop; i++)
            {
                for (int j = 1; j <= i && !shouldStop; j++)
                {
                    Console.WriteLine($"{current}");
                    current++;
                    if (current > n) { shouldStop = true; }
                }
                Console.WriteLine();
            }
        }
    }
}
