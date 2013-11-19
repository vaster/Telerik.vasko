using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractSentances
{
    static void Main(string[] args)
    {
        //Doesn't work.


        /*string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string lookFor = "in";
        string sentenceForPrint;
        int indexOfLookForEmpty = 0;
        int indexOfLookFor = 0;
        int lookForTheEnd = 0;
        int start = 0;
        int indexOfLastSentence = 0;
        StringBuilder sentence = new StringBuilder();
        List<string> print = new List<string>();
        char symbols;
        int i = 0;




        symbols = input[0];
        indexOfLastSentence = input.LastIndexOf('.');
        while (lookForTheEnd != indexOfLastSentence)
        {
            lookForTheEnd++;
            symbols = input[i];
            i++;
            start++;
            //indexOfLookFor = 0;

            sentence.Append(symbols);

            if (symbols == '.')
            {
                //i++;

                Console.WriteLine("i++++{0}", i-1);
                Console.WriteLine("i-start {0}",i-start);
               // Console.WriteLine(sentence);
                sentenceForPrint = string.Empty;
                for (int g = i-start+1; g <= i-1; g++)
                {
                    Console.WriteLine("{0} {1}",sentence[g],g);
                }
                sentenceForPrint = sentence.ToString(i - start, i);

                indexOfLookFor = 0;
                start = 0;

                //indexOfLookFor = sentenceForPrint.IndexOf(lookFor, indexOfLookFor);
                while (indexOfLookFor != -1)
                {
                    //Console.WriteLine("xaxa");

                    indexOfLookFor = sentenceForPrint.IndexOf(lookFor, indexOfLookFor + 1);

                    //Console.WriteLine(sentenceForPrint[indexOfLookFor - 1]);
                    if (sentenceForPrint[indexOfLookFor - 1] == ' ')
                    {
                        //Console.WriteLine(sentenceForPrint[indexOfLookFor - 1]);
                        Console.WriteLine(sentenceForPrint);
                        print.Add(sentenceForPrint);
                        break;
                    }
                }



            }
        }


        for (int y = 0; y < print.Capacity; y++)
        {
            // Console.WriteLine(print[y]);
        }*/
    }
}

