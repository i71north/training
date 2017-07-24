using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPassingReference1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine($"In the main method x = {x}.");
            DisplayValueParameter(x);
            Console.WriteLine($"In the main method the value of x is now {x}.");
            Console.ReadLine();
        }

        private static void DisplayValueParameter(int x)
        {
            x = 1000;
            Console.WriteLine($"We are in the Display Parmeter Method \n Where x = {x}.");
        }
    }
}
