using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SOURCE_PATH = "AlbumCatalog.xml";

            XDocument doc = XDocument.Load(SOURCE_PATH);

            var titles = doc.Descendants("song");

            foreach (var title in titles)
            {
                Console.WriteLine(title.Attributes().First().Value);
            }
        }
    }
}
