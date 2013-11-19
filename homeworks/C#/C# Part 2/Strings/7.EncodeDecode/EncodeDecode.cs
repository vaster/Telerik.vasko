using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EncodeDecode
{
    static void Main(string[] args)
    {
        string input;
        string cyper;
        char symbolBySymbol;

        StringBuilder coded = new StringBuilder();
        StringBuilder decoded = new StringBuilder();

        Console.Write("Enter text to be coded:");
        input = Console.ReadLine();

        Console.Write("Enter cypher:");
        cyper = Console.ReadLine();

        for (int i = 0,y=0; i < input.Length; i++,y++)
        {
            if (y == cyper.Length)
            {
                y = 0;
            }
            symbolBySymbol = input[i];
            if (symbolBySymbol > (char)cyper[y])
            {
                coded.Append(symbolBySymbol);
            }
            else
            {
                symbolBySymbol = cyper[y];
                coded.Append(symbolBySymbol);
            }
        }


        Console.WriteLine("Coded: {0}",coded.ToString());

        ////////////////////////////////////////////////////////

        cyper = input;

        for (int i = 0, y = 0; i < input.Length; i++, y++)
        {
            if (y == cyper.Length)
            {
                y = 0;
            }
            symbolBySymbol = coded[i];
            if (symbolBySymbol < (char)cyper[y])
            {
                decoded.Append(symbolBySymbol,i);
            }
            else
            {
                symbolBySymbol = cyper[y];
                decoded.Append(symbolBySymbol);
            }
        }


        Console.WriteLine("Decoded(original): {0}", decoded.ToString());




    }
}

