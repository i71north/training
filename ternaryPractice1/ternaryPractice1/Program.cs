using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternaryPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your favorite sport");
            //string sport = Console.ReadLine().ToLower();

            //string favSport = (sport == "hockey" || sport == "football" || sport == "golf") ? "Great Choice" : "Bad Choice";

            //Console.WriteLine(favSport);
            //Console.ReadLine();

            //Console.WriteLine("What is a food that you like?");
            //string food = Console.ReadLine().ToLower();
            //Console.WriteLine("What is the second kind of food you like?");
            //string food2 = Console.ReadLine().ToLower();
            //Console.WriteLine("Name a third food?");
            //string food3 = Console.ReadLine().ToLower();


            //string foodChoice = (food == "chicken" && food2 == "shrimp" && food3 == "fish") ? "Great Choice" : "Bad Choice";
            //Console.WriteLine(foodChoice);
            //Console.ReadLine();

            Console.WriteLine("What is the first vowel in the alphabet");
            string vowel1 = Console.ReadLine().ToLower();
            Console.WriteLine("What is the second vowel in the alphabet");
            string vowel2 = Console.ReadLine().ToLower();
            Console.WriteLine("What is the thrid vowel in the alphabet");
            string vowel3 = Console.ReadLine().ToLower();
            Console.WriteLine("What is the forth vowel in the alphabet");
            string vowel4 = Console.ReadLine().ToLower();
            Console.WriteLine("What is the fifth vowel in the alphabet");
            string vowel5 = Console.ReadLine().ToLower();
            string answer = (vowel1 == "a" && vowel2 == "e" && vowel3 == "i" && vowel4 == "o" && vowel5 == "u") ? "Good Job!!!" : "Sorry, try again";
            Console.WriteLine(answer);
            Console.ReadLine();

        }

    }
}
