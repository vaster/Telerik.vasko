using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.NormalizeString
{
    /*
     Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
     * Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".
     */

    internal class Program
    {
        public static StringBuilder Normalize(string text)
        {
            StringBuilder result = new StringBuilder();
            char previousSymbol = '\0';

            foreach (var symbol in text)
            {
                if (previousSymbol != symbol)
                {
                    result.Append(symbol);
                }
                previousSymbol = symbol;
            }

            return result;
        }

        static void Main(string[] args)
        {
            string text = "aaaaabbbbbcdddeeeedssaa";

            StringBuilder result = Program.Normalize(text);

            Console.WriteLine(result);
        }
    }
}
