using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.CountOccurencesOfWords
{
    /*
    Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
     */

    internal class Program
    {
        public static string[] SplitWords(string text)
        {
            const char WORD_DELIMITER = ' ';

            string[] splitedWords = text.Split(WORD_DELIMITER);

            return splitedWords;
        }

        public static Dictionary<string, int> CountWordOccurences(string[] words)
        {
            const int INITILIZE_COUNT = 1;

            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (occurrences.ContainsKey(word))
                {
                    occurrences[word]++;
                }
                else
                {
                    occurrences.Add(word, INITILIZE_COUNT);
                }
            }

            return occurrences;
        }

        static void Main(string[] args)
        {
            string text = "Here we see how the DateTime.Parse method works on various date time formats " +
            "several time string formats were found on the Internet and the DateTime.Parse method was used on each " +
            "each call succeeded and returned the expected value";

            string[] words = Program.SplitWords(text);

            Dictionary<string, int> occurences = Program.CountWordOccurences(words);

            foreach (var pair in occurences)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }

        }
    }
}
