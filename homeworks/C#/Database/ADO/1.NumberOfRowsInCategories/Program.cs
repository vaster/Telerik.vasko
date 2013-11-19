using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.NumberOfRowsInCategories
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlConnection northwindConnection = new SqlConnection(
                "Server = .\\SQLEXPRESS; " + 
                "Database = northwind; " +
                "Integrated Security = true"
                );

            northwindConnection.Open();

            using(northwindConnection)
            {
                SqlCommand countOfRowsInCatg = new SqlCommand(
                    "SELECT COUNT(*) FROM Categories",northwindConnection);

                int rowsCount = (int)countOfRowsInCatg.ExecuteScalar();

                Console.WriteLine("Number of rows int Categories is " + rowsCount);
            }
        }
    }
}
