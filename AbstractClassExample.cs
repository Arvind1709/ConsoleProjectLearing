namespace ConsoleProjectLearing
{
    internal abstract class AbstractClassExample
    {

        public string Model { get; set; }

        public AbstractClassExample(string model)
        {
            Model = model;
            Console.WriteLine("Vehicle constructor called");
        }

        // Abstract method (must be implemented)
        public abstract void Start();

        // Concrete method (already has body)
        public void DisplayInfo()
        {
            Console.WriteLine("This is a vehicle.");
        }
    }
    class EcoSports : AbstractClassExample
    {
        public string Brand { get; set; }
        //public string Model { get; set; }
        public EcoSports(string brand, string model) : base(model)
        {
            Console.WriteLine("EcoSports constructor called");
            Brand = brand;

        }

        public override void Start()
        {
            Console.WriteLine($"{Model} car is starting...Model");
            Console.WriteLine($"{Brand} car is starting...Brand");
        }
    }
}
