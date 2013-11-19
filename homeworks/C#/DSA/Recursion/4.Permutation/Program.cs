using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Permutation
{
    /*
      Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given integer number n. 
      Example:
	    n=3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3},		
              {2, 3, 1}, {3, 1, 2},{3, 2, 1}
    */
    public class Program
    {
        public static void GeneratePermutation(int[] arr, int index, int endNum)
        {
            if (index == 0)
            {
                Console.WriteLine("(" + String.Join(", ", arr) + ")");
            }

            else
            {
                for (int i = 1; i <= endNum; i++)
                {

                    int tmp = arr[index];
                    arr[index] = arr[i - 1];
                    arr[i - 1] = tmp;

                    Program.GeneratePermutation(arr, index - 1, endNum);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("N:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[] { 1, 2, 3 };

            Program.GeneratePermutation(arr, n - 1, n);
        }
    }
}
