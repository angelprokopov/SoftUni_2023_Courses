using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            // 2. Calculate profit
            double profit = puzzles * 2.6 + dolls * 3 + bears * 4.1 + minions * 8.2 + trucks * 2;
                // 2.1 Apply discount if necessary
                int totalToys = puzzles + dolls + bears + minions + trucks;
                if(totalToys >= 50) 
                {
                    profit = profit - 0.25 * profit;
                }
                // 2.2 Pay rent
                profit = profit - 0.1 * profit;
            // 3. Print output
            if (profit >= tripPrice)
            {
                Console.WriteLine($"Yes! {profit - tripPrice:f2} lv left.");
            } else 
            {
                Console.WriteLine($"Not enough money! {tripPrice - profit:f2} lv needed.");
            }
        }
    }
}
