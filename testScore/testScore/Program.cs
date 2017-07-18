using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            int lowscore = 0;
            int highscore = 100;

            Console.WriteLine("Enter a valid test score.");
            string num = Console.ReadLine();
            int.TryParse(num, out score);

            while(score < lowscore || score > highscore)
            {
                Console.WriteLine($"A score of {num} is not valid. \n" + $"A vaild score is between {lowscore} and {highscore}. \n" + $"Please enter a vaild score.");

                num = Console.ReadLine();
                int.TryParse(num, out score);
            }
            Console.WriteLine("Vaild score entered!");
            Console.ReadLine();
        }
    }
}
