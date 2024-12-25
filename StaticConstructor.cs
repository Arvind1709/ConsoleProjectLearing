using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    internal class StaticConstructor
    {
        public static int StaticValue;

        // Static constructor
        static StaticConstructor()
        {
            Console.WriteLine("Static constructor called.");
            StaticValue = 42; // Initialize static field
        }

        // Instance constructor
        public StaticConstructor()
        {
            Console.WriteLine("Instance constructor called.");
        }

        public static void DisplayValue()
        {
            Console.WriteLine($"StaticValue: {StaticValue}");
        }


        //Console.WriteLine("Main method starts.");

        //// Accessing static member
        //StaticConstructor.DisplayValue();

        //// Creating an instance of StaticConstructor
        //StaticConstructor obj = new StaticConstructor();

        //Console.WriteLine("Main method ends.");
    }
}
