using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElsepracticeNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your age?");
            //double firstNum = double.Parse(Console.ReadLine());

            //if (firstNum >= 1 && firstNum <= 10)
            //{
            //    Console.WriteLine("You are just a kid.");
            //}
            //else if (firstNum >= 11 && firstNum <= 20)
            //{
            //    Console.WriteLine("You are in your middle years.");
            //}
            //else if (firstNum >= 21 && firstNum <= 35)
            //{
            //    Console.WriteLine("You are getting there");
            //}
            //else if (firstNum >= 36 && firstNum <= 55)
            //{
            //    Console.WriteLine("You have it figured out by now");
            //}
            //else
            //{
            //    Console.WriteLine("You are in your golden years!");
            //}
            //Console.ReadLine();

            Console.WriteLine("Tell me how much money you have to spend, and I'll tell you what you can buy at my store.");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine($"Here is ${firstNum}.");
            Console.ReadLine();

            if (firstNum >= 1 && firstNum <= 5)
            {
                Console.WriteLine("I will sell you two pairs socks.");
            }
            else if (firstNum >= 6 && firstNum <= 15)
            {
                Console.WriteLine("You can get one pair of socks and a shirt.");
            }
            else if (firstNum >= 16 && firstNum <= 25)
            {
                Console.WriteLine("That will get you a pair of socks, a shirt, and a belt");
            }
            else if (firstNum >= 26 && firstNum <= 35)
            {
                Console.WriteLine("You can buy two shirts and one pair of pants");
            }
            else if (firstNum <= 0)
            {
                Console.WriteLine("You have no money, please leave");
            }
            else
            {
                Console.WriteLine("You can buy whatever you want!");
            }
            Console.ReadLine();

        }
    }
}
