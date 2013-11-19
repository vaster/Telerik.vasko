using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.SubsetOfSumByPattern
{
    public class Program
    {

        /*
         * Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
         * Find in the array a subset of K elements that have sum S or indicate about its absence.

         */

        public static void GenerateCombination(int[] sequence, int[] arr, int index, int startNum, int endNum, int seekedSum)
        {
            if (index >= arr.Length)
            {
                if (arr.Sum() == seekedSum)
                {
                    Console.WriteLine("(" + String.Join(", ", arr) + ") = " + seekedSum);
                }
            }
            else
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    arr[index] = sequence[i];
                    Program.GenerateCombination(sequence, arr, index + 1, i + 1, endNum, seekedSum);
                }
            }
        }

        static void Main(string[] args)
        {

            int[] sequence = { 2, 1, 2, 4, 3, 5, 2, 6 };
            int seekedSum = 7;
            int k = 3;

            Console.WriteLine("All possible combinations:");
            {
                Program.GenerateCombination(sequence, new int[k], 0, 0, sequence.Length - 1, seekedSum);
            }
        }
    }
}
