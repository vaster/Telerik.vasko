using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ToUnicode
{
    static void Main(string[] args)
    {
        string input;
        string formatPrint;
        char symbol;
        StringBuilder unicode = new StringBuilder();
        int charNumber = 0;
        int counterForZeros=0;
        int zeroPerforfmer;

        Console.Write("Enter text:");
        input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            symbol = input[i];
            charNumber = symbol;
            zeroPerforfmer=charNumber;
            counterForZeros = 0;
            do
            {
                zeroPerforfmer=zeroPerforfmer/10;
                counterForZeros++;
                //Console.WriteLine(counterForZeros);
            }while(zeroPerforfmer!=0);
            counterForZeros = 4 - counterForZeros;
            unicode.Append("\\u");
            for (int y = 0; y < counterForZeros; y++)
            {
                unicode.Append("0");
            }
            unicode.Append(charNumber);
        }
        formatPrint = String.Format("Result {0}",unicode.ToString());

        Console.WriteLine(formatPrint);
    }
}

