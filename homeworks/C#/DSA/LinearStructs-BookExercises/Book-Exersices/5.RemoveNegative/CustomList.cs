using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.RemoveNegative
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

        public void RemoveNegativeElements()
        {
            for (int index = 0; index < this.Count; index++)
            {
                if (this.Array[index].CompareTo(0) < 0)
                {
                    // Re-arrange 
                    for (int innerIndex = index; innerIndex < this.Count - 1; innerIndex++)
                    {
                        this.Array[innerIndex] = this.Array[innerIndex + 1];
                    }

                    this.Count--;

                    // If we have two negative number in a row, we will skip the second becouse of the re-arrage of the array
                    // This is why we reduce it, to be sure we will not skip it.
                    index--;
                }
            }
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
            System.Array.Copy(this.Array,extendedArray,this.Array.Length);
            this.Array = extendedArray;
        }
    }
}
