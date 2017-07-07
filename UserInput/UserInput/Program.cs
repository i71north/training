using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name + " How are you today?");
            //string concatenation
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();

            Console.WriteLine("You are an {0} year old woman", age);
            //varible dropping into place
            Console.WriteLine(" {0} You are a {1} year old woman am I right {2}", name, age, age);
            Console.ReadLine();

            Console.WriteLine("Are you going out tonight:");
            string goingout = Console.ReadLine();

            //string interpolation
            Console.WriteLine($"My name is {name} I am {age} and {goingout} of course");
            Console.ReadLine();








        }
    }
}
