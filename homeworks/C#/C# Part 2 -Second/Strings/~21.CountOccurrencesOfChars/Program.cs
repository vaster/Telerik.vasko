using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.CountOccurrencesOfChars
{
    /*
     * Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 
    */

    internal class Program
    {
        public static Dictionary<char, int> CountOccurences(string text)
        {
            Dictionary<char, int> occurences = new Dictionary<char, int>();

            const int INITIALIZE_COUNT = 1;
            foreach (var symbol in text)
            {
                if (occurences.ContainsKey(symbol))
                {
                    occurences[symbol]++;
                }
                else
                {
                    occurences.Add(symbol, INITIALIZE_COUNT);
                }
            }

            return occurences;
        }

        static void Main(string[] args)
        {
            string text = "When trying to use the Parse method on the DateTime class I get an exception thrown.";

            Dictionary<char, int> occurences = Program.CountOccurences(text);

            foreach (var pair in occurences)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
