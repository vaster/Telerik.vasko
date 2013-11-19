using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BinarySearch
{
    public class Program
    {

        /*
         Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
         */

        public static bool BinarySearch(IList<int> sequence, int item)
        {
            bool founded = false;
            Program.GoDeep(sequence, item, ref founded);

            return founded;
        }

        private static void GoDeep(IList<int> collection, int item, ref bool founded)
        {
            List<int> befour = new List<int>();
            List<int> after = new List<int>();

            int seekedElement = 0;

            int middleIndex = collection.Count / 2;
            if (collection.Count != 0)
            {
                seekedElement = collection[middleIndex];

                if (seekedElement.CompareTo(item) == 0)
                {
                    founded = true;
                }

                for (int i = 0; i < middleIndex; i++)
                {
                    befour.Add(collection[i]);
                }
                for (int i = middleIndex + 1; i < collection.Count; i++)
                {
                    after.Add(collection[i]);
                }

                Program.GoDeep(befour, item, ref founded);
                Program.GoDeep(after, item, ref founded);
            }
        }

        static void Main(string[] args)
        {
            IList<int> sequence = new List<int>() { 1, 2, 3, 4, 10, -1, 0, 3 };
            int seekedItem = 10;

            bool result = Program.BinarySearch(sequence, seekedItem);

            Console.WriteLine("{" + String.Join(",",sequence) + "} Contains " + seekedItem + ": " + result);

            seekedItem = 12;

            result = Program.BinarySearch(sequence, seekedItem);

            Console.WriteLine("{" + String.Join(",", sequence) + "} Contains " + seekedItem + ": " + result);

        }
    }
}
