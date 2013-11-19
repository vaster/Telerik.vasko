using System;
using System.IO;
using System.Collections.Generic;

class SortAndWrite
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("test.txt");
        StreamWriter write = new StreamWriter("SortedText.txt");
        List<string> toBeSorted = new List<string>();


        using (reader)
        {

            string readLine = reader.ReadLine();
            toBeSorted.Add(readLine);
            while (readLine != null)
            {
                readLine = reader.ReadLine();
                toBeSorted.Add(readLine);
            }
        }

        string[] stringForSorting = new string[toBeSorted.Capacity];
        for (int i = 0; i < toBeSorted.Capacity-3; i++)
        {
            //Console.WriteLine(i);
            stringForSorting[i] = toBeSorted[i];
        }
        Array.Sort(stringForSorting, StringComparer.InvariantCulture);
        using (write)
        {
            for (int i = 0; i < stringForSorting.Length; i++)
            {
                write.WriteLine(stringForSorting[i]);
            }
        }
    }
}
