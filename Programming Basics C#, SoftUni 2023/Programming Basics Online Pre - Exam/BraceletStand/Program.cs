using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraceletStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyPerDay = double.Parse(Console.ReadLine());
            double sellMoney = double.Parse(Console.ReadLine());
            double cost = double.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double savedMoney = 5 * moneyPerDay;
            double profitFromSell = 5 * sellMoney;
            double totalSavedMoney = profitFromSell + savedMoney;
            double expense = totalSavedMoney - cost;

            if (expense >= presentPrice) { Console.WriteLine($"Profit: {expense:f2} BGN, the gift has been purchased."); }
            else { Console.WriteLine($"Insufficient money: {presentPrice - expense:f2} BGN."); }
        }
    }
}
