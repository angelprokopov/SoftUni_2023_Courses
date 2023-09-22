using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int courses = n / m;    
            int remaining = n % m;

            if (remaining == 0) { Console.WriteLine(courses); }
            else if (remaining != 0) { Console.WriteLine(courses + remaining / remaining); }
        }
    }
}
