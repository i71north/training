using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternaryPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite sport");
            string sport = Console.ReadLine().ToLower();

            string favSport = (sport == "hockey" || sport == "football" || sport == "golf") ? "Great Choice" : "Bad Choice";

            Console.WriteLine(favSport);
            Console.ReadLine();
        }
    }
}
