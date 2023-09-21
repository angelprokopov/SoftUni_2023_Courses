using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());
            
            // 2. Calculate price for rent
            double costs = 0;
            if (season == "Spring") { costs = 3000;}
            else if (season == "Summer" || season == "Autumn") { costs = 4200; }
            else if (season == "Winter") { costs = 2600; }
            
            // 3. Calculate price atter discount
            if (fishermenCount <=6 ) { costs = 0.9 * costs; }
            else if (fishermenCount <=11 ) { costs = 0.85 * costs; }
            else { costs = 0.75 * costs; }
            
            // 4. Apply additional discount
            if( fishermenCount % 2 == 0 && season != "Autumn") { costs = 0.95 * costs; }

            // 5. Print output
            if (budget >= costs ) { Console.WriteLine($"Yes! You have {budget - costs:f2} leva left."); }
            else { Console.WriteLine($"Not enough money! You need {costs - budget:f2} leva."); }
        }
    }
}
