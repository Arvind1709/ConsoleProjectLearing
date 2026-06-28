// See https://aka.ms/new-console-template for more information


//using ConsoleProjectLearing;
//using ConsoleProjectLearing.AppDbContext;
//using ConsoleProjectLearning;
//// Program.cs

using ConsoleProjectLearing;

Console.WriteLine("Main method starts.");
try
{
    HashtableAndDictionary hashtableAndDictionary = new HashtableAndDictionary();
    hashtableAndDictionary.RunDemo();
    hashtableAndDictionary.HashTableVsDictionary();
    hashtableAndDictionary.TypeSafetyDemo();
    hashtableAndDictionary.TypeSafetyDemo2();
    hashtableAndDictionary.HashTableExample();
    hashtableAndDictionary.HashTableExample2();
    hashtableAndDictionary.DictionaryExample();
    hashtableAndDictionary.DictionaryExample2();
}
catch (Exception ex)
{
    Console.WriteLine("General exception");
}

Console.WriteLine("Main method ends.");




// Run the application
//app.Run();

//public class Program
//{
//    public static async Task Main(string[] args)
//    {
//        Console.WriteLine("Main method starts.");

//        try
//        {
//            TaskAwaitAsync taskAwaitAsync = new TaskAwaitAsync();
//            await taskAwaitAsync.HaveDinnerAsync();  // Await the async call
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("General exception");
//        }

//        Console.WriteLine("Main method ends.");
//    }
//}
