using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.LongestSubsequenceOfEquals
{
    /*
     * Write a method that finds the longest subsequence of equal numbers in given List<int> and returns the result as new List<int>.
     * Write a program to test whether the method works correctly.
    */

    public class Program
    {
        static void Main(string[] args)
        {
            ICustomList sample = new CustomList();

            sample.Add(2);
            sample.Add(2);
            sample.Add(2);
            sample.Add(3);
            sample.Add(3);
            sample.Add(2);
            sample.Add(3);
            sample.Add(3);
            sample.Add(3);
            sample.Add(3);
            sample.Add(1);
            sample.Add(2);

            ICustomList subSet = sample.FindLongestSubsetOfEquals();

            Console.WriteLine("Best sequence:");
            Console.Write("{");
            for (int index = 0; index < subSet.Count; index++)
            {
                Console.Write(subSet[index]);
                if (index != subSet.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
        }
    }
}
