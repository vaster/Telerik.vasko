namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            List<T> tmp = new List<T>();
            tmp.AddRange(collection);
            tmp = this.SortThem(tmp);
            collection = tmp;
        }

        private List<T> SortThem(List<T> collection)
        {

            if (collection.Count <= 1)
            {
                return collection;
            }

            int pivotIndex = collection.Count / 2;
            T pivot = collection[pivotIndex];
            collection.RemoveAt(pivotIndex);
            List<T> less = new List<T>();
            List<T> greater = new List<T>();
            foreach (T item in collection)
            {
                if (item.CompareTo(pivot) < 0)
                {
                    less.Add(item);
                }
                else
                {
                    greater.Add(item);
                }
            }
            List<T> result = new List<T>();
            result.AddRange(this.SortThem(less));
            result.Add(pivot);
            result.AddRange(this.SortThem(greater));


            return result;
        }

       
    }
}
