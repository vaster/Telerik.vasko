using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SOURCE_PATH = "AlbumCatalog.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(SOURCE_PATH);

            XmlNode root = doc.DocumentElement;

            foreach (XmlNode tag in root)
            {
                int alubmPrize = int.Parse(tag.Attributes["price"].Value);

                if (alubmPrize > 20)
                {
                    root.RemoveChild(tag);
                }
            }
        }
    }
}
