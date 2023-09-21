using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            // 2. Normalize time
            int examTime = examHour * 60 + examMinutes;
            int arrivalTime = arrivalHour * 60 + arrivalMinutes;

            // 3. Check if we're early, on time or late
            int diff = examTime - arrivalTime;
            string verdict = "";
            if (diff < 0) { verdict = "Late"; }
            else if (diff <= 30) { verdict = "On time"; }
            else { verdict = "Early"; }

            string formattedTime = "";
            int absoluteDiff = Math.Abs(diff);
            if (absoluteDiff < 60) { formattedTime = $"{absoluteDiff} minutes"; }
            else { int diffHours = absoluteDiff / 60; int diffMinutes = absoluteDiff % 60; if (diffMinutes < 10) { formattedTime = $"{diffHours}:0{diffMinutes} hours"; } else { formattedTime = $"{diffHours}:{diffMinutes} hours"; } }
            string keyword = "";
            if (diff < 0) { keyword = "after"; }
            else { keyword = "before"; }
            // 4. Print output
            Console.WriteLine(verdict);
            if(diff != 0) Console.WriteLine($"{formattedTime} {keyword} the start");
        }
    }
}
