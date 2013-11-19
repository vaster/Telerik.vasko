using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.MergeSort
{
    public class Program
    {
        /*
         Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
         */


        public static void Sort(IList<int> collection)
        {
            Program.DivideCollection(collection);
        }

        private static void DivideCollection(IList<int> collection)
        {
            if (collection.Count == 1)
            {
                return;
            }

            IList<int> leftPart = new List<int>();
            IList<int> rightPart = new List<int>();

            int middleIndex = collection.Count / 2;

            for (int i = 0; i < middleIndex; i++)
            {
                leftPart.Add(collection[i]);
            }

            for (int i = middleIndex; i < collection.Count; i++)
            {
                rightPart.Add(collection[i]);
            }

            Program.DivideCollection(leftPart);
            Program.DivideCollection(rightPart);

            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (leftPart.Count == 0)
                {
                    collection[i] = rightPart.Last();
                    rightPart.Remove(rightPart.Last());
                }
                else if (rightPart.Count == 0)
                {
                    collection[i] = leftPart.Last();
                    leftPart.Remove(leftPart.Last());
                }
                else if (leftPart.Last().CompareTo(rightPart.Last()) > 0)
                {
                    collection[i] = leftPart.Last();
                    leftPart.Remove(leftPart.Last());
                }
                else
                {
                    collection[i] = rightPart.Last();
                    rightPart.Remove(rightPart.Last());
                }
            }
        }

        static void Main(string[] args)
        {
            IList<int> sequence = new List<int>() { 1, 2, -1, 9, 9, 0, 21 };

            Console.WriteLine("Befour " + String.Join(",",sequence));

            Program.Sort(sequence);

            Console.WriteLine("After " + String.Join(",", sequence));
        }
    }
}
