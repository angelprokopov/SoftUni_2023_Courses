using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNum = int.MinValue;
            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number > maxNum) { maxNum = number; }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
