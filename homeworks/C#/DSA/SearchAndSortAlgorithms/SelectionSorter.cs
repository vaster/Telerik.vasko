namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
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
                    this.Swap(collection, min, i);
                }
            }
        }

        private void Swap(IList<T> collection, int indexToSwap, int indexToSwapWith)
        {
            T tmp = collection[indexToSwap];
            collection[indexToSwap] = collection[indexToSwapWith];
            collection[indexToSwapWith] = tmp;
        }
    }
}
