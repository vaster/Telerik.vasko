using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FillWithStarts
{
    /*
     Write a program that reads from the console a string of maximum 20 characters.
     If the length of the string is less than 20, the rest of the characters should be filled with '*'.
     Print the result string into the console.
     */

    internal class Program
    {
        public const int MAX_SIZE = 20;
        public const char STAR_SYMBOL = '*';

        public static StringBuilder FillWithStarts(string text)
        {
            StringBuilder result = new StringBuilder();

            result.Append(text);

            if (result.Length < Program.MAX_SIZE)
            {
                for (int i = result.Length; i < Program.MAX_SIZE; i++)
                {
                    result.Append(Program.STAR_SYMBOL);
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            string notFullText = "asdfghjklqwerty";
            string fullText = "asdfghjklqwertyuiopz";

            Console.WriteLine("Not full text:");
            Console.WriteLine(Program.FillWithStarts(notFullText));

            Console.WriteLine();

            Console.WriteLine("Full text:");
            Console.WriteLine(Program.FillWithStarts(fullText));
        }
    }
}
