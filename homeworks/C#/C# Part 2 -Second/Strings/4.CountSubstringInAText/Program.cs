using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CountSubstringInAText
{
    /*
         Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
		Example: The target substring is "in". The text is as follows:

         We are living in an yellow submarine. We don't have anything else.
         Inside the submarine is very tight.
         So we are drinking all the day.
         We will move out of it in 5 days.
         
         The result is: 9.

         */

    internal class Program
    {
        public const string SEEKED_SUBSTRING = "in";

        public static int CountSubstring(string text)
        {
            int count = 0;

            int startIndex = 0;

            while (startIndex >= 0)
            {
                startIndex = text.IndexOf(Program.SEEKED_SUBSTRING, startIndex + 1);
                count++;
            }

            return count;
        }

        static void Main(string[] args)
        {

            string text = "We are living in an yellow submarine. We don't have anything else." +
                          "Inside the submarine is very tight." +
                          "So we are drinking all the day." +
                          "We will move out of it in 5 days.";


            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine("Seeked substring is " + "'" + Program.SEEKED_SUBSTRING + "'");
            Console.WriteLine("restult is " + Program.CountSubstring(text));


        }
    }
}
