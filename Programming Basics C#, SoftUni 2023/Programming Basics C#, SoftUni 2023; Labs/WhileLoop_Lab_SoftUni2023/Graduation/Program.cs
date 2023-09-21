using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int badGrade = 0;
            int grade = 1;
            double sumGrade = 0;
            while (grade <= 12)
            {
                double yearGrade = double.Parse(Console.ReadLine());
                if (yearGrade < 4)
                {
                    badGrade++;
                    if (badGrade < 2) { continue; }
                    else { Console.WriteLine($"{name} has been excluded at {grade} grade"); break; }
                }
                grade++;
                sumGrade += yearGrade;
            }
            if (grade >= 12)
            {
                double averageGrade = sumGrade / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
            
        }
    }
}
