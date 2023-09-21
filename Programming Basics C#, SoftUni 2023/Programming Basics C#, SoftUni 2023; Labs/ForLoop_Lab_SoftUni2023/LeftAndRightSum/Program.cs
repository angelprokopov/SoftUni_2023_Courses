using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            for (int i = 0; i < n; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
            }
            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                rightSum += int.Parse(Console.ReadLine());
            }
            if (leftSum == rightSum) { Console.WriteLine($"Yes, sum = {leftSum}"); }
            else { int diff = Math.Abs(leftSum - rightSum); Console.WriteLine($"No, diff = {diff}"); }
        }
    }
}
