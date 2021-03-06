﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            const string SOURCE_PATH = "AlbumCatalog.xml";

            const int INITIAL_ALBUM_COUNT = 1;

            XmlDocument doc = new XmlDocument();
            doc.Load(SOURCE_PATH);

            Dictionary<string, int> artistAndAlumCounts =
                new Dictionary<string, int>();

            XmlNode root = doc.DocumentElement;

            foreach (XmlNode element in root.ChildNodes)
            {
                string artistName = element.Attributes["artist"].Value;

                if (artistAndAlumCounts.ContainsKey(artistName))
                {
                    artistAndAlumCounts[artistName]++;
                }
                else
                {
                    artistAndAlumCounts.Add(artistName,INITIAL_ALBUM_COUNT);
                }
            }


            foreach (var artist in artistAndAlumCounts)
            {
                Console.WriteLine(artist.Key + " -> " + artist.Value);
            }
        }
    }
}
