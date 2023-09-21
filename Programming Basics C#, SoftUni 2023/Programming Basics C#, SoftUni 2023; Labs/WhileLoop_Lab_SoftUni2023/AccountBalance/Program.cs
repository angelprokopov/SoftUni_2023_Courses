using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double bankAccount = 0;
            while (input != "NoMoreMoney")
            {
                double currentAmount = double.Parse(input);
                if (currentAmount < 0) { Console.WriteLine("Invalid operation!"); break; }
                bankAccount += currentAmount;
                Console.WriteLine($"Increase: {currentAmount:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {bankAccount:f2}");
        }
    }
}
