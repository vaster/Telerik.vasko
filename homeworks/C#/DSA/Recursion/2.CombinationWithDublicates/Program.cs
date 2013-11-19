using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CombinationWithDublicates
{
    /*Write a recursive program for generating and printing all the combinations with duplicates of k elements from n-element set. Example:
	n=3, k=2  (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
    */
    public class Program
    {
        public static void GenerateCombination(int[] arr, int index, int startNum, int endNum)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine("(" + String.Join(", ", arr) + ")");
            }
            else
            {
                for (int i = 1; i <= endNum; i++)
                {
                    arr[index] = i;
                    Program.GenerateCombination(arr, index + 1, i + 1, endNum);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("N:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K:");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];

            Program.GenerateCombination(arr, 0, 1, n);
        }
    }
}
