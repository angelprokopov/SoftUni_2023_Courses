using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0;
            int climbersCount = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum <= 5) { c1 += currentNum ; }
                else if (currentNum <= 12) { c2+= currentNum; }
                else if (currentNum <= 25) { c3 += currentNum; }
                else if (currentNum <= 40) { c4 += currentNum; }
                else { c5 += currentNum; }

                climbersCount += currentNum;
            }
            Console.WriteLine($"{100.0 * c1 / climbersCount:f2}%");
            Console.WriteLine($"{100.0 * c2 / climbersCount:f2}%");
            Console.WriteLine($"{100.0 * c3 / climbersCount:f2}%");
            Console.WriteLine($"{100.0 * c4 / climbersCount:f2}%");
            Console.WriteLine($"{100.0 * c5 / climbersCount:f2}%");
        }
    }
}
