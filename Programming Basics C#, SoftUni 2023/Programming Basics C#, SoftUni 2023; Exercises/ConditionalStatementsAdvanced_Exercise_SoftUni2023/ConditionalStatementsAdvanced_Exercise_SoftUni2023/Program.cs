using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAdvanced_Exercise_SoftUni2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double income = 0.0;

            if (type == "Premiere") { income = rows * colums * 12.00; }
            else if(type == "Normal") { income = rows * colums * 7.50; }
            else if (type == "Discount") { income = rows * colums * 5.00; }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
