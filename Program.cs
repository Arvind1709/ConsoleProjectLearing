// See https://aka.ms/new-console-template for more information


using ConsoleProjectLearing;

Console.WriteLine($"Square of any number is : {StaticMathHelper.Square(2)}");
Console.WriteLine(StaticMathHelper.ApplicationName);

Console.WriteLine(StaticMathHelper.MaxUsers);  // Output: 100
StaticMathHelper.MaxUsers = 200;
Console.WriteLine(StaticMathHelper.MaxUsers);  // Output: 200

StaticMathHelper.Log("Application started");

StaticMathHelper.OnNotify += (msg) => Console.WriteLine($"Notification: {msg}");
StaticMathHelper.Notify("New update available!");  // Output: Notification: New update available!
Console.WriteLine("Arvind");