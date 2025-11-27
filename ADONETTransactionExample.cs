using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class ADONETTransactionExample
    {
        public void ExecuteTransaction()
        {
            // 1️⃣ Define connection string (change server name if needed)
            string connectionString = "Data Source=DESKTOP-US2RJ9L;Initial Catalog=BankDB;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // 2️⃣ Start a transaction
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    Console.WriteLine("Transaction started...");

                    // 3️⃣ Create command 1 — deduct from Arvind’s account
                    SqlCommand cmd1 = new SqlCommand(
                        "UPDATE Accounts SET Balance = Balance - 1000 WHERE AccNo = 1",
                        connection, transaction);

                    // 4️⃣ Execute first query
                    cmd1.ExecuteNonQuery();
                    Console.WriteLine("Deducted ₹1000 from Arvind.");

                    // 5️⃣ Create command 2 — add to Yash’s account
                    SqlCommand cmd2 = new SqlCommand(
                        "UPDATE Accounts SET Balance = Balance + 1000 WHERE AccNo = 2",
                        connection, transaction);

                    // 6️⃣ Execute second query
                    cmd2.ExecuteNonQuery();
                    Console.WriteLine("Added ₹1000 to Yash.");

                    // 7️⃣ If everything is successful → Commit
                    transaction.Commit();
                    Console.WriteLine("✅ Transaction committed successfully!");
                }
                catch (Exception ex)
                {
                    // 8️⃣ If any error → Rollback
                    transaction.Rollback();
                    Console.WriteLine("❌ Transaction rolled back due to an error: " + ex.Message);
                }

                // 9️⃣ Show current balances
                Console.WriteLine("\nCurrent Account Balances:");
                SqlCommand cmd3 = new SqlCommand("SELECT * FROM Accounts", connection);
                SqlDataReader reader = cmd3.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"AccNo: {reader["AccNo"]}, Name: {reader["Name"]}, Balance: {reader["Balance"]}");
                }
                reader.Close();
            }

            Console.WriteLine("\nProgram completed. Press any key to exit...");
            Console.ReadKey();
        }

        public void ExecuteTransactionWithErrorFromSP()
        {
            // 1️⃣ Connection string (update your SQL Server name)
            string connectionString = "Data Source=DESKTOP-US2RJ9L;Initial Catalog=BankDB;Integrated Security=True;Trust Server Certificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    Console.WriteLine("Enter Source Account Number: ");
                    int fromAcc = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Destination Account Number: ");
                    int toAcc = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Amount to Transfer: ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());

                    // 2️⃣ Create SqlCommand to call stored procedure
                    SqlCommand cmd = new SqlCommand("usp_TransferMoneyTest", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // 3️⃣ Add parameters
                    cmd.Parameters.AddWithValue("@FromAcc", fromAcc);
                    cmd.Parameters.AddWithValue("@ToAcc", toAcc);
                    cmd.Parameters.AddWithValue("@Amount", amount);

                    // 4️⃣ Execute stored procedure
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("\n✅ Stored procedure executed successfully.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                }

                // 5️⃣ Show final account balances
                SqlCommand showCmd = new SqlCommand("SELECT * FROM Accounts", connection);
                SqlDataReader reader = showCmd.ExecuteReader();

                Console.WriteLine("Current Account Balances:");
                while (reader.Read())
                {
                    Console.WriteLine($"AccNo: {reader["AccNo"]}, Name: {reader["Name"]}, Balance: {reader["Balance"]}");
                }

                reader.Close();
            }

            Console.WriteLine("\nProgram completed. Press any key to exit...");
            Console.ReadKey();
        }
    }
    
}


