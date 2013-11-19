using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CombinationWithNoDublicates
{
    /*Modify the previous program to skip duplicates:
        n=4, k=2  (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
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
                for (int i = startNum; i <= endNum; i++)
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
