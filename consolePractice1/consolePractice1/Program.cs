using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolePractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string dude = Console.ReadLine();

            //Console.WriteLine($"My name is {dude}");
            //Console.ReadLine();

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();

            Console.WriteLine($"I am {age} years old.");
            Console.ReadLine();

            Console.WriteLine("What is the name of your street name?");
            string street = Console.ReadLine();

            Console.WriteLine("What is email address?");
            string email = Console.ReadLine();

            Console.WriteLine($" My age is {age}, my street name is {street}, my email address is {email}.");

            Console.ReadKey();








        }
    }
}
