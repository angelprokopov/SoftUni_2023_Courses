using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            int sumMinute = (hour * 60) + minute;
            sumMinute = sumMinute + 15;

            int resHour = sumMinute / 60;
            int resMin = sumMinute % 60;

            Console.WriteLine($"{resHour % 24}:{resMin:D2}");
        }
    }
}
