using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.GetMaxPlusSort
{
    public class Program
    {
        private static int GetMax(int[] array, int startIndex, int endIndex)
        {
            int max = int.MinValue;
            int index = -1;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }

            Program.Swap(array, index, startIndex);

            return max;

        }

        private static void Swap(int[] array, int index, int startIndex)
        {
            int tmp = array[index];
            array[index] = array[startIndex];
            array[startIndex] = tmp;
        }

        public static int[] Sort(int[] array, bool ascending)
        {
            int[] result = new int[array.Length];

            if (ascending)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    result[i] = Program.GetMax(array, i, array.Length - 1);
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int index = array.Length - 1 - i;

                    result[index] = Program.GetMax(array, i, array.Length - 1);
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] array = { 0, -100, 2, 3, 90, 5, 0 };

            Console.WriteLine("Original: " + String.Join(",", array));

            ICollection<int> resultAsc = Program.Sort(array,true);

            Console.WriteLine("Sort(Ascending):" + String.Join(",", resultAsc));

            ICollection<int> resultDsc = Program.Sort(array, false);

            Console.WriteLine("Sort(Descending):" + String.Join(",", resultDsc));
        }
    }
}
