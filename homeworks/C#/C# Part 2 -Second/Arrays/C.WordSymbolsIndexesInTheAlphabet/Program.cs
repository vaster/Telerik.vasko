using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.WordSymbolsIndexesInTheAlphabet
{
    public class Program
    {
        /*
         Write a program that creates an array containing all letters from the alphabet (A-Z).
         Read a word from the console and print the index of each of its letters in the array.

         */

        static void Main(string[] args)
        {
            const int ALPHABET_LENGHT = 26;

            const char FIRST_LETER  = 'a';

            char[] alphabet = new char[ALPHABET_LENGHT];

            // initilize alhpabet
            for (int i = 0; i < ALPHABET_LENGHT; i++)
            {
                alphabet[i] = (char)(FIRST_LETER + i);
            }

            // diffrent casing
            string word = "AlpHabeT";
            StringBuilder result = new StringBuilder();
            int indexInAlphabet = 0;

            foreach (char letter in word)
            {
                char letterToLower = '\0';
                indexInAlphabet = 0;

                result.Append(letter + " -> ");

                // ascii code of 'a' == 97 (we work with lowercase) so a sample convertion is needed
                // ascii code of 'A' == 65, so 'A'(65) will be converted to 'a'(97), how -> 65(a) + 32(difference) = 97(A)
                if (letter < 97)
                {
                    letterToLower = (char)(letter + 32);
                }
                else
                {
                    letterToLower = letter;
                }

                indexInAlphabet = Array.IndexOf(alphabet,letterToLower);

                result.AppendLine(indexInAlphabet.ToString());
                
            }

            Console.WriteLine(result);
            
        }
    }
}
