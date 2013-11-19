using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Variation
{
    /*
     Write a recursive program for generating and printing all ordered k-element subsets from n-element set (variations Vkn).
	Example: n=3, k=2, set = {hi, a, b} =>
	(hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
     
     */
    public class Program
    {
        public static void GenVariation(string[] set,string[] variation, int index)
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
                    Program.GenVariation(set,variation,index+1);
                }
            }
        }
        static void Main(string[] args)
        {
            int n = 3;
            int k = 2;
            string[] set = { "hi","a","b"};
            string[] variation = new string[k];

            Program.GenVariation(set,variation,0);
        }
    }
}
