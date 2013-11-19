using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Combination
{
    public class Program
    {

        /*
         Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
         Example:
	        N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
         */


        public static void GenerateCombination(int[] arr, int index, int startNum, int endNum)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine("(" + String.Join(", ", arr) + ")");
            }
            else
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    arr[index] = i;
                    Program.GenerateCombination(arr, index + 1, i + 1, endNum);
                }
            }
        }
        static void Main(string[] args)
        {
            // N
            int n = 5;
            // K
            int k = 2;

            int[] arr = new int[k];

            Program.GenerateCombination(arr, 0, 1, n);
        }
    }
}
