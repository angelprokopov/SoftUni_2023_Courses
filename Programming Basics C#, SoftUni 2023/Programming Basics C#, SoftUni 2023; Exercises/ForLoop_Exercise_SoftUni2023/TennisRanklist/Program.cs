using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentCount = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());
            
            int newSeasonPoints = 0;
            int wonTournaments  = 0;
            for (int i = 0; i < tournamentCount; i++) 
            {
                string position = Console.ReadLine();
                if (position == "W") { newSeasonPoints += 2000; wonTournaments++; }
                else if (position == "F") { newSeasonPoints += 1200; }
                else if ( position == "SF") { newSeasonPoints += 720; }
            }
            Console.WriteLine($"Final points: {initialPoints + newSeasonPoints} ");
            Console.WriteLine($"Average points: {newSeasonPoints / tournamentCount}");
            Console.WriteLine($"{100.0 * wonTournaments / tournamentCount:f2}%");
        }
    }
}
