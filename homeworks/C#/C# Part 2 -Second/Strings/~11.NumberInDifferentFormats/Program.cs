using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumberInDifferentFormats
{
    /*
     Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. 
     *Format the output aligned right in 15 symbols.

     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 123;

            Console.WriteLine("{0,15:D}", number);
            Console.WriteLine("{0,15:X}", number);
            Console.WriteLine("{0,15:P}", number);
            Console.WriteLine("{0,15:E}", number);
        }
    }
}
