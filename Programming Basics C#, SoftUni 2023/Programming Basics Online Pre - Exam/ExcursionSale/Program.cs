using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcursionSale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal seaPrice = 680;
            const decimal mountainPrice = 499;

            int seaCount = int.Parse(Console.ReadLine());
            int moutainCount = int.Parse(Console.ReadLine());

            decimal profit = 0;
            string input = "";

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Stop")
                    break;
                if (input == "sea" && seaCount != 0)
                {
                    profit += seaPrice;
                    seaCount--;
                }
                else if (input == "mountain" && moutainCount != 0)
                {
                    profit += mountainPrice;
                    moutainCount--;
                }

                if (seaCount == 0)
                    if (moutainCount == 0)
                      break;

                if (moutainCount == 0)
                    if (seaCount == 0)

                        break;
            }
            if (input != "Stop")
            {
                Console.WriteLine("Good job! Everything is sold.");
                Console.WriteLine($"Profit: {profit} leva.");
            }
            else
            {
                Console.WriteLine($"Profit: {profit} leva.");
            }
        }
    }
}
