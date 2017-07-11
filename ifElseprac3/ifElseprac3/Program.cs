using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseprac3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine().ToLower();

             if (food == "eggs")
            {
                Console.WriteLine("Love eggs, they are a great source of protein and omega 3s.");
                Console.WriteLine("Thanks for sharing. : )");
            }
            else if (food == "pizza")
            {
                Console.WriteLine("I never get tired of pizza. Mmmmm, carbs!");
                Console.WriteLine("Thanks for sharing. : )");
            }
            else if (food == "mushrooms")
            {
                Console.WriteLine("Mushrooms are great too, a good source od vitamin D.");
                Console.WriteLine("Thanks for sharing. : )");
            }
            else
            {
                Console.WriteLine("No sir, I don't like it.");
                Console.WriteLine("GET AWAY FROM ME!");
            }
            Console.ReadKey();
        }
    }
}
