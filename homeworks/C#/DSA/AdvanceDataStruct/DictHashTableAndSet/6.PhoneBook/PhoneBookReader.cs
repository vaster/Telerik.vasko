using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6.PhoneBook
{
    public class PhoneBookReader
    {
        public List<string> Names { get; private set; }

        public List<string> Towns { get; private set; }

        public List<string> PhoneNumbers { get; private set; }

        public int EntriesCount;

        private TextReader Reader { get; set; }

        private const int LENGTH_OF_ELEMENTS_IN_SINGLE_LINE = 3;

        private const char SEPARATOR_SYMBOL =  '|';

        public PhoneBookReader(string source)
        {
            this.Reader = new StreamReader(source);
            this.Names = new List<string>();
            this.Towns = new List<string>();
            this.PhoneNumbers = new List<string>();
            this.EntriesCount = 0;
        }

        public void ReadText()
        {
            string[] splitetLine =
                new string[PhoneBookReader.LENGTH_OF_ELEMENTS_IN_SINGLE_LINE];

            string line = "";

            using (this.Reader)
            {
                while (line != null)
                {
                    line = Reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    splitetLine = line.Split(PhoneBookReader.SEPARATOR_SYMBOL);

                    this.Names.Add(splitetLine[0].Trim());
                    this.Towns.Add(splitetLine[1].Trim());
                    this.PhoneNumbers.Add(splitetLine[2].Trim());
                    this.EntriesCount++;
                }
            }
        }
    }
}
