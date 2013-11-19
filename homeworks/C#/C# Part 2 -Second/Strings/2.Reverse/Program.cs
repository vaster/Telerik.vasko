using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Reverse
{
    /*
     Write a program that reads a string, reverses it and prints the result at the console.
        Example: "sample" -> "elpmas".
     */

    internal class Program
    {
     
        static void Main(string[] args)
        {
            string sample = "sample";

            IEnumerable<char> result = sample.Reverse();

            Console.WriteLine("Original: " + sample);
            Console.Write("After reverse: ");
            foreach (var symbol in result)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}
