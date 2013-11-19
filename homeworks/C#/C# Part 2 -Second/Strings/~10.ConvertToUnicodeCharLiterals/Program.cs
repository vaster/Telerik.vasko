using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ConvertToUnicodeCharLiterals
{
    /*
     Write a program that converts a string to a sequence of C# Unicode character literals.
     * Use format strings.
     * Sample input:
     *  Hi!

		Expected output:
     *  \u0048\u0069\u0021
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            string sample = "Hi!";

            Console.WriteLine();

            foreach (var symbol in sample)
            {
                Console.Write("\\u{0:X4}", Convert.ToUInt16(symbol));
            }
        }
    }
}
