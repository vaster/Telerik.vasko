using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MaxSequenceOfEquals
{
    public class Program
    {
        /*
        Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
         */

        static void Main(string[] args)
        {

            int[] sequence = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            int bestSequenceCount = 0;
            int bestSequenceElement = 0;
            int currSequenceCount = 0;
            int currSequenceElement = 0;

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    currSequenceCount++;
                    currSequenceElement = sequence[i];
                }
                else
                {
                    if (currSequenceCount > bestSequenceCount)
                    {
                        bestSequenceCount = currSequenceCount;
                        bestSequenceElement = currSequenceElement;
                    }

                    currSequenceCount = 0;
                }

            }

            Console.WriteLine("Best in " + String.Join(",",sequence) + " is ");
            for (int i = 0; i <= bestSequenceCount; i++)
            {
                
                Console.Write(bestSequenceElement);
                if (i < bestSequenceElement)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine();
        }
    }
}
