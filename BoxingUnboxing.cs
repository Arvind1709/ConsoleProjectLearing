using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class BoxingUnboxing
    {
        /// <summary>
        /// Boxing is the process of converting a value type into a reference type by storing the value inside a heap-allocated 
        ///object. Unboxing extracts the value type back from the object and requires explicit casting. Boxing and unboxing 
        ///introduce performance overhead due to heap allocation and garbage collection, so generics are preferred to avoid them
        /// </summary>


        public void RunDemo()
        {
            // Boxing: Converting a value type to an object type
            int value = 42;
            object boxedValue = value; // Boxing occurs here
            Console.WriteLine($"Boxed value: {boxedValue}");
            // Unboxing: Converting an object type back to a value type
            int unboxedValue = (int)boxedValue; // Unboxing occurs here
            Console.WriteLine($"Unboxed value: {unboxedValue}");
        }
    }
}
