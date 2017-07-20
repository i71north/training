using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice1
{
    class Resturants
    {
        public static void FamousDaves()
        {
            Fashion fash = new Fashion();
            Resturants r = new Resturants();
            
            fash.Pants();
            fash.Shirts();
            r.Chipotle();
            
        }
        public void Chipotle()

        {
            Console.WriteLine("We make buritos");
        }
        public void Benihana()
        {
            Console.WriteLine("We cook the food right in front of you!");
        }
    }
}
