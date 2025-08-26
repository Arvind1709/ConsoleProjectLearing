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

        //public void ReadDataAndInsertWithEF()
        //{
        //    string filePath = "textFiles/Orders.txt";
        //    string[] lines = File.ReadAllLines(filePath);
        //    string currentSection = "";

        //    using (var context = new MyAppDbContext())
        //    {
        //        foreach (var line in lines)
        //        {
        //            if (string.IsNullOrWhiteSpace(line)) continue;
        //            if (line.StartsWith("#"))
        //            {
        //                currentSection = line;
        //                continue;
        //            }

        //            if (line.StartsWith("OrderId") || line.StartsWith("ItemId") || line.StartsWith("SubItemId"))
        //                continue;

        //            string[] parts = line.Split(',');

        //            if (currentSection == "#Order")
        //            {
        //                var order = new OrderModel
        //                {
        //                    OrderId = parts[0],
        //                    OrderDate = DateTime.Parse(parts[1]),
        //                    CustomerName = parts[2]
        //                };
        //                context.Orders.Add(order);
        //            }
        //            else if (currentSection == "#OrderItems")
        //            {
        //                var orderItem = new OrderItemModel
        //                {
        //                    ItemId = parts[0],
        //                    OrderId = parts[1],
        //                    ItemName = parts[2],
        //                    Quantity = int.Parse(parts[3]),
        //                    Price = decimal.Parse(parts[4])
        //                };
        //                context.OrderItems.Add(orderItem);
        //            }
        //            else if (currentSection == "#OrderSubItems")
        //            {
        //                var subItem = new OrderSubItemModel
        //                {
        //                    //SubItemId = int.Parse(parts[0]),
        //                    SubItemId = parts[0],
        //                    ItemId = parts[1],
        //                    SubItemName = parts[2],
        //                    Quantity = int.Parse(parts[3]),
        //                    Price = decimal.Parse(parts[4])
        //                };
        //                context.OrderSubItems.Add(subItem);
        //            }
        //        }
        //        context.SaveChanges();  // One-time save to the database
        //    }

        //    Console.WriteLine("All data inserted successfully using EF!");
        //}



        public void ReadDataAndWriteToFile()
        {
            string connectionString = "Data Source=DESKTOP-US2RJ9L;Initial Catalog=Task;Integrated Security=True;Trust Server Certificate=True";
            string query = @"
                SELECT 
                    o.OrderId, o.OrderDate, o.CustomerName,
                    oi.ItemId, oi.ItemName, oi.Quantity AS ItemQuantity, oi.Price AS ItemPrice,
                    os.SubItemId, os.SubItemName, os.Quantity AS SubItemQuantity, os.Price AS SubItemPrice
                FROM Orders o
                JOIN OrderItems oi ON o.OrderId = oi.OrderId
                JOIN OrderSubItems os ON oi.ItemId = os.ItemId";

            string filePath = "C:\\Users\\Dell\\Desktop\\Interview\\OrdersData.txt";
            Directory.CreateDirectory(Path.GetDirectoryName(filePath)); // Ensure the folder exists

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    while (reader.Read())
                    {
                        string line = $"{reader["OrderId"]}, {reader["OrderDate"]}, {reader["CustomerName"]}, " +
                                      $"{reader["ItemId"]}, {reader["ItemName"]}, {reader["ItemQuantity"]}, {reader["ItemPrice"]}, " +
                                      $"{reader["SubItemId"]}, {reader["SubItemName"]}, {reader["SubItemQuantity"]}, {reader["SubItemPrice"]}";
                        writer.WriteLine(line);
                    }
                }
                Console.WriteLine("Data has been written to OrdersData.txt");
            }
        }

        //public void ReadDataAndWriteToFileWithEF()
        //{
        //    string filePath = "C:\\Users\\Dell\\Desktop\\Interview\\OrdersData.txt";
        //    using (var context = new MyAppDbContext())
        //    using (StreamWriter writer = new StreamWriter(filePath))
        //    {
        //        var orders = context.Orders
        //            .Include(o => o.OrderItems)
        //            .ThenInclude(oi => oi.OrderSubItems)
        //            .ToList();
        //        foreach (var order in orders)
        //        {
        //            foreach (var item in order.OrderItems)
        //            {
        //                foreach (var subItem in item.OrderSubItems)
        //                {
        //                    string line = $"{order.OrderId}, {order.OrderDate}, {order.CustomerName}, " +
        //                                  $"{item.ItemId}, {item.ItemName}, {item.Quantity}, {item.Price}, " +
        //                                  $"{subItem.SubItemId}, {subItem.SubItemName}, {subItem.Quantity}, {subItem.Price}";
        //                    writer.WriteLine(line);
        //                }
        //            }
        //        }
        //    }
        //    Console.WriteLine("Data has been written to OrdersDataEF.txt");
        //}
    }
}
