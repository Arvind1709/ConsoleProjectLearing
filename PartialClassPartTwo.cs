using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public partial class MyClass
    {
        public void Method2()
        {
            Console.WriteLine("This is Method2.");
        }
    }

    public partial class Person
    {
        public int Age { get; set; }

        public void DisplayAge()
        {
            Console.WriteLine($"Age: {Age}");
        }
    }

    //Person person = new Person
    //{
    //    FirstName = "John",
    //    LastName = "Doe",
    //    Age = 30
    //};

    //person.DisplayFullName(); // Output: Full Name: John Doe
    //person.DisplayAge();
}
