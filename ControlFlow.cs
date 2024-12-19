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

        public void whileControl()
        {
            string explanation = """
                                The expression, which follows the while keyword, must be a boolean expression that evaluates to true or false.

                The while statement evaluates the expression first. If the expression evaluates to true, it’ll execute the block inside the curly braces.

                Once completed executing the block, the while statement checks the expression again. And it’ll execute the block again as long as the expression is true.

                If the expression is false, the while statement exits and passes the control to the statement after it.

                Therefore, you need to change some variables inside the block to make the expression false at some point. Otherwise, you’ll have an indefinite loop.

                Since the expression is checked at the beginning of each iteration, the while statement is often called a pretest loop.
                """;
            double number = 0,
            total = 0,
            count = 0,
            average = 0;

            string input = "";


            Console.WriteLine("Enter a list of numbers to calculate the average (Q - quit):");

            while (input != "Q" && input != "q")
            {
                input = Console.ReadLine();
                if (input != "Q" && input != "q")
                {
                    number = Convert.ToDouble(input);
                    total += number;
                    count++;
                }
            }

            if (count > 0)
            {
                average = total / count;
            }

            Console.WriteLine($"Average:{average}");
        }
    }
}
