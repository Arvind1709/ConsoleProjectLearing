using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Update;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleProjectLearing
{
    public class ExceptionExamples : Exception
    {
        public string devideByZero()
        {
            try
            {
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
            }
            catch (DivideByZeroException ex)
            {
                return ex.Message;
                Console.WriteLine("Divide by zero exception");
            }
            catch (Exception ex)
            {
                return ex.Message;
                Console.WriteLine("General exception");
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
            return "End of method";
        }
        public string SqlExceptionDemo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-US2RJ9L;Initial Catalog=BookLibraryDB;Integrated Security=True;Trust Server Certificate=True"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_CustomValidationError", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Salary", 1000); // Assuming 9999 does not exist in the referenced table

                        cmd.ExecuteNonQuery(); // will throw SqlException
                    }
                }
                Console.WriteLine("Its  Success");
                return "Success";
                // Simulate SQL Exception
                //throw new Exception("Simulated SQL Exception");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL exception : " + ex.Message);
                return ex.Message;
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception");
                return ex.Message;
            }
            finally
            {
                Console.WriteLine("Finally block");
            }

            //return "End of method";
        }


        public void RunDemo(string title, Action action)
        {
            Console.WriteLine($"--- Testing {title} ---");

            try
            {
                action();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Caught SqlException: {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Caught NullReferenceException: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Caught IndexOutOfRangeException: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Caught InvalidOperationException: {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Caught ArgumentNullException: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Caught ArgumentOutOfRangeException: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Caught FormatException: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Caught DivideByZeroException: {ex.Message}");
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Caught InvalidCastException: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Caught OverflowException: {ex.Message}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Caught FileNotFoundException: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Caught IOException: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Caught UnauthorizedAccessException: {ex.Message}");
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Caught KeyNotFoundException: {ex.Message}");
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"Caught NotImplementedException: {ex.Message}");
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine($"Caught TimeoutException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught General Exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed.\n");
            }
        }

        // Exception-generating methods
        public void ThrowSqlException()
        {
            // Force SQL error by invalid connection
            using var con = new SqlConnection("Server=INVALID;Database=INVALID;Trusted_Connection=True;");
            con.Open(); // throws SqlException
        }

        public void ThrowNullReferenceException()
        {
            string x = null;
            _ = x.Length;
        }

        public void ThrowIndexOutOfRangeException()
        {
            int[] a = { 1, 2 };
            _ = a[10];
        }

        public void ThrowInvalidOperationException()
        {
            var list = new List<int>();
            var enumerator = list.GetEnumerator();
            _ = enumerator.Current; // invalid state
        }

        public void ThrowArgumentNullException()
        {
            string value = null;
            if (value == null) throw new ArgumentNullException(nameof(value));
        }

        public void ThrowArgumentOutOfRangeException()
        {
            int age = -5;
            if (age < 0) throw new ArgumentOutOfRangeException(nameof(age));
        }

        public void ThrowFormatException()
        {
            int x = int.Parse("ABC");
        }

        public void ThrowDivideByZeroException()
        {
            int a = 10;
            int b= 0;

            int x = a/b;
        }

        public void ThrowInvalidCastException()
        {
            object o = "hello";
            int x = (int)o;
        }

        public void ThrowOverflowException()
        {
            int a = int.MaxValue;
            checked
            {
                int x = a + 1; // runtime overflow → OverflowException
            }
        }

        public void ThrowFileNotFoundException()
        {
            File.ReadAllText("nofile.txt");
        }

        public void ThrowIOException()
        {
            throw new IOException("Custom IO error");
        }

        public void ThrowUnauthorizedException()
        {
            throw new UnauthorizedAccessException("You have no permission");
        }

        public void ThrowKeyNotFoundException()
        {
            var dict = new Dictionary<string, int>();
            _ = dict["missing"];
        }

        public void ThrowNotImplementedException()
        {
            throw new NotImplementedException("Method not implemented");
        }

        public void ThrowTimeoutException()
        {
            throw new TimeoutException("Operation timed out");
        }
    }
}

    

