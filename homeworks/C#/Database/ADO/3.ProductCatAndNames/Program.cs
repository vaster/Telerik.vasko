using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ProductCatAndNames
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection northwindDBConnection = new SqlConnection(
               "Server = .\\SQLEXPRESS; " +
               "Database = northwind; " +
               "Integrated Security = true"
               );

            northwindDBConnection.Open();

            using(northwindDBConnection)
            {
                SqlCommand productNameAndRespectiveCatgQuery = new SqlCommand(
                    "SELECT c.CategoryName, p.ProductName FROM Categories c JOIN Products p ON p.CategoryID = c.CategoryID;", northwindDBConnection);

                SqlDataReader reader = productNameAndRespectiveCatgQuery.ExecuteReader();

                using(reader)
                {
                    StringBuilder result = new StringBuilder();
                    while(reader.Read())
                    {
                        result.Append((string)reader["CategoryName"] + ": ");
                        result.AppendLine((string)reader["ProductName"]);
                    }

                    Console.WriteLine(result);
                }
            }
        }
    }
}
