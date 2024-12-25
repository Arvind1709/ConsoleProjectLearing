using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class Initkeyword
    {
        public string Name { get; init; } = string.Empty;
        public sbyte Age { get; init; } = 1;

        string Explanation = """
            Use the init keyword to define an accessor method in a property or indexer that assigns a value to the property or 
            indexer element only during object initialization.
            """;

    }
    //var person = new Initkeyword()
    //{
    //    Name = "John",
    //    Age = 22
    //};
    //person.Name = "Jane"; // error
}
