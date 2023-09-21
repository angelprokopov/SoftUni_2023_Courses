using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double km = double.Parse(Console.ReadLine());
            double day1 = +km;
            double total = +km;

            for (int i = 1; i <= days; i++) 
            {
                double percentage = double.Parse(Console.ReadLine());
                percentage = percentage / 100;
                day1 += day1 * percentage;
                total += day1;

                if (total < 1000 && days == i)
                {
                    total = 1000 - total;
                    Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(total)} more kilometers");
                }
                else if (total > 1000 && days == i)
                {
                    total = total - 1000;
                    Console.WriteLine($"You've done a great job running {Math.Ceiling(total)} more kilometers!");
                }
            }
        }
    }
}
