using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string inputText;
        int countWords = 0;
        char symbols;
        int coef = 0;
        int sepCoef = 0;
        int flag = 0;
        //Работи ако след всяка запетая се слага празно разтояние.
        StringBuilder separators = new StringBuilder();

        StringBuilder storeWords = new StringBuilder();

        Console.Write("Enter text:");
        inputText = Console.ReadLine();

        for (int i = 0; i < inputText.Length; i++)
        {
            symbols = inputText[i];
            if (symbols == ' ')
            {
                countWords++;
            }
        }
        //Console.WriteLine(countWords);
        string[] keepWordsReversed = new string[countWords + 1];

        for (int i = 0; i < inputText.Length; i++)
        {
            symbols = inputText[i];
            if (symbols != ' ' && symbols != '.' && symbols != ',' && symbols != '?' && symbols != '!')
            {
                storeWords.Append(symbols);
                //Console.WriteLine(storeWords);
            }
            else
            {
                symbols = inputText[i];
                
                char symbols2 = inputText[i - 1];
              
                if (symbols == ' ' && symbols2 != ',')
                {

                    separators.Append(symbols);
                    //Console.WriteLine(separators);
                }
                if (symbols != ' ')
                {
                    separators.Append(symbols);
                }
                //Console.WriteLine(separators);
                if (!(string.IsNullOrEmpty(storeWords.ToString())))
                {
                    storeWords.Append(' ');
                }
                if (keepWordsReversed.Length - 1 - coef >= 0)
                {
                    //Console.WriteLine(storeWords);
                    keepWordsReversed[keepWordsReversed.Length - 1 - coef] = storeWords.ToString();
                    if (!(string.IsNullOrEmpty(storeWords.ToString())))
                    {
                        coef++;
                    }
                    storeWords.Clear();
                }
            }
        }
        storeWords.Clear();
        for (int y = 0; y < keepWordsReversed.Length; y++)
        {

            for (int i = 0; i < keepWordsReversed[y].Length; i++)
            {
                string words;
                words = keepWordsReversed[y];

                symbols = words[i];
                //Console.WriteLine(symbols);


                if (symbols == ' ')
                {

                    symbols = separators[sepCoef];
                    //Console.WriteLine(symbols);
                    sepCoef++;
                    flag++;
                }
                storeWords.Append(symbols);
                if (flag > 0)
                {
                    storeWords.Append(' ');
                    flag--;
                }
            }
        }
        //for (int i = 0; i < keepWordsReversed.Length; i++)
        {
            Console.Write(storeWords.ToString());
        }

    }
}

