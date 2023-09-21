using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            decimal studio = 0.0M;
            decimal apartment = 0.0M;
            if (month == "May" || month == "October") 
            {
                studio  = 50;
                apartment = 65; 
                if (days > 7 && days <= 14) 
                { 
                    studio *= 0.95M;
                } 
                else if (days > 14)
                {
                    studio *= 0.7M; 
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.2M; 
                apartment = 68.7M;
                if (days > 14)
                {
                    studio *= 0.8M; 
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = 76; 
                apartment = 77;
            }
            if (days > 14)
            {
                apartment *= 0.9M;
            }
            Console.WriteLine($"Apartment: {days * apartment:f2} lv.");
            Console.WriteLine($"Studio: {days * studio:f2} lv.");
        }
    }
}
