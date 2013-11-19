using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SubsetsOfStrings
{
    /*
     Write a program for generating and printing all subsets of k strings from given set of strings.
	Example: s = {test, rock, fun}, k=2
	(test rock),  (test fun),  (rock fun)

     */
    public class Program
    {
        public static void GenSubsets(string[] s, string[] subsets, int index, int startIndex)
        {
            if (index >= subsets.Length)
            {
                Console.WriteLine("(" + String.Join(", ", subsets) + ")");
            }
            else
            {
                for (int i = startIndex; i < s.Length; i++)
                {
                    subsets[index] = s[i];

                    Program.GenSubsets(s,subsets, index + 1, i + 1);
                }
            }
        }
        static void Main(string[] args)
        {
            int k = 2;
            string[] s = {"test","rock","fun" };
            string[] subsets = new string[k];

            Program.GenSubsets(s,subsets,0,0);
        }
    }
}
