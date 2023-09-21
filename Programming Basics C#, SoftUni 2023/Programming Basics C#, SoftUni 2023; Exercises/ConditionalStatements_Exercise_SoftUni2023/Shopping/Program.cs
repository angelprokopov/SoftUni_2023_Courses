using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read inout
            double budget = double.Parse(Console.ReadLine());
            int gpuCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());

            // 2. Calculate total costs
                // 2.1 Calculate GPU costs
            double gpuCosts = gpuCount * 250;
            double cpuCosts = cpuCount * (0.35 * gpuCosts);
            double ramPrice = 0.1 * gpuCosts;
            
            double ramCosts = ramCount * ramPrice;

            double totalCosts = gpuCosts + cpuCosts + ramCosts;
                // 2.2 15% discount if GPU counts > CPU counts
                if (gpuCount > cpuCount) 
                {
                    totalCosts = totalCosts - 0.15 * totalCosts;
                }
            // 3. Print output
            if (budget >= totalCosts)
            {
                Console.WriteLine($"You have {budget - totalCosts:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCosts - budget:f2} leva more!");
            }
        }
    }
}
