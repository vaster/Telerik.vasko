using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ToUpperCase
{

    /*
     You are given a text.
     Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.
     The tags cannot be nested. Example:
     
     We are living in a <upcase>yellow submarine</upcase>.
     We don't have <upcase>anything</upcase> else.
     
     The expected result:

     We are living in a YELLOW SUBMARINE.
     We don't have ANYTHING else.
     
     */
    internal class Program
    {
        public const string UPPERCASE_OPENNING_TAG = "<upcase>";
        public const string UPPERCASE_CLOSING_TAG = "</upcase>";

        public static StringBuilder ToUpperCase(string text)
        {
            StringBuilder result = new StringBuilder();
            bool toUpper = false;

            int indexOfOpenningTag = 0;
            int indexOfClosingTag = 0;
            int i = 0;

            while (indexOfOpenningTag >= 0)
            {

                indexOfOpenningTag = text.IndexOf(Program.UPPERCASE_OPENNING_TAG, indexOfOpenningTag + 1);
                indexOfClosingTag = text.IndexOf(Program.UPPERCASE_CLOSING_TAG, indexOfClosingTag + 1);

                for (; i < text.Length; i++)
                {
                    if (i >= indexOfOpenningTag && i < indexOfOpenningTag + Program.UPPERCASE_OPENNING_TAG.Length)
                    {
                        continue;
                    }
                    if (i >= indexOfClosingTag && i < indexOfClosingTag + Program.UPPERCASE_CLOSING_TAG.Length)
                    {
                        continue;
                    }
                    if (i >= indexOfOpenningTag + Program.UPPERCASE_OPENNING_TAG.Length && i < indexOfClosingTag)
                    {
                        toUpper = true;
                    }
                    if (i == indexOfClosingTag + Program.UPPERCASE_CLOSING_TAG.Length)
                    {
                        break;
                    }
                    if (!toUpper)
                    {
                        result.Append(text[i]);
                    }
                    else
                    {
                        result.Append(text[i].ToString().ToUpper());
                    }
                    toUpper = false;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>." +
                          "We don't have <upcase>anything</upcase> else.";

            StringBuilder result = Program.ToUpperCase(text);

            Console.WriteLine(result);
        }
    }
}
