using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.Permutaion
{
    public class Program
    {
        /*
         * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
         * Example:
	        n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

         */

        public static void GeneratePermutation(int[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                Console.WriteLine("(" + String.Join(", ", arr) + ")");
            }

            else
            {
                for (int i = index; i < arr.Length; i++)
                {

                    int tmp = arr[index];
                    arr[index] = arr[i];
                    arr[i] = tmp;

                    Program.GeneratePermutation(arr, index + 1);

                    tmp = arr[index];
                    arr[index] = arr[i];
                    arr[i] = tmp;
                }
            }
        }
        static void Main(string[] args)
        {
            // N
            int n = 3;

            int[] arr = new int[n];
            // initilize
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            Program.GeneratePermutation(arr, 0);
        }
    }
}
