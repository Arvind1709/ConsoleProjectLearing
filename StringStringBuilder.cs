using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class StringStringBuilder
    {
        public void StringVsStringBuilder()
        {
            string str = "Hello";
            str += " World"; // This creates a new string object
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" World"); // This modifies the existing StringBuilder object
            Console.WriteLine(str); // Output: Hello World
            Console.WriteLine(sb.ToString()); // Output: Hello World
        }

        public void StringBuilderExample()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("World");
            Console.WriteLine(sb.ToString()); // Output: Hello World
        }
        public void StringBuilderPerformance()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                sb.Append(i).Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }


        public void StringExample()
        {
            string str = "Hello";
            for (int i = 0; i < 1000; i++)
            {
                str += i + " "; // This creates a new string object each time
            }
            Console.WriteLine(str);
        }

    }

}
