using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UpperCase
{
    static void Main(string[] args)
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string finalText = text;
        StringBuilder oldValue = new StringBuilder();
        StringBuilder newValue = new StringBuilder();
        int indexStart=0;
        int indexEnd=0;
        char symbol;
        int counter = 1;

        indexStart = text.IndexOf("<upcase>");
        while (indexStart!=-1)
        {
            indexStart = text.IndexOf("<upcase>",indexStart+1);
            counter++;
        }

        indexStart = -1;
        indexEnd = -1;
        for (int z = 0; z < counter; z++)
        {


            indexStart = text.IndexOf("<upcase>",indexStart+1);
            indexEnd = text.IndexOf("</upcase>",indexEnd+1);
            if (indexEnd == -1)
            {
                break;
            }
            //Console.WriteLine(indexEnd);
            oldValue.Clear();
            newValue.Clear();
            for (int i = indexStart; i <= indexEnd + 8; i++)
            {
                
                //Console.WriteLine("{0},{1}",i,text[i]);
                oldValue.Append(text[i]);
            }
            for (int i = indexStart + 8; i < indexEnd; i++)
            {
                //symbol = text[i];
                
                newValue.Append(text[i].ToString().ToUpper());

            }

            finalText = finalText.Replace(oldValue.ToString(), newValue.ToString());
        }
        Console.WriteLine(finalText);
        
    }
}

