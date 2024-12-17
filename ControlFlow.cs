using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class ControlFlow
    {
        public void ifElseControlFlow()
        {
            string explanation = """
                In this syntax, the if else statement evaluates the condition. If the condition is true, it’ll execute the if block. Otherwise, the if else statement executes the else block.
                """;
            int number = 10;

            if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine("The number is zero.");
            }
            else
            {
                Console.WriteLine("The number is positive.");
            }
        }

        public void ifElseIfControlFlow()
        {
            string explanation = """
                                The if else if statement can have multiple else if clause where each clause has a condition.
                The if else if statement checks the condition1, condition2, … from top to bottom sequentially. If a condition is true, the corresponding block executes. The statement will stop evaluating the remaining conditions.
                If no condition is true, the block in the else clause executes. The else clause is optional.
                """;
            string dayName;
            int day = 5;
            if (day == 1)
            {
                dayName = "Sunday";
            }
            else if (day == 2)
            {
                dayName = "Monday";
            }
            else if (day == 3)
            {
                dayName = "Tuesday";
            }
            else if (day == 4)
            {
                dayName = "Wednesday";
            }
            else if (day == 5)
            {
                dayName = "Thursday";
            }
            else if (day == 6)
            {
                dayName = "Friday";
            }
            else if (day == 7)
            {
                dayName = "Saturday";
            }
            else
            {
                dayName = "Unknown";
            }
            Console.WriteLine($"Today is {dayName}");
        }

        public void switchCaseOne()
        {
            string color = "red";

            switch (color.ToLower())
            {
                case "red":
                    Console.WriteLine("You selected Red.");
                    break;
                case "blue":
                    Console.WriteLine("You selected Blue.");
                    break;
                case "green":
                    Console.WriteLine("You selected Green.");
                    break;
                default:
                    Console.WriteLine("Color not recognized.");
                    break;
            }
        }
        public void switchCaseTwo()
        {
            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Weekend");
                    break;
            }
        }
        public void switchCaseThree()
        {
            int number = 2;

            string result = number switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "Other"
            };

            Console.WriteLine(result);
        }
    }
}
