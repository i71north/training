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
        static void Main(string[] args)
        {
            Program p = new Program();

            int options;
            Console.WriteLine("Which type mathmatical operation would you like the calculator to perform? \n (+) Addition \n (-) Subtraction \n (*) Multiplication \n (/) Division");
            string select = Console.ReadLine();
            int.TryParse(select, out options);

            int num1;
            int num2;
            Console.WriteLine("Enter your first number");
            string first = Console.ReadLine();
            int.TryParse(first, out num1);

            Console.WriteLine("Enter your second number");
            string second = Console.ReadLine();
            int.TryParse(second, out num2);

            Console.ReadLine();



            switch ((CalcOptions)options)
            {
                case CalcOptions.Addition:
                    p.Plus(num1, num2);
                    break;

                case CalcOptions.Subtraction:
                    p.Minus(num1, num2);
                    break;

                case CalcOptions.Multiplication:
                    Times();
                    break;

                case CalcOptions.Divison:
                    Divide();
                    break;
            }

        }

        public void Plus(int num1, int num2)
        {
            int sum = num1 + num2;

            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
        }

        public void Minus(int num1, int num2)
        {
            int difference = num1 - num2;

            Console.WriteLine($"The difference of {num1} and {num2} is {difference}");
        }












    }
}
