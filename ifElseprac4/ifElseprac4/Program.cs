using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseprac4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite city to vacation?");
            string city = Console.ReadLine().ToLower();

            if (city == "cleveland")
            {
                Console.WriteLine("Cleveland is great!");
                Console.WriteLine("I was born and raised there.");
            }
            else if (city == "atlanta")
            {
                Console.WriteLine("Atlanta is overrated");
                Console.WriteLine("That is where my dad was born in 1934");
            }
            else if (city == "la")
            {
                Console.WriteLine("L.A. has a bunch of weirdos. Ugh!");
                Console.WriteLine("I only been there once.");
            }
            else
            {
                Console.WriteLine("I've never been there.");
                Console.WriteLine("Will you take me with you the next time you go?");
            }
            Console.ReadKey();

        }
    }
}
