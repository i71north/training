using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Resturants r = new Resturants();
            Fashion f = new Fashion();



            Console.WriteLine("This is the main methodlanding page.");

            r.Chipotle();
            Console.ReadLine();

            f.Pants();


            Console.ReadLine();
        }


        public static void Addition()
        {



        }

        public static void Multiplication()
        {


        }

            
    }

    class Fashion
    {
        public void Shirts()
        {
            Console.WriteLine("Buttonups");
            Console.WriteLine("V Neck");
            Console.WriteLine("Henleys");
        }

        public void Pants()
        
{
            
Console.WriteLine("Bellbottoms");
            Console.WriteLine("Sweats");
            Console.WriteLine("Petalpushers");

        }

        public void Shoes()
        {


        }

        

    }


}
