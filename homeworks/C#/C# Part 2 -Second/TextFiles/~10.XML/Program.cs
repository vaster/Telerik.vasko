using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _10.XML
{
    /*Write a program that extracts from given XML file all the text without the tags*/

    internal class Program
    {
        public const string SOURCE_PATH = "source.xml";

        static void Main(string[] args)
        {
            XmlReader reader = XmlReader.Create(Program.SOURCE_PATH);

            using (reader)
            {
                while (reader.Read())
                {
                    if (!String.IsNullOrWhiteSpace(reader.Value))
                    {
                        Console.WriteLine(reader.Value);
                    }
                }
            }
        }
    }
}
