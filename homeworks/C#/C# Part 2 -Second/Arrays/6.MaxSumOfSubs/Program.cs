using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MaxSumOfSubs
{
    public class Program
    {
        /*
         Write a program that reads two integer numbers N and K and an array of N elements from the console. 
         Find in the array those K elements that have maximal sum.
         */

        public static void MakeCombination(int[] sequence, int[] bestSumElements, int startIndex, int bestSum)
        {

            if (startIndex > sequence.Length - bestSumElements.Length)
            {
                Console.WriteLine("Best sum of " + bestSumElements.Length + " elements:");
                Console.WriteLine(String.Join(",", sequence));
                Console.WriteLine("Best sum is :" + bestSum);
                Console.WriteLine("Elements of sum: " + String.Join(",", bestSumElements));
                return;
            }

            int currSum = 0;
            int[] currSumElements = new int[bestSumElements.Length];

            for (int i = 0; i < bestSumElements.Length; i++)
            {
                currSum = currSum + sequence[startIndex + i];
                currSumElements[i] = sequence[startIndex + i];
            }

            if (currSum > bestSum)
            {
                bestSum = currSum;
                bestSumElements = currSumElements;
            }

            Program.MakeCombination(sequence, bestSumElements, startIndex + 1, bestSum);
        }

        static void Main(string[] args)
        {
            int n = 9;
            int k = 3;

            int bestSum = int.MinValue;
            int startIndex = 0;

            int[] bestEl = new int[k];

            int[] sequence = { 1, 2, 3, 4, 5, 1000, 6, 8, 8, 11 };

            // recursive method - makes combinatorics easier
            Program.MakeCombination(sequence, bestEl, startIndex, bestSum);
        }
    }
}
