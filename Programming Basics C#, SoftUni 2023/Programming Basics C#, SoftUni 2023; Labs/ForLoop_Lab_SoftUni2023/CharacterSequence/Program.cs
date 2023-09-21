using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();
            for (int i = 0; i < symbol.Length; i++)
            {
                char letter = symbol[i];
                Console.WriteLine(letter);
            }
        }
    }
}
