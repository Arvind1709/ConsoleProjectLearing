using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class AbstractClass
    {

    }

    abstract class AnimalAbst
    {
        // Abstract method (no implementation)
        public abstract void MakeSound();

        // Non-abstract method
        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }
    }

    class DogAbst : AnimalAbst
    {
        // Overriding the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    abstract class Shape
    {
        public abstract double Area { get; } // Abstract property
        public string Color { get; set; }   // Regular property
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            Color = "Red"; // Setting a property from the abstract class
        }

        public override double Area
        {
            get { return Math.PI * Radius * Radius; }
        }
    }


    abstract class Vehicle
    {
        public abstract void Start();
        public abstract void Stop();
    }

    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting...");
        }

        public override void Stop()
        {
            Console.WriteLine("Car is stopping...");
        }
    }

    class SportsCar : Car
    {
        public void TurboBoost()
        {
            Console.WriteLine("SportsCar is using turbo boost!");
        }
    }


    //Dog dog = new Dog();
    //dog.MakeSound(); // Output: Dog barks.
    //dog.Sleep(); 
}
