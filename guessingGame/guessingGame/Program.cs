using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //Random rnd = new Random();

            Vacation v = new Vacation();
            Console.WriteLine("Hello World!");

            p.Tuesday();
            p.Working();
            Lunch();
            Talking();
            v.Bahamas();
            v.Cancun();
      
            Console.WriteLine("I'm baaaaack in the main method!");
            Console.ReadKey();
        }
        public void Working()
        {
            Console.WriteLine("Hey...I'm working over here!");
        }
        public static void Talking()
        {
            Console.WriteLine("Doing alot of talking today");
        }
        public void Tuesday()
        {
            Console.WriteLine("Tuesday's are the best!");
            Console.ReadLine();
        }
        public static void Lunch()
        {
            Console.WriteLine("I love it when it's lunchtime!!!!!!!!!");
        }
    }
}
