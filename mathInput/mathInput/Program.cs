﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathInput
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Give me the first # to add");
            string firstNum = Console.ReadLine();
            int firstN = Convert.ToInt16(firstNum);

            Console.WriteLine("Give me the second # you want to add");
            string secondNum = Console.ReadLine();
            int secondN = Convert.ToInt32(secondNum);

            double sum = secondN + firstN;
            Console.WriteLine($"your first Number was {firstNum} and your second number was {secondNum} the sum is {sum}");
            Console.ReadLine();
         

        }
    }
}
