using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HashTable
{
    public class HashTable<K, T> : IHashTable<K, T>, IEnumerable
    {
        private const int INITIAL_CAPACITY = 16;

        private const double TO_EXTEND_PROCENTIGE_LIMIT = 0.75;

        private const int EXTEND_CAPACITY_COEFFICENT = 2;

        private LinkedList<KeyValuePair<K, T>>[] Base { get; set; }

        public int Count { get; private set; }

        public HashTable()
        {
            this.Base = new LinkedList<KeyValuePair<K, T>>[HashTable<K, T>.INITIAL_CAPACITY];
            this.Count = 0;
        }

        public void Add(K key, T value)
        {
            if (this.ToExtend())
            {
                this.Extend();
            }

            int index = key.GetHashCodeFromGeneric<K, T>(this.Base);
            KeyValuePair<K, T> pairToAdd = new KeyValuePair<K, T>(key, value);
            LinkedListNode<KeyValuePair<K, T>> nodeToAdd = new LinkedListNode<KeyValuePair<K, T>>(pairToAdd);

            if (this.Base[index] == null)
            {
                this.Base[index] = new LinkedList<KeyValuePair<K, T>>();
                this.Count++;
            }
            this.Base[index].AddLast(nodeToAdd);
        }

        public bool Contains(K key)
        {
            int keyIndex = key.GetHashCodeFromGeneric<K, T>(this.Base);

            if (this.Base[keyIndex] != null)
            {
                return true;
            }

            return false;
        }

        public T[] Find(K key)
        {
            T[] listOfFoundedItems = null;
            int keyIndex = key.GetHashCodeFromGeneric<K, T>(this.Base);

            if (this.Base[keyIndex] != null)
            {
                listOfFoundedItems = new T[this.Base[keyIndex].Count];
                int index = 0;
                foreach (var item in this.Base[keyIndex])
                {
                    listOfFoundedItems[index++] = item.Value;
                }
            }

            return listOfFoundedItems;
        }

        public void Remove(K key)
        {
            int keyIndex = key.GetHashCodeFromGeneric<K, T>(this.Base);
            this.Base[keyIndex] = null;

            this.Count--;
        }

        public void Clear()
        {
            this.Base = new LinkedList<KeyValuePair<K, T>>[this.Base.Length];
            this.Count = 0;
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }

        public K[] Keys()
        {
            K[] keys = new K[this.Count + 1];
            int index = 0;
            foreach (var item in this.Base)
            {
                if (item != null)
                {
                    keys[index++] = item.First.Value.Key;
                }
            }
            return keys;
        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < this.Base.Length; index++)
            {
                if (this.Base[index] != null)
                {
                    yield return this.Base[index];
                }
            }
        }


        private bool ToExtend()
        {
            double exp = HashTable<K, T>.TO_EXTEND_PROCENTIGE_LIMIT * this.Base.Length;

            if (exp == this.Count)
            {
                return true;
            }

            return false;
        }

        private void Extend()
        {
            LinkedList<KeyValuePair<K, T>>[] newBase = 
                new LinkedList<KeyValuePair<K, T>>[this.Base.Length * HashTable<K,T>.EXTEND_CAPACITY_COEFFICENT];

            Array.Copy(this.Base, newBase, this.Base.Length);

            this.Base = newBase;
        }
    }
}
