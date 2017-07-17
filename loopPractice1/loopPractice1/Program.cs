using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0; define a vaule for i, which is 0
            //i < 10; = says that i is less than 10
            //i++; ++ means to increment the value of i 
            // arrays = collection of liked typed varibles
            // arrays of fixed size
            // array sizes cannot be changed onced created
            // arrays are 0 based

            int[] numbers = { 2, 4, 88, 11, 55, 100, 165 };
            string[] stars = { "Beyonce", "Rhianna", "Janet Jackson", "Madoanna" };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The value of i is {i}");
            }
            Console.ReadLine();

            for (int k = 0; k < stars.Length; ++k)
            //.Length covers any amount of varibles w/out having to know or enter the exact # of vars 
            {
                Console.WriteLine($"The stars are " + (stars[k]));
            }
            Console.ReadLine();

            for (int f = 0; f < numbers.Length; ++f)
            {
                Console.WriteLine("The stars are " + (numbers[f]));
            }
            Console.ReadLine();


            for (int d = 0; d < numbers.Length; ++d)
            {
                Array.Reverse(numbers);
                Console.WriteLine(numbers[d]);
            }
            Console.ReadLine();
           
        }
    }
}
