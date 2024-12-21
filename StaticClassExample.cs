using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public static class StaticMathHelper
    {
        
        #region Fields
        public static string ApplicationName = "MyApp";
        public static int MaxUsers = 100;
        #endregion

        #region Properties
        private static int _maxUser = 100;

        public static int MaxUser
        {
            get { return _maxUser; }
            set
            {
                if (value > 0) _maxUser = value;
            }
        }
        #endregion

        #region Static Constructors
        public static string DefaultLogLevel { get; private set; }

        static StaticMathHelper()
        {
            DefaultLogLevel = "INFO"; // Initialize static fields.
        }

        public static void Log(string message)
        {
            Console.WriteLine($"[{DefaultLogLevel}] {message}");
        }
        #endregion

        #region Static Events
        public static event Action<string> OnNotify;

        public static void Notify(string message)
        {
            OnNotify?.Invoke(message);
        }
        #endregion

        // Static method to calculate the square of a number
        public static int Square(int number)
        {
            return number * number;
        }

        // Static method to calculate the factorial of a number
        public static int Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        // Static field for Pi value
        public static readonly double Pi = 3.14159;

        // Static property to calculate Circle Area
        public static double CircleArea(double radius)
        {
            return Pi * radius * radius;
        }
    }

        //Console.WriteLine($"Square of any number is : {StaticMathHelper.Square(2)}");
        //Console.WriteLine(StaticMathHelper.ApplicationName);
        //
        //Console.WriteLine(StaticMathHelper.MaxUsers);  // Output: 100
        //StaticMathHelper.MaxUsers = 200;
        //Console.WriteLine(StaticMathHelper.MaxUsers);  // Output: 200
        //
        //StaticMathHelper.Log("Application started");
        //
        //StaticMathHelper.OnNotify += (msg) => Console.WriteLine($"Notification: {msg}");
        //StaticMathHelper.Notify("New update available!");  // Output: Notification: New update available!

}

