using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _5.ImageRestore
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

            MemoryStream stream = new MemoryStream();
            northwindDBConnection.Open();

            using (northwindDBConnection)
            {
                /*connectionString = "Data Source=servername; Initial Catalog=databasename; User ID=sa; Password=password";
			        cnn = new SqlConnection(connectionString);

			        MemoryStream stream = new MemoryStream();
			        cnn.Open();
			        SqlCommand command = new SqlCommand("select img from imgtable where id=2", cnn);
			        byte[] image = (byte[])command.ExecuteScalar();
			        stream.Write(image, 0, image.Length);
			        cnn.Close();
			        Bitmap bitmap = new Bitmap(stream);
			        pictureBox1.Image = bitmap;
		        }*/

                SqlCommand retriveQuery =new SqlCommand(
                    "SELECT Photo from Employees",northwindDBConnection
                    );

                SqlDataReader reader = retriveQuery.ExecuteReader();

                using(reader)
                {
                    int photoNameIndetificator = 1;
                    while (reader.Read())
                    {
                        byte[] photoBits = (byte[])reader["Photo"];

                        using (stream = new MemoryStream(photoBits))
                        {

                            stream.Seek(0, SeekOrigin.Begin);
                            // image is not read right from the sql server, causing invalid img bits
                            Image currPhoto = Image.FromStream(stream);

                            currPhoto.Save("image" + photoNameIndetificator, System.Drawing.Imaging.ImageFormat.Gif);
                        }
                    }
                }

            }
        }
    }
}
