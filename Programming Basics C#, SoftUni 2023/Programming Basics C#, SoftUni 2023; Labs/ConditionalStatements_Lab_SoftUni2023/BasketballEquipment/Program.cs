using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int tax = int.Parse(Console.ReadLine());

            // 2. Calculate shoes price
            double shoesPrice = tax - 0.4 * tax;

            // 3. Calculate kit price
            double kitPrice = shoesPrice - 0.2 * shoesPrice;

            // 4. Calculate ball price
            double ballPrice = (1 / 4.0) * kitPrice;

            // 5. Calculate accessories price
            double accessoriesPrice = (1 / 5.0) * ballPrice;

            // 6. Calculate total price
            double totalPrice = tax + shoesPrice + kitPrice + ballPrice + accessoriesPrice;
            // 7. Print output
            Console.WriteLine(totalPrice);
        }
    }
}
