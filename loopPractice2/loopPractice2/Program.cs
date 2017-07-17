using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "Dog", "Cat", "Fox", "Bird", "Duck" };
          
            for (int a = 0; a < animals.Length; ++a)
            {
                Console.WriteLine("I saw a " + (animals[a]) + " in the park");
            }
            Console.ReadLine();

            int[] nums = new int[4];
            nums[0] = 10;
            nums[1] = 20;
            nums[2] = 30;
            nums[3] = 40;

            for (int n = 0; n < nums.Length; ++n)
            {
                Console.WriteLine("The values of the array nums is " + (nums[n]));
            }
            Console.ReadLine();

            char[] letters = { 'v', 'i', 'n', 'c', 'e' };
            //use ' when using a char (or one single letter)
            for(int m = 0; m < letters.Length; ++m)
            {
                Console.WriteLine("The values of the letters array are "+ (letters[m]));
            }
            Console.ReadLine();

            for (int m = 0; m < letters.Length; ++m)

            { 
                Console.Write((letters[m]));
            }
            Console.ReadLine();

        }

        
    }
}
