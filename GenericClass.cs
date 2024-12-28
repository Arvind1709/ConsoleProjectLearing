using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    internal class GenericClass
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //public static void Main(string[] args)
        //{
        //    // swap integers
        //    int x = 10, y = 20;

        //    Console.WriteLine($"Before swapping: x={x},y={y}");
        //    Swap(ref x, ref y);
        //    Console.WriteLine($"After swapping: x={x},y={y}");

        //    // swap strings

        //    string s1 = "hello", s2 = "goodbye";

        //    Console.WriteLine($"Before swapping: s1={s1},s2={s2}");
        //    Swap(ref s1, ref s2);
        //    Console.WriteLine($"After swapping: s1={s1},s2={s2}");
        //}
    }
}

