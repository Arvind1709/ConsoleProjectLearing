using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class ConstantAsConverter
    {
        public const decimal Factor = 2.205m;

        public decimal KgToPound(decimal weight)
        {
            return weight * Factor;
        }

        public decimal PoundToKg(decimal weight)
        {
            return weight / Factor;
        }
    }

      // Program.cs

      //decimal weightInKg, weightInLbs;
      
      //        var converter = new Converter();
      
      //Console.WriteLine($"Convert weight from kg to lbs (factor = {Converter.Factor})");
      
      //while(true)
      //{
      //    // Prompt to enter a weight in Kg:
      //    Console.Write("Enter a weight in Kg (0 to exit):");
      //    weightInKg = Convert.ToDecimal(Console.ReadLine());
          
      //    if(weightInKg == 0)
      //    {
      //        break;
      //    }
      
      //// convert weight from kg to lbs
      //weightInLbs = converter.KgToPound(weightInKg);
      //Console.WriteLine($"{weightInKg}kg = {weightInLbs}lbs");
      //}
      
}
