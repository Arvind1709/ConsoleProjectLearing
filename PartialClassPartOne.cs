using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public partial class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("This is Method1.");
        }
    }

    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
    }

}
