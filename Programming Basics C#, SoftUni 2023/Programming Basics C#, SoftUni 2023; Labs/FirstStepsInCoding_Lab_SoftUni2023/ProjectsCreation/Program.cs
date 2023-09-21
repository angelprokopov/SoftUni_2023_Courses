using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int hoursNeed = 3;
            int projects = int.Parse(Console.ReadLine());
            int totalHours = hoursNeed * projects;

            Console.WriteLine($"The architect {architectName} will need {totalHours} hours to complete {projects} project/s.");
        }
    }
}
