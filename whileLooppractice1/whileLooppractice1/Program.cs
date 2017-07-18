using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLooppractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "bob";
            string password = "007";

            Console.WriteLine("What is your username?");
            string inputName = Console.ReadLine();

            Console.WriteLine("What is your password?");
            string pw = Console.ReadLine();

            while (inputName != userName || pw != password)
            {
                Console.WriteLine("The combination that you entered was not correct.");
                Console.WriteLine("Sorry, please try again");
                inputName = Console.ReadLine();
                pw = Console.ReadLine();
            }
            Console.WriteLine("Username and password are both correct...Hooray!");
            Console.ReadKey();




        }
    }
}
