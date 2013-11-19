using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.HTMLExtractor
{
    /*
    Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
     * Example:
     * 
     * <html>
        <head><title>News</title></head>
        <body><p><a href="http://academy.telerik.com">Telerik
          Academy</a>aims to provide free real-world practical
          training for young people who want to turn into
          skillful .NET software engineers.</p></body>
       </html>

     */

    internal class Program
    {
        public const char OPENNING_TAG_SYMBOL = '<';

        public const char CLOSING_TAG_SYMBOL = '>';

        public static StringBuilder ExtractInformation(string html)
        {
            StringBuilder result = new StringBuilder();

            int openningCount = 0;
            int closingCount = 0;

            foreach (var symbol in html)
            {
                if (symbol == Program.OPENNING_TAG_SYMBOL)
                {
                    openningCount++;
                }
                if (symbol == Program.CLOSING_TAG_SYMBOL)
                {
                    closingCount++;
                }
                if (openningCount == closingCount &&
                    symbol != Program.OPENNING_TAG_SYMBOL && symbol != Program.CLOSING_TAG_SYMBOL)
                {
                    result.Append(symbol);
                }
            }

            return result;
        }

        static void Main(string[] args)
        {

            string html = "<html>" +
                          "<head><title>News</title></head>" +
                          "<body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a> aims to provide free real-world practical" +
                             " training for young people who want to turn into" +
                             " skillful .NET software engineers.</p></body>" +
                          "</html>";

            StringBuilder result = Program.ExtractInformation(html);

            Console.WriteLine(result);
        }
    }
}