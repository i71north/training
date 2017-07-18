using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessingGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int rnum = rand.Next(1, 6);
            int realNum; 

            Console.WriteLine("Enter a number between 1 and 6.");
            string numGuess = Console.ReadLine();

            int.TryParse(numGuess, out realNum);

            while (realNum < 0 || realNum > 6)
            {
                Console.WriteLine("You must guess between 1 and 5...try again");
                numGuess = Console.ReadLine();
                int.TryParse(numGuess, out realNum);
            }

            while (realNum != rnum)
            {
                Console.WriteLine($"Your guess of {numGuess} was not the corect # \n Guess again.");
                numGuess = Console.ReadLine();
                int.TryParse(numGuess, out realNum);

            }
            Console.WriteLine($"Your guess of {rnum} was correct....Hooray");
            Console.ReadLine();

        }
    }
}
