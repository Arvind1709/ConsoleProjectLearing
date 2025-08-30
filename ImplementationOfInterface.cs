namespace ConsoleProjectLearing
{
    internal class ImplementationOfInterface : IVehicle
    {
        // Properties
        public string Name { get; set; }
        public string Model { get; set; }  // <- Implementing the property

        public void Start()
        {
            Console.WriteLine($"{Model} is starting...");
        }
    }

}
