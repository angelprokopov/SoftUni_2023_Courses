using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            // 2. Calculate fine
                // 2.1 Stop if there is nothing left from the salary
            int fine = 0;
            for (int i = 0; i < n && fine < salary; i++)
            {
                string website = Console.ReadLine();
                if (website == "Facebook") { fine += 150; }
                else if (website == "Instagram") { fine += 100; }
                else if (website == "Reddit") { fine += 50; }
            }

            // 3. Print output
            if (fine >= salary) { Console.WriteLine("You have lost your salary."); }
            else { Console.WriteLine(salary - fine); }
        }
    }
}
