using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SOURCE_PATH = "AlbumCatalog.xml";

            const string PATH_QUERY = "catalog/album[@year>='1999']";

            XmlDocument doc = new XmlDocument();
            doc.Load(SOURCE_PATH);

            XmlNodeList albums = doc.SelectNodes(PATH_QUERY);

            foreach (XmlNode album in albums)
            {
                foreach (XmlAttribute atr in album.Attributes)
                {
                    if (atr.Name == "name" || atr.Name == "year")
                    {
                        Console.WriteLine(atr.Name + " " + atr.Value);
                    }
                }
            }
        }
    }
}
