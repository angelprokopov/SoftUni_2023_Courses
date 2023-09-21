using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements_Exercise_SoftUni2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            // 2. Sum seconds
            int sumTime = firstTime + secondTime + thirdTime;
            // 3. Extract min and sec
            int min = sumTime / 60;
            int sec = sumTime % 60;
            // 4. Print output
            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else 
            {
                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}
