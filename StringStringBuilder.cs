using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class StringStringBuilder
    {
        /// <summary>
        /// string in c# is immutable, meaning every modification creates a new object in heap memory.
        ///string builder is mutable and modifies the same internal buffer without creating multiple objects.
        ///Therefore, StringBuilder is more efficient for frequent string manipulations such as loops, dynamic text generation, or large concatenations.
        /// </summary>

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

        /// <summary>
        /// The key distinction between String and StringBuilder lies in immutability semantics and allocation behavior. 
        ///Strings leverage immutability for thread safety, interning, and stable hashing, but repeated concatenations generate 
        ///excessive heap allocations and GC pressure. StringBuilder internally manages a resizable character buffer, significantly 
        ///reducing allocation overhead during high-frequency text mutations, making it preferable for performance-sensitive 
        ///workloads such as serialization, logging, and dynamic content generation.
        /// </summary>

    }

}
