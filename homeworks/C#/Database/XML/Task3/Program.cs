using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SOURCE_PATH = "AlbumCatalog.xml";

            const int INITIAL_ALBUM_COUNT = 1;

            const string PATH_QUERY = "catalog/album";

            XmlDocument doc = new XmlDocument();
            doc.Load(SOURCE_PATH);

            Dictionary<string, int> artistAndAlumCounts =
                new Dictionary<string, int>();

            XmlNodeList albumList = doc.SelectNodes(PATH_QUERY);

            foreach (XmlNode ablum in albumList)
            {
                string artist = ablum.Attributes["artist"].Value;

                if (artistAndAlumCounts.ContainsKey(artist))
                {
                    artistAndAlumCounts[artist]++;
                }
                else
                {
                    artistAndAlumCounts.Add(artist, INITIAL_ALBUM_COUNT);
                }
            }


            foreach (var artist in artistAndAlumCounts)
            {
                Console.WriteLine(artist.Key + " -> " + artist.Value);
            }
        }
    }
}
