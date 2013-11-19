using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.SequenceBySumPattern
{
    public class Program
    {

        /*
         Write a program that finds in given array of integers a sequence of given sum S (if present). 
         Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
         
         */

        public static void MakeCombination(int[] sequence, List<int> bestSequenceElements, int startIndex, int seekedSum)
        {
            if (startIndex >= sequence.Length)
            {
                return;
            }

            int currSum = 0;
            List<int> bestCurrSequenceOFelemetns = new List<int>();

            for (int i = startIndex; i < sequence.Length; i++)
            {
                currSum = currSum + sequence[i];
                bestCurrSequenceOFelemetns.Add(sequence[i]);

                if (currSum > seekedSum)
                {
                    break;
                }
                if (currSum == seekedSum)
                {
                    bestSequenceElements = bestCurrSequenceOFelemetns;


                    Console.WriteLine("S = " + seekedSum);
                    Console.WriteLine("Sequnce elements { " + String.Join(",", sequence) + " }");
                    if (bestSequenceElements.Count > 0)
                    {
                        Console.WriteLine("Best sequence elements { " + String.Join(",", bestSequenceElements) + " } = " + seekedSum);
                    }
                    else
                    {
                        Console.WriteLine("No such subset!");
                    }
                    return;
                }

            }

            Program.MakeCombination(sequence, bestSequenceElements, startIndex + 1, seekedSum);

        }

        static void Main(string[] args)
        {

            int[] sequence = { 4, 3, 1, 4, 2, 5, 8 };
            List<int> bestSequenceElements = new List<int>();
            int startIndex = 0;
            int seekedSum = 11;

            Program.MakeCombination(sequence, bestSequenceElements, startIndex, seekedSum);
        }
    }
}
