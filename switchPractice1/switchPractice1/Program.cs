using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color");
            string color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.WriteLine("Red is an ok color");
                    break;
                case "blue":
                    Console.WriteLine("Blue is a nice color");
                    break;
                case "pink":
                    Console.WriteLine("Pink is a lovely color");
                    break;

                default:
                    Console.WriteLine("We don't understand your answer.");
                    break;
            }
                    
                    Console.WriteLine("We broke out of the loop!");
            Console.ReadLine();


            
            int foodLike;
            Console.WriteLine("What is your favorite pasta dish? \n 1. Lasagne \n 2. Spaghetti \n 3. Ravioli");
            //int foodChoice = Convert.ToInt32(Console.ReadLine().ToUpper());
            string foodChoice = Console.ReadLine();
            //int foodChoice = int.Parse(ReadLine());
            int.TryParse(foodChoice, out foodLike);
            //double food = Convert.ToDouble(ReadLine().ToUpper());
                    

            switch (foodLike)
            {
                case 1:
                    Console.WriteLine("Lasagne is fantastic!");
                    break;
                case 2:
                    Console.WriteLine("Spaghetti is delish!");
                    break;
                case 3:
                    Console.WriteLine("Ravioli was invented by Chef Boyardi.");
                    break;

                default:

                    Console.WriteLine("Eww, what is that?");
                    break;
            }
            Console.WriteLine("I'm out of the loop!");
            Console.ReadLine();
            




    }   }
}

