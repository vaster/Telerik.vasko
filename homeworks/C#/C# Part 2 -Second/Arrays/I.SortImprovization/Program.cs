using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.SortImprovization
{
    class Program
    {
        /*
         * Write a program that reads an array of integers and removes from it a minimal number of elements in 
            * such way that the remaining array is sorted in increasing order. Print the remaining sorted array. 
         * Example:
	        {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

         */

        // TODO:
        public static void Interate(int[] sequence, List<int> bestSortingComb,ref int bestSortedSubsLength, int startIndex)
        {
            List<int> currSequence = new List<int>();
            int currSortedSubLength = 1;

            currSequence.Add(sequence[startIndex]);

            int currBestNumber = sequence[startIndex];

            for (int i = startIndex + 1; i < sequence.Length; i++)
            {
                if (currBestNumber <= sequence[i])
                {
                    currSequence.Add(sequence[i]);
                    currBestNumber = sequence[i];
                    currSortedSubLength++;
                }
            }

            if (currSortedSubLength > bestSortedSubsLength)
            {
                bestSortedSubsLength = currSortedSubLength;
                bestSortingComb.Clear();
                bestSortingComb.AddRange(currSequence);
            }
        }


        static void Main(string[] args)
        {
            int[] sequence = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };

            List<int> bestSortingCombinations = new List<int>();

            int bestSortedSubsetLenght = int.MinValue;

            for (int i = 0; i < sequence.Length; i++)
            {
                Program.Interate(sequence,bestSortingCombinations,ref bestSortedSubsetLenght,i);
            }

            Console.WriteLine("Original " + String.Join(",",sequence));
            Console.WriteLine("Best Sorted " + String.Join(",",bestSortingCombinations));

        }
    }
}
