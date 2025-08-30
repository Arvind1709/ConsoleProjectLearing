namespace ConsoleProjectLearing
{
    internal interface IVehicle
    {
        // Properties
        string Model { get; set; }  // <- Property added here
        // Methods
        void Start();
    }
}
