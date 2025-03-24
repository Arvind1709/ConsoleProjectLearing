// See https://aka.ms/new-console-template for more information


using ConsoleProjectLearing;

// Program.cs

Console.WriteLine("Main method starts.");

//string name = null;
//string result = name ?? "Default Name";
//Console.WriteLine(result); // Output: Default Name

//string name1 = "Arvind";
//string result1 = name1 ?? "Default Name";
//Console.WriteLine(result1); // Output: Default Name

try
{
    ExceptionExamples exceptionExamples = new ExceptionExamples();
    string result = exceptionExamples.devideByZero();
    Console.WriteLine(result);
}
catch (Exception ex)
{
    Console.WriteLine("General exception");

}

    Console.WriteLine("Main method ends.");