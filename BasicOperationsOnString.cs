using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    internal class BasicOperationsOnString
    {
        public void ExampleOnString()
        {
            string text = " Welcome to C# Programming ";

            // Basic Operations
            Console.WriteLine("Original: " + text);
            Console.WriteLine("TengthOfText: " + text.Length);
            Console.WriteLine("Trimmed: " + text.Trim());
            Console.WriteLine("Uppercase: " + text.ToUpper());
            Console.WriteLine("Substring: " + text.Substring(11, 2));

            // Search
            Console.WriteLine("Contains 'C#': " + text.Contains("C#"));
            Console.WriteLine("Index of 'C': " + text.IndexOf('C'));

            // Replace and Split
            string replaced = text.Replace("C#", "DotNet");
            Console.WriteLine("Replaced: " + replaced);

            string[] words = replaced.Split(' ');
            Console.WriteLine("Words: " + string.Join(", ", words));

            // String Interpolation
            string name = "John";
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
