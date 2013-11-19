using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TaskC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SOURCE_PATH = "AlbumCatalog.xml";

            XDocument doc = XDocument.Load(SOURCE_PATH);
            
            var result =
                from e in doc.Elements().Elements()
                from a in e.Attributes()
                where a.Name == "year" && int.Parse(a.Value) > 1995
                select new { 
                    Name = e.Attribute("name").Value,
                    Year = e.Attribute("year").Value,                
                };

            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " " + item.Year);
            }
            
        }
    }
}
