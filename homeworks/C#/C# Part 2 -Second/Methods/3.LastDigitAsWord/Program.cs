using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.LastDigitAsWord
{
    public class Program
    {
        public static string GetLastDigitAsEnglishWord(string number)
        {
            char lastDigit = number.Last();

            string digitAsWord = null;

            switch (lastDigit)
            {
                case '0':
                    digitAsWord = "zero";
                    break;
                case '1':
                    digitAsWord = "one";
                    break;
                case '2':
                    digitAsWord = "two";
                    break;
                case '3':
                    digitAsWord = "three";
                    break;
                case '4':
                    digitAsWord = "four";
                    break;
                case '5':
                    digitAsWord = "five";
                    break;
                case '6':
                    digitAsWord = "six";
                    break;
                case '7':
                    digitAsWord = "seven";
                    break;
                case '8':
                    digitAsWord = "eight";
                    break;
                case '9':
                    digitAsWord = "nine";
                    break;
            }

            return digitAsWord;
        }

        static void Main(string[] args)
        {
            string number = "1239093";

            string digitAsWord = Program.GetLastDigitAsEnglishWord(number);

            Console.WriteLine("Last digit of " + number + " as word is: " +digitAsWord);

        }
    }
}
