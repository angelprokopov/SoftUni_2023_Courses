using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int juriesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < juriesCount && points <= 1250.5; i++)
            {
                string juryName = Console.ReadLine();
                double juryPoint = double.Parse(Console.ReadLine());

                points += juryName.Length * juryPoint / 2;
            }
            if (points > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:f1}!");
            }
            else { Console.WriteLine($"Sorry, {actor} you need {1250.5 - points:f1} more!"); }
        }
    }
}
