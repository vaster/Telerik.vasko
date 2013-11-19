using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SelectionSort
{
    public class Program
    {
        /*
         Sorting an array means to arrange its elements in increasing order.
         Write a program to sort an array. 
         Use the "selection sort" algorithm: 
         * Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
         */


        public static void Sort(IList<int> collection)
        {
            int min = 0;
            for (int i = 0; i < collection.Count - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[min]) < 0)
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    Program.Swap(collection, min, i);
                }
            }
        }

        private static void Swap(IList<int> collection, int indexToSwap, int indexToSwapWith)
        {
            int tmp = collection[indexToSwap];
            collection[indexToSwap] = collection[indexToSwapWith];
            collection[indexToSwapWith] = tmp;
        }

        static void Main(string[] args)
        {
            IList<int> sequence = new List<int>() { 1, 2, -100, 3, 0, 3, 4, 5 };

            Console.WriteLine("Befour sort: " + String.Join(",",sequence));

            Program.Sort(sequence);

            Console.WriteLine("After sort: " + String.Join(",", sequence));
        }
    }
}
