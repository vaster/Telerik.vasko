using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FindProduct
{
    class Program
    {
        static string ReadSequnce()
        {
            string input = Console.ReadLine();

            return input;
        }

        static void Main(string[] args)
        {

            SqlConnection northwindDBConnection = new SqlConnection(
               "Server = .\\SQLEXPRESS; " +
               "Database = northwind; " +
               "Integrated Security = true"
               );

            northwindDBConnection.Open();

            string stringPattern = Program.ReadSequnce();

            using(northwindDBConnection)
            {
                string command =
                    " SELECT ProductName from Products WHERE ProductName = @pattern";

                SqlParameter pattern = new SqlParameter("@pattern",stringPattern);
                SqlCommand executor = new SqlCommand(command,northwindDBConnection);
                executor.Parameters.Add(pattern);

                SqlDataReader reader = executor.ExecuteReader();

                using(reader)
                {
                    StringBuilder result = new StringBuilder();

                    while(reader.Read())
                    {
                        result.AppendLine((string)reader["ProductName"]);
                    }

                    Console.WriteLine(result);
                }
            }
        }
    }
}
