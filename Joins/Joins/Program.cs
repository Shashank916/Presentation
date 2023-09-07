using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        // Define your connection string
        string connectionString = "Data Source=SHASHANK;Initial Catalog=JOINS;Integrated Security=True";

        // SQL query with INNER JOIN
        string sqlQuery = "SELECT Orders.OrderID, Customers.CustomerName " +
                          "FROM Orders " +
                          "INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Execute the query and retrieve the data
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("OrderID\tCustomerName");
                        Console.WriteLine("======================");

                        // Process the result set
                        while (reader.Read())
                        {
                            int orderID = reader.GetInt32(0); // Assuming OrderID is in the first column
                            string customerName = reader.GetString(1); // Assuming CustomerName is in the second column

                            Console.WriteLine($"{orderID}\t{customerName}");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}