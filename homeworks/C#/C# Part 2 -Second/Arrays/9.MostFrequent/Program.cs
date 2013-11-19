using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.MostFrequent
{
    public class Program
    {
        /*
         Write a program that finds the most frequent number in an array. Example:
	        {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
         */
        static void Main(string[] args)
        {
            int[] sequence = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            List<int> sequenceWithNoRepeatings = new List<int>();
            List<int> occurences = new List<int>();

            int indexToAddAt = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                indexToAddAt = 0;

                if (!sequenceWithNoRepeatings.Contains(sequence[i]))
                {
                    sequenceWithNoRepeatings.Add(sequence[i]);
                    occurences.Add(1);
                }
                else
                {
                    indexToAddAt = sequenceWithNoRepeatings.IndexOf(sequence[i]);
                    occurences[indexToAddAt]++;
                }
            }

            int maxOccurence = occurences.Max();
            int postion = occurences.IndexOf(maxOccurence);

            Console.WriteLine("Sequence: " + String.Join(",", sequence));
            Console.WriteLine(sequenceWithNoRepeatings[postion] + " -> " + occurences[postion] + " times");
        }
    }
}
