using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElsepractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color?");
            string favcolor = Console.ReadLine().ToUpper();

            if (favcolor == "RED")
            {
                Console.WriteLine("red is good");
                Console.WriteLine("We found a match!");
                //Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Whatever!");
                Console.WriteLine("We DID NOT find a match!");
               // Console.ReadLine();
            }

            {
                Console.WriteLine("We are out of here!");
                Console.ReadLine();
            }



        }
    }
}
