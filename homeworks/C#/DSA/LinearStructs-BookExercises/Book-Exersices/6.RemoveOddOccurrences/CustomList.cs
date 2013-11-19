using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.RemoveOddOccurrences
{
    public class CustomList<T> : ICustomList<T>
        where T : struct, IComparable
    {
        public int Count { get; private set; }
        private const int INITIAL_CAPACITY = 4;
        private T[] Array;

        public CustomList()
        {
            this.Array = new T[CustomList<T>.INITIAL_CAPACITY];
            this.Count = 0;
        }

        public void Add(T element)
        {
            if (this.ToExtend())
            {
                this.Extend();
            }
            this.Array[this.Count] = element;
            this.Count++;
        }

        public void RemoveOddOccurrences()
        {
            T[] arrayOfEvenOccurencces = new T[this.Array.Length];
            int occurencesCount = 0;
            int index= 0;

            // count occurencces for each element in the array, problem is we count each element, not groube of equals
            // so its not a best time performancer
            for (int currIndex = 0; currIndex < this.Count; currIndex++)
            {
                for (int innerIndex = 0; innerIndex < this.Count; innerIndex++)
                {
                    if (this.Array[currIndex].CompareTo(this.Array[innerIndex]) == 0)
                    {
                        occurencesCount++;
                    }
                }

                // if occurences are even we added to new array
                if (occurencesCount % 2 == 0)
                {
                    arrayOfEvenOccurencces[index] = this.Array[currIndex];
                    index++;
                }
                occurencesCount = 0;
            }

            // reduce the count of the CustomList to the count of actual elements
            this.Count = index;

            // the array used for base of the list points to the new one with only even occurences
            // so not best memory performancer because of creating new array
            this.Array = arrayOfEvenOccurencces;

        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index. Index must be in the range of [ >= 0 < {0} ]. Index = {1}",
                        this.Count, index));
                }
                return this.Array[index];
            }
        }

        private bool ToExtend()
        {
            if (this.Count == this.Array.Length - 1)
            {
                return true;
            }

            return false;
        }

        private void Extend()
        {
            T[] extendedArray = new T[this.Array.Length * 2];
            System.Array.Copy(this.Array, extendedArray, this.Array.Length);
            this.Array = extendedArray;
        }
    }
}
