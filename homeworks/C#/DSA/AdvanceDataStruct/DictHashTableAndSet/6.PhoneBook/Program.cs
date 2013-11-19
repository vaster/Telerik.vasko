using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.PhoneBook
{
    public class Program
    {
        // Not implemented!!!
        static void Main(string[] args)
        {
            const string source = "phones.txt";

            PhoneBookReader phoneBookReader = new PhoneBookReader(source);
            phoneBookReader.ReadText();

            PhoneBook<string> records = new PhoneBook<string>();

            string name = null;
            string town = null;
            string phone = null;

            for (int entryIndex = 0; entryIndex < phoneBookReader.EntriesCount; entryIndex++)
            {
                name = phoneBookReader.Names[entryIndex];
                town = phoneBookReader.Towns[entryIndex];
                phone = phoneBookReader.PhoneNumbers[entryIndex];

                records.Add(name, town, phone);
            }

           sor
        }
    }
}
