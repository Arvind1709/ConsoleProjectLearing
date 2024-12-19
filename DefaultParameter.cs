using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class DefaultParameter
    {
        public double calculatePrice(double sellingPrice, double salesTax = 0.08)
        {
            return sellingPrice * (1 + salesTax);
        }

        //var netPrice = calculatePrice(100);

        //Console.WriteLine($"The net price is {netPrice:0.##}");
    }
}
