using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BinSearch
{
    public class Program
    {

        /*
         Write a program, that reads from the console an array of N integers and an integer K,
         * sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
         */

        static void Main(string[] args)
        {
            // K
            int k = 6;

            int[] sequence = { 1, 2, 3, 6, 12, 100, 5 };

            Array.Sort(sequence);

            int result = Array.BinarySearch(sequence,k);

            if (result < 0)
            {
                Console.WriteLine("Result: " + sequence[result * (-1) - 2]);
            }
            else
            {
                Console.WriteLine("Result: " + sequence[result]);
            }
        }
    }
}
