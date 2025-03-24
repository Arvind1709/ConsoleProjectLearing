using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class ExceptionExamples : Exception
    {
        public string devideByZero()
        {
           // try
            //{
                int a = 10;
                int b = 0;
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    int c = a / b;
                }
            //}
            //catch (DivideByZeroException ex)
            //{
            //    return ex.Message;
            //    Console.WriteLine("Divide by zero exception");
            //}
            //catch (Exception ex)
            //{
            //    return ex.Message;
            //    Console.WriteLine("General exception");
            //}
            //finally
            //{
            //    Console.WriteLine("Finally block");
            //}
            return "End of method";
        }
    }
}
