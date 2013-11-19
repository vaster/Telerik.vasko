using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.WordsInAlphabeticalOrder
{
    /*
     Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
     */

    internal class Program
    {
        public static string[] SplitWords(string text)
        {
            const char WORD_DELIMITER = ' ';

            string[] splitedWords = text.Split(WORD_DELIMITER);

            return splitedWords;
        }


        static void Main(string[] args)
        {

            string text = "Here we see how the DateTime.Parse method works on various date time formats " +
           "several time string formats were found on the Internet and the DateTime.Parse method was used on each " +
           "each call succeeded and returned the expected value";

            string[] words = Program.SplitWords(text);

            Array.Sort(words);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
