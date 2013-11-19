using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ExtractSentences
{
    /*
     Write a program that extracts from a given text all sentences containing given word.
		Example: The word is "in". The text is:
     * 
     * We are living in a yellow submarine. We don't have anything else. 
     * Inside the submarine is very tight. So we are drinking all the day.
     * We will move out of it in 5 days.
     * 
     * The expected result is:
     * 
     * We are living in a yellow submarine.
        We will move out of it in 5 days.
     * 
     * Consider that the sentences are separated by "." and the words – by non-letter symbols.

     */

    internal class Program
    {
        public const char SENTENCE_SEPARATOR = '.';

        public const string SEEKED_WORD = "in";

        public static string[] SeparateSentances(string text)
        {
            string[] sentences = text.Split(Program.SENTENCE_SEPARATOR);

            return sentences;
        }

        public static StringBuilder ExtractSenteces(string[] sentences)
        {
            StringBuilder extractedSentances = new StringBuilder();

            char[] wordSeparator = { ',', ' ' };

            foreach (var sentence in sentences)
            {
                int indexOfSeekedWord = 0;

                while (indexOfSeekedWord >= 0)
                {
                    if (sentence == "")
                    {
                        break;
                    }
                    indexOfSeekedWord = sentence.IndexOf(Program.SEEKED_WORD, indexOfSeekedWord + 1);

                    if (indexOfSeekedWord >= 0)
                    {
                        if (sentence[indexOfSeekedWord - 1] == wordSeparator[0] ||
                            sentence[indexOfSeekedWord - 1] == wordSeparator[1] &&

                            sentence[indexOfSeekedWord + Program.SEEKED_WORD.Length] == wordSeparator[0] ||
                            sentence[indexOfSeekedWord + Program.SEEKED_WORD.Length] == wordSeparator[1])
                        {
                            extractedSentances.AppendLine(sentence);
                        }

                    }
                }
            }

            return extractedSentances;
        }

        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else." +
                          "Inside the submarine is very tight. So we are drinking all the day." +
                          "We will move out of it in 5 days.";

            string[] sentences = Program.SeparateSentances(text);

            StringBuilder result = Program.ExtractSenteces(sentences);

            Console.WriteLine(result);
        }
    }
}
