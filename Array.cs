namespace ConsoleProjectLearing
{
    public class Array1
    {
        //int[] scores = { 3, 2, 5, 4, 1 };

        public void ExampleOfArray()
        {
            string Expalaniton = """
                An array stores a fixed number of elements of the same type.
                To declare an array variable, you use square brackets[] after the element’s type like (type[] arrayName);
                An array is zero - based indexing
                The Length property returns the size of an array.
                """;
            int[] variableInt = { 1, 2, 3 };
            string[] variableString = { "Arvind", "Yadav", "Krishna" };
            int[] scores = new int[5] { 3, 2, 5, 4, 1 };

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"Score is : {scores[i]}");

            }
        }

        public void ExampleOfRangeInArray()
        {
            // Sales figures for a week
            int[] weeklySales = { 150, 200, 250, 300, 350, 400, 450 };

            // 1. Get weekend sales (last two days)
            int[] weekendSales = weeklySales[^2..];
            Console.WriteLine("Weekend Sales: " + string.Join(", ", weekendSales)); // Output: 400, 450

            // 2. Get weekday sales (first five days)
            int[] weekdaySales = weeklySales[..5];
            Console.WriteLine("Weekday Sales: " + string.Join(", ", weekdaySales)); // Output: 150, 200, 250, 300, 350
            // From index 2 to the end
            int[] weekdaySales1 = weeklySales[2..];
            Console.WriteLine("Weekday Sales1: " + string.Join(", ", weekdaySales1)); // Output: 250, 300, 350, 400, 450

            // 3. Get midweek sales (Tuesday to Thursday, index 1 to 3)
            int[] midweekSales = weeklySales[1..4];
            Console.WriteLine("Midweek Sales: " + string.Join(", ", midweekSales)); // Output: 200, 250, 300

            // 4. Extract the highest sale (last element)
            int highestSale = weeklySales[^1];
            Console.WriteLine("Highest Sale: " + highestSale); // Output: 450
        }

        public void EvenAndOddNumbersInArray()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int countEven = 0;
            int countOdd = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    countEven += 1;
                }
                else
                {
                    countOdd += 1;
                }
            }
            Console.WriteLine("Count of Even is " + countEven);
            Console.WriteLine("Count of Odd is " + countOdd);
        }

        public void ReverseArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] reversArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                reversArray[i] = numbers[numbers.Length - 1 - i];
            }

            foreach (var item in reversArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
