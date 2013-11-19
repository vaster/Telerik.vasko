using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Variation
{
    public class Program
    {
        /*
         Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	        N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
         
         */

        public static void GenVariation(int[] set, int[] variation, int index)
        {
            if (index >= variation.Length)
            {
                Console.WriteLine("(" + String.Join(", ", variation) + ")");
            }
            else
            {
                for (int i = 0; i < set.Length; i++)
                {
                    variation[index] = set[i];
                    Program.GenVariation(set, variation, index + 1);
                }
            }
        }
        static void Main(string[] args)
        {
            // N
            int n = 3;
            // K
            int k = 2;

            int[] set = new int[n];

            // initilize
            for (int i = 0; i < n; i++)
            {
                set[i] = i + 1;
            }
           
            int[] variation = new int[k];

            Program.GenVariation(set, variation, 0);
        }
    }
}
