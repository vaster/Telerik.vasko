using System;
using System.IO;

class CompareLineByLine
{
    static void Main(string[] args)
    {
        StreamReader readerOne = new StreamReader("textOne.txt");
        StreamReader readerTwo = new StreamReader("textTwo.txt");
        int equals = 0;
        int differs = 0;

        using (readerOne)
        {
            string first = readerOne.ReadLine();
            using (readerTwo)
            {
                string second = readerTwo.ReadLine();

                while (second != null)
                {
                    
                    if (first.Equals(second))
                    {
                        equals++;
                    }
                    else
                    {
                        differs++;
                    }

                    first = readerOne.ReadLine();
                    second = readerTwo.ReadLine();
                }
            }
        }


        Console.WriteLine("Equal lines are {0}, diffrent are {1} lines",equals,differs);
    }
}

