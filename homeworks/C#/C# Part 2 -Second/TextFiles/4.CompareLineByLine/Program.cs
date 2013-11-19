using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4.CompareLineByLine
{
    /*
     Write a program that compares two text files line by line and prints the number of
     * lines that are the same and the number of lines that are different.
     Assume the files have equal number of lines.
     */
    public class Program
    {
        static void Main(string[] args)
        {

            string fileOnePath = "file-1.txt";
            string fileTwoPath = "file-2.txt";

            StreamReader readerFileOne = new StreamReader(fileOnePath);
            StreamReader readerFileTwo = new StreamReader(fileTwoPath);

            string firstFileLine = null;
            string secondFileLine = null;

            StringBuilder output = new StringBuilder();

            int lineCounter = 1;

            using (readerFileOne)
            {
                using (readerFileTwo)
                {
                    do
                    {
                        firstFileLine = readerFileOne.ReadLine();
                        secondFileLine = readerFileTwo.ReadLine();

                        if (firstFileLine == null)
                        {
                            break;
                        }

                        if (firstFileLine == secondFileLine)
                        {
                            output.AppendLine("Line number " + lineCounter + " are equal.");
                        }
                        else
                        {
                            output.AppendLine("Line number " + lineCounter + " are not equal.");
                        }

                        lineCounter++;

                    } while (firstFileLine != null);
                }
            }

            Console.WriteLine(output);
        }
    }
}
