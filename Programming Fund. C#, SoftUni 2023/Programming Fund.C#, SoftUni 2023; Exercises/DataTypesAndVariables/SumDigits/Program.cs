using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int totalSum = 0;
            do 
            { 
                totalSum = totalSum + (num % 10); 
                num /= 10;  
            } 
            while (num > 0);
            Console.WriteLine(totalSum);
        }
    }
}
