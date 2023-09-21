using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read the input (deposit sum, deposit term, interest rate)

            double depositSum = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());

            // 2. Calculate with the given formula

            double result = depositSum + depositTerm * ((depositSum + interestRate * 0.01) / 12);
            // 3. Print the result

            Console.WriteLine(result);
        }
    }
}
