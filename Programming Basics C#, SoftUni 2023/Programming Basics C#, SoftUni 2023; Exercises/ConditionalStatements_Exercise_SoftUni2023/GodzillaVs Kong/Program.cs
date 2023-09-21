using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodzillaVs_Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            double budget = double.Parse(Console.ReadLine());
            int numOfStats = int.Parse(Console.ReadLine());
            double clothingPricePerStat = double.Parse(Console.ReadLine());
            // 2. Calculate costs 
            double decorCost = 0.1 * budget;
            double clothingCost = numOfStats * clothingPricePerStat;
            if (numOfStats > 150)
            {
                clothingCost = 0.9 * clothingCost;
            }
            double totalCosts = decorCost + clothingCost;
            // 3. Print output
            if (budget >= totalCosts)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalCosts:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalCosts - budget:f2} leva more.");
            }
        }
    }
}
