using System;

using System.Data.OleDb;
using System.Linq;


namespace _6.ExcelManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
           /* DataSet sheet1 = new DataSet();
            OleDbConnectionStringBuilder csbuilder = new OleDbConnectionStringBuilder();
            csbuilder.Provider =
            csbuilder.DataSource = Microsoft.SqlServer.Server.MapPath(@"demo.xlsx");
            csbuilder.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES");*/

            OleDbConnection dbConn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = repository.xls;");

            dbConn.Open();
            using (dbConn)
            {
                
            }
        }
    }
}
