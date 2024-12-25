// See https://aka.ms/new-console-template for more information


using ConsoleProjectLearing;

// Program.cs

Console.WriteLine("Main method starts.");

Console.WriteLine("Enter a radius:");
var input = Console.ReadLine();
if (input != null)
{
    var radius = double.Parse(input);
    try
    {
        var circle = new ThrowKeyword(radius);
        Console.WriteLine($"The area is {circle.GetArea():F2}");
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
    }

}



Console.WriteLine("Main method ends.");