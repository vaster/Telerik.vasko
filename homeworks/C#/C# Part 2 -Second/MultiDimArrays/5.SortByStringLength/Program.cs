using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SortByStringLength
{
    public class Program
    {
        /*
         You are given an array of strings.
         Write a method that sorts the array by the length of its elements (the number of characters composing them).

         */

        static void Main(string[] args)
        {
            string[] words = { "nqma smisyl", "dai", "dai pak", "kakvooooo" };


            // LINQ
            var sortedWordsByLength = from word in words
                                      orderby word.Length
                                      select word;

            Console.WriteLine("Original: " + String.Join(",",words));
            Console.WriteLine("Sorted: " + String.Join(",",sortedWordsByLength));
        }
    }
}
