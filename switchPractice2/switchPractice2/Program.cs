using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What time of the day do you walk your dog?");
            string walk = Console.ReadLine().ToLower();

            switch (walk)
            {
                case "6am":
                    Console.WriteLine("6am is a good time. Fresh air early in the morning is wonderful!");
                    break;
                case "12noon":
                    Console.WriteLine("It could be too hot for your dog during the midday hours.");
                    break;
                case "6pm":
                    Console.WriteLine("6pm is a great time. Your dog will be so happy to see you when you come home from work - double the fun!");
                    break;

                default:
                    Console.WriteLine("I guess that time is ok, but it was not what I was thinking.");
                    break;
            }

            Console.WriteLine("Exit Loop");
            Console.ReadLine();

            
            Console.WriteLine("What will you name your new puppy? \n 1. Lassie \n 2. Baxter \n 3. Roxie");
            //int name = Convert.ToInt32(Console.ReadLine().ToLower());
            string name = Console.ReadLine();
            int puppyName;
            int.TryParse(name, out puppyName);

            switch (puppyName)
            {
                case 1:
                    Console.WriteLine("Lassie was a TV show back in the day.");
                    break;
                case 2:
                    Console.WriteLine("Baxter was the dog in the movie Anchorman.");
                    break;
                case 3:
                    Console.WriteLine("Hey! That name is taken already. It's my dog's name!.");
                    break;

                default:

                    Console.WriteLine("Are you sure about that?");
                    break;
            }
            Console.WriteLine("Loop - out");
            Console.ReadLine();

























        }

    }
}
