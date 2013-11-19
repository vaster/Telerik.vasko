using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountSubstring
{
    static void Main(string[] args)
    {
        string text;
        string word;
        int index=0;
        int counter = 0;

        Console.Write("Enter some text:");
        text = Console.ReadLine();

        Console.Write("Enter word to search for:");
        word = Console.ReadLine();

        index = text.IndexOf(word);
        //counter++;
        while (index != -1)
        {
            index = text.IndexOf(word,index+1,StringComparison.CurrentCultureIgnoreCase);
            counter++;
        }

        Console.WriteLine("Result: {0}",counter);
    }


}

