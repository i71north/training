using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopPractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int randNum = r.Next(1, 11);
            int actualNum;
            int numofguesses = 1;
            //previous 2 statements are declarations

            Console.WriteLine("Guess a number between 1 and 10");

            do
            {
                string numGuess = Console.ReadLine();
                while (!int.TryParse(numGuess, out actualNum) || actualNum < 1 || actualNum > 10)
                {
                    Console.WriteLine("You guessed a crazy number. \n Try again.");
                    numGuess = Console.ReadLine();

                    numofguesses++;
                }

                if (randNum == actualNum)
                {
                    Console.WriteLine($"Your guess of {randNum} was correct \n You used {numofguesses} guesses.");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine($"Your guess of {actualNum} was not correct. \n Guess again."); numofguesses++;
                }

            } while (actualNum != randNum);
        }
    }
}
