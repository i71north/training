using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolePractice2
{
    class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("What day of the week is it?");
         string day = Console.ReadLine();

            Console.WriteLine($"Today is {day}");
            Console.ReadLine();

         Console.WriteLine("What month are we currently in?");
         string month = Console.ReadLine();

            Console.WriteLine($"We are currently in {month}");
            Console.ReadLine();

         Console.WriteLine("What is today's date?");
         string date = Console.ReadLine();

            Console.WriteLine($"Today's date is the {date}");
            Console.ReadLine();

         Console.WriteLine("What year is it?");
         string year = Console.ReadLine();

            Console.WriteLine($"It is {year}");
            Console.ReadLine();

            Console.ReadKey();

        }
    }
}
