using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SOURCE_PATH = "AlbumCatalog.xml";

            using (XmlReader reader = XmlReader.Create(SOURCE_PATH))
            {
                while (reader.Read())
                {
                    string atr = reader.GetAttribute("title");
                    if (!String.IsNullOrEmpty(atr))
                    {
                        Console.WriteLine(atr);
                    }
                }
            }
        }
    }
}
