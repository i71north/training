using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_CalculatorApplication
{enum CalcOptions
    {
        Addition = 1,
        Subtraction,
        Multiplication,
        Divison
    }

    class Program
    {
        static void Main()
        {
            Program p = new Program();

            int options;
            Console.WriteLine("Which type mathmatical operation would you like the calculator to perform? \n 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division");
            string select = Console.ReadLine();
            int.TryParse(select, out options);

            int num1 = 1;
            int num2 = 1;
            Console.WriteLine("Enter your first number");
            string first = Console.ReadLine();
            int.TryParse(first, out num1);

            while (num1 <= 0)
            {
                Console.WriteLine($"{num1} is not a vaild entry");
            }


            Console.WriteLine("Enter your second number");
            string second = Console.ReadLine();
            int.TryParse(second, out num2);

            while (num2 <= 0)
            {
                Console.WriteLine($"{num2} is not a vaild entry");
            }

            switch ((CalcOptions)options)
            {
                case CalcOptions.Addition:
                    p.Plus(num1, num2);
                    break;

                case CalcOptions.Subtraction:
                    p.Minus(num1, num2);
                    break;

                case CalcOptions.Multiplication:
                    p.Times(num1, num2);
                    break;

                case CalcOptions.Divison:
                    p.Divide(num1, num2);
                    break;

                default:

                    Console.WriteLine("That is not a vaild selection. \nTry again.");
                    break;
            }

            string answer1 = "yes";
            string answer2 = "no";

            Console.WriteLine("Would you like to start again? ");
            string input = Console.ReadLine();

            while (input == answer1)
            {
                Console.WriteLine("Press enter to continue.");
                input = Console.ReadLine();
                Main();
            }
            while (input == answer2)
            {
                Console.WriteLine("Goodbye.");
                input = Console.ReadLine();
            }
        }

        public void Plus(int num1, int num2)
        {
            int sum = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {sum}");
        }

        public void Minus(int num1, int num2)
        {
            int difference = num1 - num2;

            Console.WriteLine($"{num1} - {num2} = {difference}");
        }

        public void Times(int val1, int val2)
        {
            int product = val1 * val2;

            Console.WriteLine($"{val1} * {val2} = {product}");
        }

        public void Divide(int val1, int val2)
        {
            int quotient = val1 / val2;

            Console.WriteLine($"{val1} / {val2} = {quotient}");
        }
    }
  
}
       











    

