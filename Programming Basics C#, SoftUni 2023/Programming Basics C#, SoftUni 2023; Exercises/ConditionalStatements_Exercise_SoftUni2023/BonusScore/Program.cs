using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int num = int.Parse(Console.ReadLine());
            // 2. Calculate first bonus
            double bonus;
            if (num <= 100)
            {
                bonus = 5;
            } 
            else if (num > 1000)
            {
                bonus = num * 0.1;
            }
            else 
            {
                bonus = num * 0.2;
            }

            // 3. 
            if(num % 2  == 0) 
            {
                bonus += 1;
            }
            else if(num % 10 == 5)
            {
                bonus += 2;
            }

            // 4. Print output
            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
        }
    }
}
