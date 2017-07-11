using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseprac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite car?");
            string car = Console.ReadLine().ToLower();
            
            if (car == "ford")
            {
                Console.WriteLine("I like fords too!");
            }
             else if (car == "tesla")
            {
                Console.WriteLine("teslas are cool!");
            }
            else if (car == "dodge")
            {
                Console.WriteLine("I dont like dodge!");
            }
            else
            {
                Console.WriteLine("That is not a real car!");
            }
            Console.ReadKey();
        }
    }
}
