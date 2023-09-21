using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substitute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = k; i <= 8; i++)
            {
                if (i % 2 == 1) { continue; }
                for (int o = 9; o >= l; o--)
                {
                    if (o % 2 == 0) { continue; }
                    for (int p = m; p <= 8; p++)
                    {
                        if (p % 2 == 1) { continue; }
                        for (int q = 9; q >= n; q--)
                        {
                            if (q % 2 == 0)
                            {
                                continue;
                            }

                            if (i == p && o == q)
                            {

                                Console.WriteLine("Cannot change the same player.");

                            }
                            else
                            {
                                counter++;
                                Console.WriteLine($"{i}{o} - {p}{q}");


                            }
                            if (counter == 6) { return; }
                        }
                    }
                }
            }
        }
    }
}
