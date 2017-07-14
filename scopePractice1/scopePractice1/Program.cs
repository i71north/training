using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scopePractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 2;

            int sum = number1 * number2;

            Console.WriteLine($"{number1} * {number2} = {sum}");
            Console.WriteLine("We are at the bottom of the main method.");
            Console.ReadLine();
            Display();
            Printing();

        }

        public static void Printing()
        {
            Console.WriteLine("This is great");
            Console.WriteLine("At the end of the printing method");
            Console.ReadLine();







        }

        public static void Display()
        {
            Console.WriteLine("Today is Friday!");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();








        }

        public static void Multiply()
        {








        }


        public class Start
        {




















        }





    }
}
