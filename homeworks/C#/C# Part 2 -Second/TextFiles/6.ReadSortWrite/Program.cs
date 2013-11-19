using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ReadSortWrite
{
    /*
     Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
     */

    internal class Program
    {
        public const string SOURCE_PATH = "source.txt";
        public const string RESULT_PATH = "result.txt";

        public static void ReadInput(IList<string> data)
        {
            StreamReader reader = new StreamReader(Program.SOURCE_PATH);
            string inputLine = null;

            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    inputLine = reader.ReadLine();
                    data.Add(inputLine);
                }
            }
        }

        public static void WriteSortedInput(IList<string> data)
        {
            StreamWriter writer = new StreamWriter(Program.RESULT_PATH);
            using(writer)
            {
                for (int lineIndex = 0; lineIndex < data.Count; lineIndex++)
                {
                    writer.WriteLine(data[lineIndex]);
                }
            }
        }

        static void Main(string[] args)
        {
            List<string> data = new List<string>();

            Program.ReadInput(data);
            data.Sort();
            Program.WriteSortedInput(data);
        }
    }
}
