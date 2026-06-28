using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    internal class TestOfCopilet
    {
        public void calculater()
        {
            int a = 10;
            int b = 20;

            int sum = a + b;
            int diff = b - a;
            int prod = a * b;
            double div = (double)b / a;
            int mod = b % a;
            int avg = (a + b) / 2;

            Console.WriteLine($"The sum of a and b is: {sum}");
            Console.WriteLine($"The difference (b - a) is: {diff}");
            Console.WriteLine($"The product of a and b is: {prod}");
            Console.WriteLine($"The division (b / a) is: {div}");
            Console.WriteLine($"The modulus (b % a) is: {mod}");
            Console.WriteLine($"The average of a and b is: {avg}");
        }
    }

}

