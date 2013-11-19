using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.SubsetOfASum
{
    public class Program
    {

        /*
         * We are given an array of integers and a number S.
         * Write a program to find if there exists a subset of the elements of the array that has a sum S.
         * Example:
	        arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

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
            int seekedSum = 14;
           
            Console.WriteLine("All possible combinations:");
            for (int i = 1; i <= sequence.Length; i++)
            {
                Program.GenerateCombination(sequence, new int[i], 0, 0, sequence.Length - 1, seekedSum);
             }
        }
    }
}
