using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MaxIncreasingSequence
{
    public class Program
    {
        /*
         Write a program that finds the maximal increasing sequence in an array.
         Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

         */

        static void Main(string[] args)
        {
            int[] sequence = { 3, 2, 3, 4, 2, 2, 4 };

            int bestSequenceCount = 0;
            int bestSequenceElement = 0;
            int currSequenceCount = 0;
            int currSequenceElement = 0;

            bool toGetFirstElementOfSequence = true;

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] <= sequence[i + 1])
                {
                    currSequenceCount++;
                    if (toGetFirstElementOfSequence)
                    {
                        currSequenceElement = sequence[i];
                        toGetFirstElementOfSequence = false;
                    }
                }
                else
                {
                    if (currSequenceCount > bestSequenceCount)
                    {
                        bestSequenceCount = currSequenceCount;
                        bestSequenceElement = currSequenceElement;
                    }

                    toGetFirstElementOfSequence = true;
                    currSequenceCount = 0;
                }

            }

            Console.WriteLine("Best in " + String.Join(",",sequence) + " is ");
            for (int i = 0; i <= bestSequenceCount; i++)
            {
                
                Console.Write(bestSequenceElement + i);
                if (i < bestSequenceElement)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine();
        }
        
    }
}
