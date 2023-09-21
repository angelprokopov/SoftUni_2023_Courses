using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum < 200) { c1++; }
                else if (currentNum < 400) { c2++; }
                else if (currentNum < 600) { c3++; }
                else if (currentNum < 800) { c4++; }
                else { c5++; }
            }
            Console.WriteLine($"{100.0 * c1 / n:f2}%");
            Console.WriteLine($"{100.0 * c2 / n:f2}%");
            Console.WriteLine($"{100.0 * c3 / n:f2}%");
            Console.WriteLine($"{100.0 * c4 / n:f2}%");
            Console.WriteLine($"{100.0 * c5 / n:f2}%");
        }
    }
}
