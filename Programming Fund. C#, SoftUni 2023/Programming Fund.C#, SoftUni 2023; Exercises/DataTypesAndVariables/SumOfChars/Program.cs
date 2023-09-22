using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte charCount = byte.Parse(Console.ReadLine());
            int sum = 0;
            while(charCount > 0)
            {
                sum += char.Parse(Console.ReadLine());
                charCount--;
            }
            Console.WriteLine($"The sum equals: {sum}" );
        }
    }
}
