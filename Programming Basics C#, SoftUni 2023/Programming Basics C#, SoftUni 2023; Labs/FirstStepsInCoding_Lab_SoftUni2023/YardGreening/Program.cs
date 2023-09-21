using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double metersYard = double.Parse(Console.ReadLine());
            double expenses = metersYard * 7.61;
            double discount = expenses * 0.18;
            double totalSum = expenses - discount;
            Console.WriteLine($"The final price is: {totalSum} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
