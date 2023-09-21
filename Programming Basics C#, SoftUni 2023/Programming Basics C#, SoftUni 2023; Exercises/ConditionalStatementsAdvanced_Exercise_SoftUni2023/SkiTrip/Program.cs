using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day_stay = int.Parse(Console.ReadLine());
            string type_room = Console.ReadLine();
            string assessment = Console.ReadLine();
            day_stay = day_stay - 1;
            switch (type_room)
            {
                case "room for one person":
                    {
                        if (day_stay >= 1 && day_stay <= 365)
                        {
                            if (assessment == "positive") Console.WriteLine($"{day_stay * 18 * 1.25:F2}");
                            if (assessment == "negative") Console.WriteLine($"{day_stay * 18 * .9:F2}");
                        }
                    }
                    break;
                case "apartment":
                    {
                        if (day_stay >= 1 && day_stay < 10)
                        {
                            if (assessment == "positive") Console.WriteLine($"{(((day_stay * 25) * .7) * 1.25):F2}");
                            if (assessment == "negative") Console.WriteLine($"{(((day_stay * 25) * .7) * .9):F2}");
                        }
                        else if (day_stay >= 10 && day_stay <= 15) // + else
                        {
                            if (assessment == "positive") Console.WriteLine($"{(((day_stay * 25) * .65) * 1.25):F2}");
                            if (assessment == "negative") Console.WriteLine($"{(((day_stay * 25) * .65) * .9):F2}");
                        }
                        else // else
                        {
                            if (assessment == "positive") Console.WriteLine($"{(((day_stay * 25) * .5) * 1.25):F2}");
                            if (assessment == "negative") Console.WriteLine($"{(((day_stay * 25) * .5) * .9):F2}");
                        }
                    }
                    break;
                case "president apartment":
                    {
                        if (day_stay >= 1 && day_stay < 10)
                        {
                            if (assessment == "positive") Console.WriteLine($"{(((day_stay * 35) * .9) * 1.25):F2}");
                            if (assessment == "negative") Console.WriteLine($"{(((day_stay * 35) * .9) * .9):F2}");
                        }
                        else if (day_stay >= 10 && day_stay <= 15) // + else
                        {
                            if (assessment == "positive") Console.WriteLine($"{(((day_stay * 35) * .85) * 1.25):F2}");
                            if (assessment == "negative") Console.WriteLine($"{(((day_stay * 35) * .85) * .9):F2}");
                        }
                        else // else
                        {
                            if (assessment == "positive") Console.WriteLine($"{(((day_stay * 35) * .8) * 1.25):F2}");
                            if (assessment == "negative") Console.WriteLine($"{(((day_stay * 35) * .8) * .9):F2}");
                        }
                    }
                    break;
            }
        }
    }
}
   
