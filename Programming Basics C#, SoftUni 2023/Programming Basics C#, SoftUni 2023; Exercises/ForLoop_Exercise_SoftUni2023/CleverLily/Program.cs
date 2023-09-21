using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            // 2. Calculate saved money
            int savedMoney = 0;
            int giftedMoney = 10;
            for (int i = 1; i <= age; i++)
            {
                if(i % 2 != 0) { savedMoney += toyPrice; }
                else {savedMoney += giftedMoney - 1; giftedMoney += 10; }
            }

            // 3. Print output
            if (savedMoney >= washingMachinePrice) { Console.WriteLine($"Yes! {savedMoney - washingMachinePrice:f2}"); }
            else { Console.WriteLine($"No! {washingMachinePrice - savedMoney:f2}"); }
        }
    }
}
