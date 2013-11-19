using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReadFromTextPrintToConsole
{
    /*
     Write a program that reads a text file and prints on the console its odd lines.

     */
    public class Program
    {
        static void Main(string[] args)
        {
            string path = "sample.txt";

            StringBuilder output = new StringBuilder();

            StringBuilder original = new StringBuilder();

            StreamReader reader = new StreamReader(path);

            int lineNumber = 1;

            string line = null;

            using (reader)
            {
                do
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    original.AppendLine(line);

                    if (!(lineNumber % 2 == 0))
                    {
                        output.AppendLine(line);
                    }

                    lineNumber++;
                } while (line != null);
            }

            Console.WriteLine(original);
            Console.WriteLine();
            Console.WriteLine(output);
        }
    }
}
