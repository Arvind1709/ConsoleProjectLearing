using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class InheritanceAndConstructor
    {
        // Person.cs
       
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public byte Age { get; set; }

            public string FullName => $"{FirstName} {LastName}";

            public InheritanceAndConstructor(string firstName, string lastName, byte age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

        public virtual void  Introduce()
        {
            Console.WriteLine($"Hi, I'm InheritanceAndConstructor {FullName}.");
        }

        

      
    }

    // Employee.cs
    class EmployeeInheritanceAndConstructor : InheritanceAndConstructor
    {
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }

        public EmployeeInheritanceAndConstructor(string firstName, string lastName, byte age, string jobTitle, decimal salary)
            : base(firstName, lastName, age)
        {
            JobTitle = jobTitle;
            Salary = salary;
        }

        public void GetDisplay()
        {
            Console.WriteLine($"{FirstName},{LastName},{Age},{JobTitle}{Salary}");
        }

        public override void Introduce()
        {
            int amount = 100;
            int qty = 0;

            try
            {
                int result = amount / qty;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("The program was terminated due to an error.");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Source: {e.Source}");
                Console.WriteLine($"Stack: {e.StackTrace}");
            }

            Console.WriteLine("Bye!");

            Console.WriteLine($"Hi, I'm Employee {FullName}. I work as {JobTitle}");
        }
    }
}
