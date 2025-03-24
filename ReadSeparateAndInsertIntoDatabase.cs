using Microsoft.Data.SqlClient;

namespace ConsoleProjectLearing
{
    internal class ReadSeparateAndInsertIntoDatabase
    {
        public void ReadDataAndInsertIntoDatabase()
        {
            string connectionString = "Data Source=DESKTOP-US2RJ9L;Initial Catalog=Task;Integrated Security=True;Trust Server Certificate=True";
            string filePath = "textFiles/Orders.txt";
            string[] lines = System.IO.File.ReadAllLines(filePath);
            string currentSection = "";
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                if (line.StartsWith("#"))
                {
                    currentSection = line;
                    continue;
                }
                // Skip headers (next line after section name)
                if (line.StartsWith("OrderId") || line.StartsWith("ItemId") || line.StartsWith("SubItemId"))
                    continue;
                string[] parts = line.Split(',');
                if (currentSection == "#Order")
                {
                    InsertOrder(connectionString, parts);
                }
                else if (currentSection == "#OrderItems")
                {
                    InsertOrderItem(connectionString, parts);
                }
                else if (currentSection == "#OrderSubItems")
                {
                    InsertOrderSubItem(connectionString, parts);
                }
            }
            Console.WriteLine("All data inserted successfully!");
        }
        //static void Main()
        //{
        //    string connectionString = "Your_Connection_String_Here";
        //    string filePath = "OrderData.txt";
        //    string[] lines = File.ReadAllLines(filePath);

        //    string currentSection = "";

        //    foreach (var line in lines)
        //    {
        //        if (string.IsNullOrWhiteSpace(line)) continue;

        //        if (line.StartsWith("#"))
        //        {
        //            currentSection = line;
        //            continue;
        //        }

        //        // Skip headers (next line after section name)
        //        if (line.StartsWith("OrderId") || line.StartsWith("ItemId") || line.StartsWith("SubItemId"))
        //            continue;

        //        string[] parts = line.Split(',');

        //        if (currentSection == "#Order")
        //        {
        //            InsertOrder(connectionString, parts);
        //        }
        //        else if (currentSection == "#OrderItems")
        //        {
        //            InsertOrderItem(connectionString, parts);
        //        }
        //        else if (currentSection == "#OrderSubItems")
        //        {
        //            InsertOrderSubItem(connectionString, parts);
        //        }
        //    }

        //    Console.WriteLine("All data inserted successfully!");
        //}

        static void InsertOrder(string connStr, string[] parts)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Orders (OrderId, OrderDate, CustomerName) VALUES (@OrderId, @OrderDate, @CustomerName)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderId", parts[0]);
                cmd.Parameters.AddWithValue("@OrderDate", DateTime.Parse(parts[1]));
                cmd.Parameters.AddWithValue("@CustomerName", parts[2]);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        static void InsertOrderItem(string connStr, string[] parts)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO OrderItems (ItemId, OrderId, ItemName, Quantity, Price) VALUES (@ItemId, @OrderId, @ItemName, @Quantity, @Price)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ItemId", parts[0]);
                cmd.Parameters.AddWithValue("@OrderId", parts[1]);
                cmd.Parameters.AddWithValue("@ItemName", parts[2]);
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(parts[3]));
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(parts[4]));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        static void InsertOrderSubItem(string connStr, string[] parts)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO OrderSubItems (SubItemId, ItemId, SubItemName, Quantity, Price) VALUES (@SubItemId, @ItemId, @SubItemName, @Quantity, @Price)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SubItemId", parts[0]);
                cmd.Parameters.AddWithValue("@ItemId", parts[1]);
                cmd.Parameters.AddWithValue("@SubItemName", parts[2]);
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(parts[3]));
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(parts[4]));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
