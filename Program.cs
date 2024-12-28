// See https://aka.ms/new-console-template for more information


using ConsoleProjectLearing;

// Program.cs

Console.WriteLine("Main method starts.");

// swap integers
int x = 10, y = 20;

Console.WriteLine($"Before swapping: x={x},y={y}");
GenericClass.Swap(ref x, ref y);
Console.WriteLine($"After swapping: x={x},y={y}");

// swap strings

string s1 = "hello", s2 = "goodbye";

Console.WriteLine($"Before swapping: s1={s1},s2={s2}");
GenericClass.Swap(ref s1, ref s2);
Console.WriteLine($"After swapping: s1={s1},s2={s2}");


Console.WriteLine("Main method ends.");