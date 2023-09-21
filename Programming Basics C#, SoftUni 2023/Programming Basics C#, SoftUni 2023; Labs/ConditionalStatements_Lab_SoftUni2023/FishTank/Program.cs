using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double usedPercentage = double.Parse(Console.ReadLine());

            int volume = width * length * height;
            double capacityInLiters = volume * 0.001;
            double freeCapacity = capacityInLiters - (0.01 * usedPercentage * capacityInLiters);

            Console.WriteLine(freeCapacity);
        }
    }
}
