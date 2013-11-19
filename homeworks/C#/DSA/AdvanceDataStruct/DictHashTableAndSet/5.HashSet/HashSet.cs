using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4.HashTable;

namespace _5.HashSet
{
    public class HashSet<T> : IHashSet<T>
    {
        private HashTable<T, T> Base { get; set; }

        public HashSet()
        {
            this.Base = new HashTable<T, T>();
        }

        public void Add(T element)
        {
            this.Base.Add(element, element);
        }

        public T Find(T element)
        {
            return this.Base.Find(element)[0];
        }

        public void Remove(T element)
        {
            this.Base.Remove(element);
        }

        public void Clear()
        {
            this.Base.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            foreach (LinkedList<KeyValuePair<T,T>> item in this.Base)
            {

                if (item != null)
                {
                    yield return item.First.Value.Key;
                }
            }
        }

        public bool Contains(T key)
        {
            return this.Base.Contains(key);
        }

        public IHashSet<T> Union(IHashSet<T> other)
        {
            IHashSet<T> union = new HashSet<T>();

            foreach (T item in this)
            {
                union.Add(item);
            }

            foreach (T item in other)
            {
                if (!union.Contains(item))
                {
                    union.Add(item);
                }
            }

            return union;
        }

        public IHashSet<T> Intersect(IHashSet<T> other)
        {
            IHashSet<T> intersected = new HashSet<T>();

            foreach (T item in this)
            {
                if (other.Contains(item))
                {
                    intersected.Add(item);
                }
            }

            return intersected;
        }

        public int Count
        {
            get
            {
                return this.Base.Count;
            }
        }
    }
}
