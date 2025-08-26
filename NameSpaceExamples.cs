

namespace ConsoleProjectLearing
{
    public class NameSpaceExamples
    {
        public void ExampleSystem()
        {
            Console.WriteLine("Hello System NameSpace");
            int num = 16;
            Console.WriteLine($"Squre root of {num} is : {Math.Sqrt(num)}");
            Console.WriteLine("End Of System Name Space");
        }
        public void ExampleLinq()
        {
            Console.WriteLine("Hello Linq NameSpace");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            evenNumbers.ForEach(Console.WriteLine);
            Console.WriteLine("End Of Linq Name Space");
        }
    }
}
