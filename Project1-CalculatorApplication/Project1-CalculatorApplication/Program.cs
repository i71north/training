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
            Console.WriteLine("Which type mathmatical operation would you like the calculator to perform? \n 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division");
            string select = Console.ReadLine();
            int.TryParse(select, out options);

            switch ((CalcOptions)options)
            {
                case CalcOptions.Addition:
                    break;

                case CalcOptions.Subtraction:
                    break;

                case CalcOptions.Multiplication:
                    break;

                case CalcOptions.Divison:
                    break;

                default:

                    Console.WriteLine("That is not a vaild selection. \nTry again.");
                    break;
            }
           

            int num1;
            int num2;

            Console.WriteLine("Enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            string first = Console.ReadLine();
            int.TryParse(first, out num1);

            while (num1 <= 0)
            {
                Console.WriteLine($"{num1} is not a vaild entry");
            }


            Console.WriteLine("Enter your second number");
            string second = Console.ReadLine();
            int.TryParse(second, out num2);
            num2 = Convert.ToInt32(Console.ReadLine());

            while (num2 <= 0)
            {
                Console.WriteLine($"{num2} is not a vaild entry");
            }

            Console.ReadLine();

            
        }
        public void Calculate()
        {
            

            

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

        public void Times(int val1, int val2)
        {
            int product = val1 * val2;

            Console.WriteLine($"The product of {val1} and {val2} is {product}");
        }

        public void Divide(int val1, int val2)
        {
            int quotient = val1 / val2;

            Console.WriteLine($"The quotient of {val1} and {val2} is {quotient}");
        }




    }
   

}

        

          








    

