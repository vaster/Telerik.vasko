using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Palindromes
{
    static void Main(string[] args)
    {
        string inputText;
        int countWords = 0;
        char symbols;
        int coef = 0;
        string reader;
        bool flag = true;
        

        
        //Работи само ако думите завършват с точка(т.е имаме изречение) и след запетаята има празни места.
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

        string[] keepWords= new string[countWords + 1];

        for (int i = 0; i < inputText.Length; i++)
        {
            symbols = inputText[i];
            if (symbols != ' ' && symbols != '.' && symbols != ',' && symbols != '?' && symbols != '!')
            {
                storeWords.Append(symbols);
            }
            else
            {
                keepWords[coef] = storeWords.ToString();
                reader = keepWords[coef];
                for (int z = 0; z < (keepWords[coef].Length)/2; z++)
                {
                    //Console.WriteLine(reader.Length - z-1);
                    if (reader[z] == reader[reader.Length - z-1])
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                    
                }
                if (flag)
                {
                    Console.WriteLine("{0} is valid", reader);
                }
                else
                {
                    Console.WriteLine("{0} is not valid", reader);
                }
                if (!(string.IsNullOrEmpty(storeWords.ToString())))
                {
                    coef++;
                }
                storeWords.Clear();
            }
        }
        
        
    }
}

