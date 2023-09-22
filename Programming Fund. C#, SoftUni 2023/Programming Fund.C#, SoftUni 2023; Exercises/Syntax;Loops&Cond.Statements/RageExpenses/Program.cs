using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int counterGameBrokenHeadset = 0;
            int counterGameBrokenMouse = 0;
            int counterGameBrokenKeyboard = 0;

            bool headsetBroken = false;
            bool mouseBroken = false;
            double price = 0;

            for (int i = 1; i <= lostGameCount; i++)
            {
                counterGameBrokenHeadset++;
                counterGameBrokenMouse++;

                if (counterGameBrokenHeadset == 2)
                {
                    headsetBroken = true;
                    counterGameBrokenHeadset = 0;
                    price += headsetPrice;
                }
                else {    headsetBroken = false; }
                if (counterGameBrokenMouse == 3)
                {
                    mouseBroken = true;
                    counterGameBrokenMouse = 0;
                    price += mousePrice;
                } 
                else { mouseBroken = false; }
                if (headsetBroken && mouseBroken)
                {
                    headsetBroken = false;
                    mouseBroken = false;
                    counterGameBrokenKeyboard++;
                    price += keyboardPrice;
                }

                if (counterGameBrokenKeyboard == 2)
                {
                    counterGameBrokenKeyboard = 0;
                    price += displayPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {price:f2} lv.");
        }
    }
}
