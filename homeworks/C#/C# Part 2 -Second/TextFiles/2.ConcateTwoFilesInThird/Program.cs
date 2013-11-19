using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ConcateTwoFilesInThird
{
    /*
     Write a program that concatenates two text files into another text file.
     */
    public class Program
    {
        static void Main(string[] args)
        {
            string textFilePartOnePath = "part-1.txt";
            string textFilePartTwoPath = "part-2.txt";

            StreamWriter writer = new StreamWriter("result.txt");

            StringBuilder output = new StringBuilder();

            output.Append(File.ReadAllText(textFilePartOnePath));
            output.Append(File.ReadAllText(textFilePartTwoPath));

            using (writer)
            {
                writer.Write(output);
            }
        }
    }
}
