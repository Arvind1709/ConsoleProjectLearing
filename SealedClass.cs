using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public sealed class SealedClass
    {
        #region

        #endregion

        public void Display()
        {
            Console.WriteLine("This is a Vehicle.");
        }
    }
    
    #region Sealed Class in Inheritance
    public class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    public sealed class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks.");
        }
    }
    #endregion

    #region Using a Sealed Method
    class Animals
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dogs : Animal
    {
        public sealed override void Sound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Puppy : Dogs
    {
        // The following will cause a compile-time error because Sound() is sealed in Dog:
        // public override void Sound() { }
    }
    #endregion


}
