using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.AnchtoToURL
{
    /*
     Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
     * Sample HTML fragment:

     * 
     * <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course.
     * Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
     * 
     *                              ||
     *                              \/
     *                              
     * <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course.
     * Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>


     */

    internal class Program
    {
        public const string OPENNING_ANCHOR_TAG = "<a href=\"";

        public const string CLOSING_ANCHOR_TAG = "</a>";

        public const string OPENNING_ANCHOR_CLOSER_TAG = "\">";

        public const string OPENNING_URL_TAG = "[URL=";

        public const string CLOSING_URL_TAG = "[/URL]";

        public const string OPENNING_URL_CLOSER_TAG = "]";


        public static StringBuilder ParseAnchorElementToURLElement(string text)
        {
            StringBuilder result = new StringBuilder();

            int indexOfAnchorOpenningTag = 0;
            int indexOfAnchorClosingString = 0;
            int indexOfAnchorClosingTag = 0;
            int index = 0;
            bool toAddOpenningURL = false;
            bool toAddOpenningURLCloser = false;
            bool toAddClosingURLTag = false;

            while (indexOfAnchorOpenningTag >= 0)
            {
                indexOfAnchorOpenningTag = text.IndexOf(Program.OPENNING_ANCHOR_TAG, indexOfAnchorOpenningTag + 1);
                indexOfAnchorClosingString = text.IndexOf(Program.OPENNING_ANCHOR_CLOSER_TAG, indexOfAnchorClosingString + 1);
                indexOfAnchorClosingTag = text.IndexOf(Program.CLOSING_ANCHOR_TAG, indexOfAnchorClosingTag + 1);


                for (; index < text.Length; index++)
                {
                    if (index >= indexOfAnchorOpenningTag && index < indexOfAnchorOpenningTag + Program.OPENNING_ANCHOR_TAG.Length)
                    {
                        toAddOpenningURL = true;
                        continue;
                    }
                    if (index > indexOfAnchorClosingString - 1 && index <= indexOfAnchorClosingString + 1)
                    {
                        toAddOpenningURLCloser = true;
                        continue;
                    }
                    if (index > indexOfAnchorClosingTag - 1 && index <= indexOfAnchorClosingTag + Program.CLOSING_ANCHOR_TAG.Length)
                    {
                        toAddClosingURLTag = true;
                        continue;
                    }
                    else
                    {
                        if (toAddOpenningURL)
                        {
                            result.Append(Program.OPENNING_URL_TAG);
                            toAddOpenningURL = false;
                        }
                        if (toAddOpenningURLCloser)
                        {
                            result.Append(Program.OPENNING_URL_CLOSER_TAG);
                            toAddOpenningURLCloser = false;
                        }
                        if (toAddClosingURLTag)
                        {
                            result.Append(Program.CLOSING_URL_TAG);
                            toAddClosingURLTag = false;
                            break;  
                        }

                        result.Append(text[index]);
                    }
                }
            }

            return result;
        }

        static void Main(string[] args)
        {

            string text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course." +
                          "Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            StringBuilder result = Program.ParseAnchorElementToURLElement(text);
            Console.WriteLine(result);

        }
    }
}
