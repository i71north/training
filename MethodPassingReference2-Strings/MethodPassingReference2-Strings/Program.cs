using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPassingReference2_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player 1, what is your first name?");
            string player1 = Console.ReadLine();
            nameChange(player1);
            Console.WriteLine($"In the main method... the name of player 1 is {player1}.");
            nameTransform(ref player1);
            Console.WriteLine($"Inside of the very very main method the value of player 1 is {player1}");

            Console.ReadLine();
        }

        public static void nameChange(string originalPlayer1)
        {
            originalPlayer1 = "new player 1";
            Console.WriteLine($"Inside of the name change method, the name of Player 1 \n is {originalPlayer1}");
        }

        public static void nameTransform(ref string player1)
        {
            player1 = "I am king of the world";
            Console.WriteLine($"Today {player1}");
        }






    }   

}

