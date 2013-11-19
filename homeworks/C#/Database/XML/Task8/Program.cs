using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task8
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string SOURCE_PATH = "AlbumCatalog.xml";

            const string OUTPUT_PATH = "albums.xml";

            XmlReader reader = XmlReader.Create(SOURCE_PATH);
            XmlWriter writer = XmlWriter.Create(OUTPUT_PATH);

            using(reader)
            {
                using(writer)
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("albums");
                    while(reader.Read())
                    {
                        string tagName = reader.Name;
                        if (tagName != "xml" && tagName != "")
                        {
                            if (tagName == "catalog")
                            {
                                continue;
                            }

                            writer.WriteStartElement(tagName);
                            for (int i = 0; i < reader.AttributeCount; i++)
                            {
                                reader.MoveToAttribute(i);
                                //writer.WriteStartAttribute(reader.Name);
                                writer.WriteAttributeString(reader.Name, reader.GetAttribute(i));

                            }
                            writer.WriteEndElement();

                        }
                        else
                        {
                            writer.WriteString(Environment.NewLine);
                        }
                    }
                    writer.WriteEndElement();
                }
            }
        }
    }
}
