using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoopnumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idNum;
            int lowNum = 1000;
            int highNum = 2000;

            Console.WriteLine("Enter a vaild ID number.");
            string valNum = Console.ReadLine();
            int.TryParse(valNum, out idNum);

            while(idNum < lowNum || idNum > highNum)
            {
                Console.WriteLine($"The ID number you entered was {valNum} \n" + $"ID number must be between {lowNum} and {highNum}. \nPlease try again");

                valNum = Console.ReadLine();
                int.TryParse(valNum, out idNum);
            }
            Console.WriteLine("The ID number that you entered was vaild!");
            Console.ReadLine();
        }
    }
}
