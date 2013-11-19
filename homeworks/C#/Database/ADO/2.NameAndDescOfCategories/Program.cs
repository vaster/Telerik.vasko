using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.NameAndDescOfCategories
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlConnection northwindDBConnection = new SqlConnection(
                "Server = .\\SQLEXPRESS; " +
                "Database = northwind; " +
                "Integrated Security = true"
                );

            northwindDBConnection.Open();

            using (northwindDBConnection)
            {
                SqlCommand nameAndDescQuery = new SqlCommand(
                    "SELECT CategoryName, Description from Categories", northwindDBConnection);

                SqlDataReader reader = nameAndDescQuery.ExecuteReader();

                using(reader)
                {
                    StringBuilder result = new StringBuilder();
                    while(reader.Read())
                    {
                        result.Append((string)reader["CategoryName"] + ": ");
                        result.AppendLine((string)reader["Description"]);
                    }

                    Console.WriteLine(result);
                }
            }
        }
    }
}
