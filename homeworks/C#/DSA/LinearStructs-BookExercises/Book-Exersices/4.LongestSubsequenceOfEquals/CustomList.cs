using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.LongestSubsequenceOfEquals
{
    public class CustomList : ICustomList
    {
        public int Count { get; private set; }
        private int[] Array { get; set; }
        private const int INITIAL_CAPACITY = 4;

        public CustomList()
        {
            this.Array = new int[CustomList.INITIAL_CAPACITY];
            this.Count = 0;
        }

        public void Add(int element)
        {
            if (this.ToExtend())
            {
                this.Extend();
            }
            this.Array[this.Count] = element;
            this.Count++;
        }

        public ICustomList FindLongestSubsetOfEquals()
        {
            ICustomList subSet = new CustomList();
            int currBestCount = 0;
            int bestCountOverAll = 0;
            int subSetElement = 0;

            for (int index = 0; index < this.Array.Length - 1; index++)
            {
                if (this.Array[index] == this.Array[index + 1])
                {
                    currBestCount++;
                }
                else
                {
                    if (currBestCount > bestCountOverAll)
                    {
                        bestCountOverAll = currBestCount;
                        currBestCount = 0;
                        subSetElement = this.Array[index];
                    }
                }
            }

            for (int i = 0; i < bestCountOverAll; i++)
            {
                subSet.Add(subSetElement);
            }
            return subSet;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index. Index must be in the range of [ >= 0 < {0} ]. Index = {1}",
                        this.Count,index));
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
            int[] extendedArray = new int[this.Array.Length * 2];
            System.Array.Copy(this.Array, extendedArray, this.Array.Length);
            this.Array = extendedArray;
        }
    }
}
