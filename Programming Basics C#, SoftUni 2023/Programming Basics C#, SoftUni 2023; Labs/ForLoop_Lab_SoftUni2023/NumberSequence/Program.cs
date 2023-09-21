using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bigNum = int.MinValue;
            int minNum = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (bigNum < num) 
                    bigNum = num;
                if (minNum > num) 
                    minNum = num;
            }
            Console.WriteLine($"Max number: {bigNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
