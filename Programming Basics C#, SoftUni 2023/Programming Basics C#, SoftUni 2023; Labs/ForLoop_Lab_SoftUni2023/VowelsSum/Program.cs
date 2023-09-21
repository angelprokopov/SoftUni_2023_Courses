using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumA = 0;
            int sumE = 0;
            int sumI = 0;
            int sumO = 0;
            int sumU = 0;
            string text = Console.ReadLine().ToLower();
            for (int i = 0; i <= text.Length - 1; i++)
            {
                if (text[i] == 'a') { sumA ++; }
                else if (text[i] == 'e') { sumE += 2; }
                else if (text[i] == 'i') { sumI += 3; }
                else if (text[i] == 'o') { sumO += 4; }
                else if (text[i] == 'u') { sumU += 5; }
            }
            int resultSum = sumA + sumE + sumI + sumO + sumU;
            Console.WriteLine(resultSum);
        }
    }
}
