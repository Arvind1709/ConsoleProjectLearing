using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Buffers.Text;
using System.Drawing;

namespace ConsoleProjectLearing
{
    public class Array
    {
        //int[] scores = { 3, 2, 5, 4, 1 };

        public void ExampleOfArray()
        {
            string Expalaniton = """
                An array stores a fixed number of elements of the same type.
                To declare an array variable, you use square brackets[] after the element’s type like (type[] arrayName);
                An array is zero - based indexing
                The Length property returns the size of an array.
                """;
            int[] variableInt = { 1, 2, 3 };
            string[] variableString = { "Arvind","Yadav","Krishna"};
            int[] scores = new int[5] { 3, 2, 5, 4, 1 };

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(  $"Score is : {scores[i]}");
               
            }
        }

        public void ExampleOfRangeInArray()
        {
            // Sales figures for a week
            int[] weeklySales = { 150, 200, 250, 300, 350, 400, 450 };

            // 1. Get weekend sales (last two days)
            int[] weekendSales = weeklySales[^2..];
            Console.WriteLine("Weekend Sales: " + string.Join(", ", weekendSales)); // Output: 400, 450

            // 2. Get weekday sales (first five days)
            int[] weekdaySales = weeklySales[..5];
            Console.WriteLine("Weekday Sales: " + string.Join(", ", weekdaySales)); // Output: 150, 200, 250, 300, 350
            // From index 2 to the end
            int[] weekdaySales1 = weeklySales[2..];
            Console.WriteLine("Weekday Sales1: " + string.Join(", ", weekdaySales1)); // Output: 250, 300, 350, 400, 450

            // 3. Get midweek sales (Tuesday to Thursday, index 1 to 3)
            int[] midweekSales = weeklySales[1..4];
            Console.WriteLine("Midweek Sales: " + string.Join(", ", midweekSales)); // Output: 200, 250, 300

            // 4. Extract the highest sale (last element)
            int highestSale = weeklySales[^1];
            Console.WriteLine("Highest Sale: " + highestSale); // Output: 450
        }
    }
}
