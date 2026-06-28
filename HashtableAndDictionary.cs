using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class HashtableAndDictionary
    {
        /// <summary>
        /// Hashtable is a non-generic collection that stores key-value pairs and allows for fast retrieval based on keys. 
        /// It is not type-safe and can store any type of objects, which may lead to runtime errors if not used carefully. 
        /// Dictionary<TKey, TValue> is a generic collection that also stores key-value pairs but provides type safety by enforcing 
        /// that all keys and values are of specific types defined by the generic parameters. Dictionary<TKey, TValue> is generally preferred over Hashtable due to its type safety and better performance.
        /// </summary>
        public void RunDemo()
        {
            // Using Hashtable
            System.Collections.Hashtable hashtable = new System.Collections.Hashtable();
            hashtable["key1"] = "value1";
            hashtable["key2"] = 42; // Can store different types
            Console.WriteLine($"Hashtable value for 'key1': {hashtable["key1"]}");
            Console.WriteLine($"Hashtable value for 'key2': {hashtable["key2"]}");
            // Using Dictionary<TKey, TValue>
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary["key1"] = "value1";
            // dictionary["key2"] = 42; // This would cause a compile-time error due to type safety
            Console.WriteLine($"Dictionary value for 'key1': {dictionary["key1"]}");
        }

        public void HashTableVsDictionary()
        {
            // Performance comparison
            System.Collections.Hashtable hashtable = new System.Collections.Hashtable();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            int iterations = 1000000;
            // Populate both collections
            for (int i = 0; i < iterations; i++)
            {
                hashtable[i] = $"Value {i}";
                dictionary[i.ToString()] = $"Value {i}";
            }
            // Measure retrieval time for Hashtable
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                var value = hashtable[i];
            }
            stopwatch.Stop();
            Console.WriteLine($"Hashtable retrieval time: {stopwatch.ElapsedMilliseconds} ms");
            // Measure retrieval time for Dictionary
            stopwatch.Restart();
            for (int i = 0; i < iterations; i++)
            {
                var value = dictionary[i.ToString()];
            }
            stopwatch.Stop();
            Console.WriteLine($"Dictionary retrieval time: {stopwatch.ElapsedMilliseconds} ms"); stopwatch.Restart();
        }

        public void TypeSafetyDemo()
        {
            // Demonstrating type safety with Dictionary
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary["key1"] = 42; // Valid assignment
            // dictionary["key2"] = "value"; // This would cause a compile-time error due to type safety
            Console.WriteLine($"Dictionary value for 'key1': {dictionary["key1"]}");
        }


        public void TypeSafetyDemo2()
        {
            // Demonstrating type safety with Dictionary
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary["key1"] = "value1"; // Valid assignment
            // dictionary["key2"] = 42; // This would cause a compile-time error due to type safety
            Console.WriteLine($"Dictionary value for 'key1': {dictionary["key1"]}");

        }

        public void HashTableExample()
        {
            // Using Hashtable
            System.Collections.Hashtable hashtable = new System.Collections.Hashtable();
            hashtable["key1"] = "value1";
            hashtable["key2"] = 42; // Can store different types
            Console.WriteLine($"Hashtable value for 'key1': {hashtable["key1"]}");
            Console.WriteLine($"Hashtable value for 'key2': {hashtable["key2"]}");
        }
        public void HashTableExample2()
        {
            // Using Hashtable
            System.Collections.Hashtable hashtable = new System.Collections.Hashtable();
            hashtable["key1"] = "value1";
            hashtable["key2"] = 42; // Can store different types
            Console.WriteLine($"Hashtable value for 'key1': {hashtable["key1"]}");
            Console.WriteLine($"Hashtable value for 'key2': {hashtable["key2"]}");
        }

        public void DictionaryExample()
        {
            // Using Dictionary<TKey, TValue>
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary["key1"] = "value1";
            // dictionary["key2"] = 42; // This would cause a compile-time error due to type safety
            Console.WriteLine($"Dictionary value for 'key1': {dictionary["key1"]}");
        }
        public void DictionaryExample2()
        {
            // Using Dictionary<TKey, TValue>
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary["key1"] = "value1";
            // dictionary["key2"] = 42; // This would cause a compile-time error due to type safety
            Console.WriteLine($"Dictionary value for 'key1': {dictionary["key1"]}");
            Console.WriteLine($"Dictionary value for 'key2': {dictionary["key2"]}");


        }

        /// <summary>
        /// Hashtable is a non-generic collection that stores data as key-value pairs using a hash table. It provides fast lookup, insertion, and deletion operations. Since it stores data as objects, it involves boxing and unboxing and is generally replaced by Dictionary<TKey,TValue> in modern .NET applications.
        /// Dictionary<TKey, TValue> is a generic collection that stores data as key-value pairs. It uses a hash table internally, which provides very fast lookup, insertion, and deletion operations, typically in O(1) time complexity. Keys must be unique.
        /// </summary>
        
    }
}
