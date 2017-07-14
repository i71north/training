using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum2
{ enum PizzaToppings
    { Mushrooms = 1,
        Red_Peppers,
        Pepperoni
    }
    enum Weekend
    { Wash_Car = 1,
        Clean_House,
        Shopping
    }
    class Program
    {
        static void Main(string[] args)
        {
            int PTop;
            Console.WriteLine("What do you like on your pizza? \n 1. Mushroom \n 2. Red Peppers \n 3. Pepperoni");
            string topping = Console.ReadLine();
            int.TryParse(topping, out PTop);

            switch ((PizzaToppings)PTop)
            {
                case PizzaToppings.Mushrooms:
                    Marcos();
                    break;

                case PizzaToppings.Red_Peppers:
                    PapaJohns();
                    break;

                case PizzaToppings.Pepperoni:
                    LittleCeasers();
                    break;
            }
            Console.WriteLine("Out!");
            Console.ReadLine();

            int freetime;
            Console.WriteLine("What will you do with your free time this weekend? \n 1. Wash car \n 2. Clean House \n 3. Shopping");

            string activity = Console.ReadLine();
            int.TryParse(activity, out freetime);

            switch ((Weekend)freetime)
            {
                case Weekend.Wash_Car:
                    Wash();
                    break;

                case Weekend.Clean_House:
                    Scrub();
                    break;

                case Weekend.Shopping:
                    Food();
                    break;
            }
            Console.WriteLine("Out!");
            Console.ReadLine();
        }


        public static void Marcos()
        {
            Console.WriteLine("Mushrooms on pizza is the best!");
        }

        public static void PapaJohns()
        {
            Console.WriteLine("Red Peppers are even better when roasted!");
        }
        public static void LittleCeasers()
        {
            Console.WriteLine("Pepperoni is classic and always a safe choice.");
        }

        public static void Wash()
        {
            Console.WriteLine("Washing your own car will save you money.");
        }

        public static void Scrub()
        {
            Console.WriteLine("You never know who may stop by, so be prepared.");
        }
        public static void Food()
        {
            Console.WriteLine("It's good to keep food in the house.");
        }











    }        
}
