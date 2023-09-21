using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packagePaperPrice = 5.8;
            double textilePrice = 7.2;
            double gluePrice = 1.2;

            int packageAmount = int.Parse(Console.ReadLine());
            int textileAmount = int.Parse(Console.ReadLine());
            double glueAmount = double.Parse(Console.ReadLine());

            double discount = double.Parse(Console.ReadLine()) / 100;
            double packageTotal = packagePaperPrice * packageAmount;
            double textileTotal = textilePrice * textileAmount;
            double glueTotal = gluePrice * glueAmount;

            double moneyNeeded = (packageTotal + textileTotal + glueTotal) * (1 - discount);
            Console.WriteLine($"{moneyNeeded:f3}");
        }
    }
}
