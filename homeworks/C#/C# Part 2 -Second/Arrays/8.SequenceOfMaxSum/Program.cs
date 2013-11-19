using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.SequenceOfMaxSum
{
    public class Program
    {
        /*
         Write a program that finds the sequence of maximal sum in given array. Example:
            {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	    Can you do it with only one loop (with single scan through the elements of the array)?
         */


        // this algorithm will include tha last two elemets {8,-8}, because they don't affect the sum.
        static void Main(string[] args)
        {
            int[] sequence = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int bestSum = int.MinValue;
            int currSum = 0;

            List<int> bestSumElements = new List<int>();

            List<int> currBestSumElements = new List<int>();

            for (int i = 0; i < sequence.Length; i++)
            {
                currSum = currSum + sequence[i];
                currBestSumElements.Add(sequence[i]);

                if (currSum < 0)
                {
                    currSum = 0;
                    currBestSumElements.Clear();
                }

                if (currSum > bestSum)
                {
                    bestSum = currSum;
                    bestSumElements = currBestSumElements;
                }
            }

            Console.WriteLine("Best sum: " + bestSum);
            Console.WriteLine("Best sequence { " + String.Join(",",bestSumElements) + " }");
        }
    }
}
