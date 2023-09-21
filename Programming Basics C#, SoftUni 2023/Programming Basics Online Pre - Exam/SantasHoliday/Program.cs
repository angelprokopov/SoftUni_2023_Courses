using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stayingDays = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            double pricePerNight = 0;

            switch (typeRoom)
            {
                case "room for one person":
                    if (stayingDays < 10)
                    {
                        pricePerNight = 18.00;
                    }
                    else if (stayingDays <= 15)
                    {
                        pricePerNight = 18.00;
                    }
                    else
                    {
                        pricePerNight = 18.00;
                    }
                    break;
                case "apartment":
                    if (stayingDays < 10)
                    {
                        pricePerNight = 25.00 - (25.00 * 0.30);
                    }
                    else if (stayingDays <= 15)
                    {
                        pricePerNight = 25.00 - (25.00 * 0.35);
                    }
                    else
                    {
                        pricePerNight = 25.00 - (25.00 * 0.50);
                    }
                    break;
                case "president apartment":
                    if (stayingDays < 10)
                    {
                        pricePerNight = 35.00 - (35.00 * 0.10);
                    }
                    else if (stayingDays <= 15)
                    {
                        pricePerNight = 35.00 - (35.00 * 0.15);
                    }
                    else
                    {
                        pricePerNight = 35.00 - (35.00 * 0.20);
                    }
                    break;


            }
            double totalPayNights = (stayingDays - 1) * pricePerNight;
            switch (rating)
            {
                case "positive":
                    totalPayNights = totalPayNights + (totalPayNights * 0.25);
                    break;
                case "negative":
                    totalPayNights = totalPayNights - (totalPayNights * 0.10);
                    break;
            }
            Console.WriteLine(totalPayNights.ToString("f2"));

        }
    }
}
