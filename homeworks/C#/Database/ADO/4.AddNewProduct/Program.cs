using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AddNewProduct
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

            string productName = "Flower";
            int suplierId = 1;
            int categoryId = 1;
            string quantity = "1 box";
            decimal prize = 12;
            int unitsInStock = 8;
            int unitsOnOrder = 0;
            int reorderLevel = 10;
            bool discontinued = false;

            using (northwindDBConnection)
            {
                SqlCommand productAdditionQuery = new SqlCommand(
                    "INSERT INTO Products "
                    +"(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) "+
                    "VALUES(@name,@suppId,@catId,@quantity,@prize,@stock,@order,@recordLevel,@discontinued)",northwindDBConnection
                    );

                productAdditionQuery.Parameters.AddWithValue("@name",productName);
                productAdditionQuery.Parameters.AddWithValue("@suppId", suplierId);
                productAdditionQuery.Parameters.AddWithValue("@catId", categoryId);
                productAdditionQuery.Parameters.AddWithValue("@quantity", quantity);
                productAdditionQuery.Parameters.AddWithValue("@prize", prize);
                productAdditionQuery.Parameters.AddWithValue("@stock", unitsInStock);
                productAdditionQuery.Parameters.AddWithValue("@order", unitsOnOrder);
                productAdditionQuery.Parameters.AddWithValue("@recordLevel", reorderLevel);
                productAdditionQuery.Parameters.AddWithValue("@discontinued", discontinued);

                productAdditionQuery.ExecuteNonQuery();
             
            }
        }
    }
}
