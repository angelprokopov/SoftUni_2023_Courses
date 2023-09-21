using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double requiredMoney = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int consecutiveSpendDays = 0;
            while(currentMoney < requiredMoney && consecutiveSpendDays < 5) 
            {
                string operation = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                if (operation == "save") { currentMoney += amount; consecutiveSpendDays = 0; }
                else if (operation == "spend")
                {
                    /*if (amount > currentMoney) { currentMoney = 0; } 
                    else { currentMoney -= amount;}*/
                    currentMoney = Math.Max(currentMoney - amount, 0);
                    consecutiveSpendDays++;
                }
                days++;
            }
            if (currentMoney >= requiredMoney)
            {
                Console.WriteLine($"You saved the money for {days} days");
            }
            else
            {
                Console.WriteLine("You can't save the money");
                Console.WriteLine(days);
            }
        }
    }
}
