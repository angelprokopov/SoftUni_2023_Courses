using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            string flowerType = Console.ReadLine();
            int flowersCounts = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            // 2. Find price for a single flower
            double price = 0;
            if (flowerType == "Roses") { price = 5; }
            else if (flowerType == "Dahlias") { price = 3.8; }
            else if (flowerType == "Tulips") { price = 2.8; }
            else if (flowerType == "Narcissus") { price = 3; }
            else if (flowerType == "Gladiolus") { price = 2.5; }
            
            double totalCosts = price * flowersCounts;

            // 3. Calculate discount
            if (flowerType == "Roses" && flowersCounts > 80) { totalCosts = 0.9 * totalCosts; }
            else if ((flowerType == "Dahlias" && flowersCounts > 90) || (flowerType == "Tulips" && flowersCounts > 80) ) { totalCosts = 0.85 * totalCosts; }
            else if (flowerType == "Narcissus" && flowersCounts < 120) { totalCosts = 1.15 * totalCosts; }
            else if (flowerType == "Gladiolus" && flowersCounts < 80) { totalCosts = 1.2 * totalCosts; }

            // 4. Priint output
            if (budget >= totalCosts) { Console.WriteLine($"Hey, you have a great garden with {flowersCounts} {flowerType} and {budget - totalCosts:f2} leva left."); }
            else { Console.WriteLine($"Not enough money, you need {totalCosts - budget:f2} leva more."); }
        }
    }
}
