using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    internal class parameterModifiersRefOut
    {
        string parameterModifiers = """
            In C#, ref and out are parameter modifiers used to pass arguments by reference to a method, allowing the method to modify the value of the parameter.
            """;
        string refValue = """
                        The ref keyword allows a parameter to be passed by reference. The value must be initialized before it is passed to the method.

            Key Points:
            The parameter must be initialized before being passed to the method.
            The method can modify the value, and the changes will be reflected outside the method.
            """; // Initialized
        string outValue = """
                        The out keyword allows a parameter to be passed by reference, but unlike ref, the parameter does not need to be initialized before being passed. The method is required to assign a value to the out parameter before it returns.

            Key Points:
            The parameter does not need to be initialized before being passed.
            The method must assign a value to the out parameter.
            """;     // Uninitialized
        public static void ModifyValues(ref int refValue, out int outValue)
        {
            refValue += 10; // Modify existing value
            outValue = 100; // Assign new value
        }

        //static void Main()
        //{
        //    int refValue = 20; // Initialized
        //    int outValue;      // Uninitialized

        //    ModifyValues(ref refValue, out outValue);

        //    Console.WriteLine($"Ref Value: {refValue}"); // Output: 30
        //    Console.WriteLine($"Out Value: {outValue}"); // Output: 100
        //}
    }
}
