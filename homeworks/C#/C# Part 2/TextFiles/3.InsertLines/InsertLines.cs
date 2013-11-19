using System;
using System.IO;

class InsertLines
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("test.txt");
        StreamWriter writer = new StreamWriter("textWithLines.txt");


        using (reader)
        {
            string read = reader.ReadLine();
            int lines = 0;
            Console.SetOut(writer);
            
            while (read != null)
            {
                lines++;
                Console.WriteLine("{0}:{1}", lines, read);
                Console.SetOut(writer);
                read = reader.ReadLine();
            }

            writer.Close();
        }
    }
}

