using System;
using System.IO;

class Concatenate
{
    static void Main(string[] args)
    {
        StreamReader readerOne = new StreamReader("text1.txt");
        StreamReader readerTwo = new StreamReader("text2.txt");
        StreamWriter writing = new StreamWriter("finalText.txt");

        using (readerOne)
        {
            string textOne = readerOne.ReadLine();
            writing.WriteLine(textOne);
            while (textOne != null)
            {
                textOne = readerOne.ReadLine();
               
                    writing.WriteLine(textOne);
                
            }

            using (readerTwo)
            {
                string textTwo = readerTwo.ReadLine();
                writing.WriteLine(textTwo);
                while (textTwo != null)
                {
                    textTwo = readerTwo.ReadLine();
                    using (writing)
                    {
                        writing.WriteLine(textTwo);
                    }
                }
            }
        }

        
    }
}

