namespace ConsoleProjectLearing
{
    internal abstract class ShapeAbstractClass
    {
        // Abstract method: Must be implemented by derived classes
        public abstract double CalculateArea();

        // Concrete method: Common behavior for all shapes
        public void DisplayArea()
        {
            double area = CalculateArea();
            Console.WriteLine($"The area of the {this.GetType().Name} is {area}");
        }
    }
    class Circle1 : ShapeAbstractClass
    {
        public double Radius { get; set; }

        public Circle1(double radius)
        {
            Radius = radius;
        }

        // Implementation of the abstract method
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle1 : ShapeAbstractClass
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle1(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implementation of the abstract method
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
