using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ReplaceForbbiddenWords
{
    /*
     We are given a string containing a list of forbidden words and a text containing some of these words.
     * Write a program that replaces the forbidden words with asterisks.
     * Example:
     * 
     * Microsoft announced its next generation PHP compiler today. 
     * It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
     * 
     * Words: "PHP, CLR, Microsoft"
		The expected result:
     * 
     * ********* announced its next generation *** compiler today. 
     * It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

     */
    internal class Program
    {
        public static StringBuilder ReplaceForbbidenWords(string text, IOrderedEnumerable<KeyValuePair<string, List<int>>> sortedLocations)
        {
            const char STAR_SYMBOL = '*';

            StringBuilder result = new StringBuilder();
            int index = 0;

            foreach (var forbiddenWord in sortedLocations)
            {
                foreach (var location in forbiddenWord.Value)
                {
                    for (; index < text.Length; index++)
                    {
                        if (index >= location && index < location + forbiddenWord.Key.Length)
                        {
                            result.Append(STAR_SYMBOL);
                        }
                        else
                        {
                            result.Append(text[index]);
                        }
                        if (index == location + forbiddenWord.Key.Length)
                        {
                            break;
                        }
                    }
                }
            }

            return result;
        }

        public static Dictionary<string, List<int>> AllocateForbbidenWords(string text, string[] forbiddenWords)
        {
            Dictionary<string, List<int>> locationOfForbbidenWords =
                new Dictionary<string, List<int>>();

            foreach (var forbiddenWord in forbiddenWords)
            {
                int indexOfForbiddenWord = 0;

                while (indexOfForbiddenWord >= 0)
                {
                    indexOfForbiddenWord = text.IndexOf(forbiddenWord, indexOfForbiddenWord + 1);
                    if (indexOfForbiddenWord >= 0)
                    {
                        if (locationOfForbbidenWords.ContainsKey(forbiddenWord))
                        {
                            locationOfForbbidenWords[forbiddenWord].Add(indexOfForbiddenWord);
                        }
                        else
                        {
                            locationOfForbbidenWords.Add(forbiddenWord, new List<int>() { indexOfForbiddenWord });
                        }
                    }
                }
            }

            return locationOfForbbidenWords;
        }

        public static IOrderedEnumerable<KeyValuePair<string, List<int>>> SortedLocationsOfForbiddenWords(Dictionary<string, List<int>> locationsOfForbiddenWords)
        {
            var sortedLocations = from forbiddenWord in locationsOfForbiddenWords
                                  orderby forbiddenWord.Value.FirstOrDefault() ascending
                                  select forbiddenWord;

            return sortedLocations;
        }

        static void Main(string[] args)
        {

            string text = " Microsoft announced its next generation PHP compiler today. " +
                          "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };

            Dictionary<string, List<int>> locationsOfForbiddenWords =
                Program.AllocateForbbidenWords(text, forbiddenWords);

            var sortedLocations = Program.SortedLocationsOfForbiddenWords(locationsOfForbiddenWords);

            StringBuilder result = Program.ReplaceForbbidenWords(text,sortedLocations);

            Console.WriteLine(result);
        }
    }
}
