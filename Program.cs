// See https://aka.ms/new-console-template for more information


using ConsoleProjectLearing;

DefaultParameter defaultParameter = new DefaultParameter();

var netPrice = defaultParameter.calculatePrice(100);

Console.WriteLine($"The net price is {netPrice:0.##}");