using System;
using System.IO;


class PrintOddLinesOfTextFile
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("test.txt");

        using (reader)
        {
            int indexLine = 0;

            string line = reader.ReadLine();

            while(line!=null)
            {
                if (indexLine % 2 != 0)
                {
                    Console.Write("dasda");
                }
                indexLine++;
                line = reader.ReadLine();
            }
        }
    }
}

