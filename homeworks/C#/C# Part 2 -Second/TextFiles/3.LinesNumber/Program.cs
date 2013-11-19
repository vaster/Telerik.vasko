using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LinesNumber
{
    /*
     Write a program that reads a text file and inserts line numbers in front of each of its lines.
     The result should be written to another text file.
     */

    public class Program
    {
        static void Main(string[] args)
        {
            string path = "input.txt";

            string resultPath = "result.txt";

            StreamReader reader = new StreamReader(path);

            StringBuilder result = new StringBuilder();
            
            string line = null;

            int lineNumber = 1;

            using(reader)
            {
                do
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    result.AppendLine(lineNumber+"." + line);
                    lineNumber++;

                } while (line != null);
            }

            File.WriteAllText(resultPath,result.ToString());
        }
    }
}
