using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class Objectinitializer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }

        public Objectinitializer()
        {
        }
        
        private static Random random;

        static Objectinitializer()
        {
            random = new Random();
        }
        public int Get() => random.Next();
       

        public Objectinitializer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
