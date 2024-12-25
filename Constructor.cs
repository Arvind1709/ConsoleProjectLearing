using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    // Person.cs

    class ConstructorPerson
    {
        private string firstName;
        private string lastName;
        private byte age;

        public ConstructorPerson(string firstName, string lastName, byte age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public ConstructorPerson()
        {
        }

        public ConstructorPerson(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        public string GetFullName()
        {
            return $"{this.firstName} {this.lastName}";
        }
    }
}
