using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());

            // 2. Calculate total price
            double orderPrice = chickenMenus * 10.35 + fishMenus * 12.4 + vegetarianMenus * 8.15;

            // 3. Calculate dessert price
            double dessertPrice = 0.2 * orderPrice;
            // 4. Print output
            double totalPrice = orderPrice + dessertPrice + 2.5;
            Console.WriteLine(totalPrice);
        }
    }
}
