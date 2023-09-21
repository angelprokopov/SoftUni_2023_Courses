using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            double dogFoodPrice = 2.5;
            double catFoodPrice = 4;
            double totalPrice = (dogFood * dogFoodPrice) + (catFood * catFoodPrice);
            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
