using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSupplies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int preparation = int.Parse(Console.ReadLine());
            int discountPercentage = int.Parse(Console.ReadLine());

            // 2. Calculate total prices
            double totalPrice = pens * 5.8 + markers * 7.2 + preparation * 1.2;

            // 3. Apply discount
            double totalPriceWithDiscount = totalPrice - (totalPrice * (discountPercentage * 0.01));

            // 4. Print output
            Console.WriteLine(totalPriceWithDiscount);
        }
    }
}
