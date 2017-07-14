using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumpractice1
{

    enum Movies
    {
        Jaws = 1,
        Goodfellas,
        Heat,
        Scarface,
        Godfather,
        Avatar,
        Inception,
        GetOut
    }
    enum VacationCities
    {
        Cleveland = 1,
        Chicago,
        Houston,
        Los_Angeles,
        Boston,
    }

    class Program
    {
        static void Main(string[] args)
        {
            int favMovie;
            Console.WriteLine("Which movie is your favorite? \n 1. Jaws \n 2. Goodfellas \n 3. Heat");
            string favorite = Console.ReadLine();

            int.TryParse(favorite, out favMovie);

            switch((Movies)favMovie)
            {
                case Movies.Jaws:
                    Console.WriteLine("Jaws was a great movie.");
                    break;

                case Movies.Goodfellas:
                    Console.WriteLine("Goodfellas...an American classic!");
                    break;

                case Movies.Heat:
                    Console.WriteLine("Heat...a thriller in Miami");
                    break;

                default:
                    Console.WriteLine("Sorry that movie did not make our list");
                    break;
            }Console.WriteLine("Out of the movie switch statement block");
            Console.ReadKey();


            int city2017;
            Console.WriteLine("Where will you go on your vacation this year? \n 1. Cleveland \n 2. Chicago \n 3. Houston \n 4. Los Angeles \n 5. Boston");
            string city = Console.ReadLine();

            int.TryParse(city, out city2017);

            switch ((VacationCities)city2017)
            {
                case VacationCities.Cleveland:
                    Console.WriteLine("Staycation at home, awesome!");
                    break;

                case VacationCities.Chicago:
                    Console.WriteLine("Chicago is in the Midwest.");
                    break;

                case VacationCities.Houston:
                    Console.WriteLine("Houston is in Texas.");
                    break;

                case VacationCities.Los_Angeles:
                    Console.WriteLine("Los Angeles is very popular.");
                    break;

                case VacationCities.Boston:
                    Console.WriteLine("Boston is a Northeastern city.");
                    break;

                default:
                    Console.WriteLine("Sorry that city did not make the list");
                    break;
            }
            Console.WriteLine("Out of the vacation switch statement block");
            Console.ReadKey();

        }
    }
}
