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

        public void ExampleOfStringList()
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date" };

            // Add elements
            fruits.Add("Elderberry");
            fruits.AddRange(new string[] { "Fig", "Grape" });

            // Remove an element
            fruits.Remove("Banana");

            // Sort and reverse
            fruits.Sort();
            fruits.Reverse();

            // Find an element
            string firstStartingWithC = fruits.Find(f => f.StartsWith("C"));

            // Display elements
            Console.WriteLine("Fruits in the list:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Count elements
            Console.WriteLine($"Total fruits: {fruits.Count}");
        }
        public void ExampleOfRawString()
        {
                    string jsonData = """
                {
                    "name": "John Doe",
                    "age": 35,
                    "skills": ["C#", "SQL", "JavaScript"]
                }
                """;

            Console.WriteLine("JSON Data:");
            Console.WriteLine(jsonData);

                    string sqlQuery = """
                SELECT *
                FROM Employees
                WHERE Department = "IT" AND Status = "Active";
                """;

            Console.WriteLine("\nSQL Query:");
            Console.WriteLine(sqlQuery);
        }

        public void ExampleOfStringBuilder()
        {
            string DefinationReadIt = """
                The StringBuilder class in C# is part of the System.
                Text namespace and is used to efficiently manipulate strings when 
                frequent modifications are required. Unlike the String class, 
                which creates a new object in memory for each modification 
                (since strings are immutable), StringBuilder modifies the existing 
                memory buffer, making it more performance-efficient for scenarios 
                involving numerous string manipulations.
                """;

            StringBuilder sb = new StringBuilder("Learning C# is fun!");

            // Append text
            sb.Append(" Let's master StringBuilder.");
            Console.WriteLine("After Append: " + sb);

            // Insert text
            sb.Insert(18, "very ");
            Console.WriteLine("After Insert: " + sb);

            // Replace text
            sb.Replace("fun", "exciting");
            Console.WriteLine("After Replace: " + sb);

            // Remove text
            sb.Remove(0, 9);
            Console.WriteLine("After Remove: " + sb);

            // Clear the builder
            sb.Clear();
            Console.WriteLine("After Clear: " + sb.Length); // Output: 0
        }
    }
}
