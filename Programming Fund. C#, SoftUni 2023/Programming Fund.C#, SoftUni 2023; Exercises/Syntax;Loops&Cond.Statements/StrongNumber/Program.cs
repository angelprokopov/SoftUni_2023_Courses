using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var nCopy = number;
            int sum = 0;

            while (number > 0)
            {
                var factoriel = 1;
                var num = number % 10;
                number /= 10;

                for (int i = 2; i <= num; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
            }
            if (sum == nCopy) { Console.WriteLine("yes"); }
            else { Console.WriteLine("no"); }
        }

    }
}
