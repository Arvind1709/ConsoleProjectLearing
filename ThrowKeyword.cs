using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleProjectLearing
{
    public class ThrowKeyword
    {
        public double Radius
        {
            get; set;
        }
        public ThrowKeyword(double radius)
        {
            if (radius <= 0)
            {
                //throw new ArgumentOutOfRangeException(
                //     nameof(radius),
                //    "The radius should be positive"
                // );
                throw new ArgumentException("","radius");         
            }
            Radius = radius;
        }
        public double GetArea() => Math.PI * Radius * Radius;

    }

    //Console.WriteLine("Enter a radius:");
    //var input = Console.ReadLine();
    //if (input != null)
    //{
    //var radius = double.Parse(input);
    //try
    //{
    //    var circle = new ThrowKeyword(radius);
    //Console.WriteLine($"The area is {circle.GetArea():F2}");
    //}
    //catch (ArgumentOutOfRangeException ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}

    //}

}

