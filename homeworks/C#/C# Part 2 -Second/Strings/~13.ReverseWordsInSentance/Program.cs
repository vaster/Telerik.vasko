using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ReverseWordsInSentance
{
    /*
     Write a program that reverses the words in given sentence.
	Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".
     */

    internal class Program
    {
        private static char[] wordSeparators = { ' ', '!', '.', ',', '?' };

        public static string[] ExtractWords(string text)
        {
            string[] words = text.Split(Program.wordSeparators, StringSplitOptions.RemoveEmptyEntries);

            return words;
        }

        public static Dictionary<int, char> GetLocationsOfWordSeparators(string text, string[] words)
        {
            Dictionary<int, char> separatorLocations = new Dictionary<int, char>();

            for (int i = 0; i < words.Length; i++)
            {
                int indexOfWord = 0;


                indexOfWord = text.IndexOf(words[i], indexOfWord);
                if (indexOfWord >= 0)
                {
                    separatorLocations.Add(i + 1, text[indexOfWord + words[i].Length]);
                }
            }

            return separatorLocations;
        }


        public static StringBuilder ReverseWordsInSentance(string[] words, Dictionary<int, char> separatorLocations)
        {
            StringBuilder result = new StringBuilder();

            for (int i = words.Length - 1, separatorIndex = 0; i >= 0; i--, separatorIndex++)
            {
                result.Append(words[i]);
                result.Append(separatorLocations[separatorIndex + 1]);
            }

            return result;
        }

        static void Main(string[] args)
        {
            string text = "C# is not C++, not PHP and not Delphi!";

            string[] words = Program.ExtractWords(text);

            Dictionary<int, char> separatorLocations = Program.GetLocationsOfWordSeparators(text, words);

            StringBuilder result = Program.ReverseWordsInSentance(words, separatorLocations);

            Console.WriteLine("Original: " + text);
            Console.WriteLine(result);
        }
    }
}
