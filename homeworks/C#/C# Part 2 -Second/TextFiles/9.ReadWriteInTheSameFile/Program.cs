using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ReadWriteInTheSameFile
{
    /*
     Write a program that deletes from given text file all odd lines.
     The result should be in the same file.

     */

    internal class Program
    {
        public const string FILE_PATH = "source.txt";

        static void Main(string[] args)
        {
            var stream = File.Open(Program.FILE_PATH, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var writer = new StreamWriter(stream);
            var reader = new StreamReader(stream);

            List<string> text = new List<string>();
            int lineCounter = 0;
            string currLine = "";

            using (stream)
            {
                using (writer)
                {
                    while (currLine != null)
                    {
                        currLine = reader.ReadLine();

                        if (lineCounter % 2 != 0)
                        {
                            text.Add(currLine);
                        }
                        lineCounter++;
                    }

                    foreach (var line in text)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}
