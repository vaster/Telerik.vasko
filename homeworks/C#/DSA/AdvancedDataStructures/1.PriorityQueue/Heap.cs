using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.PriorityQueue
{
    public class Heap<T>
        where T : IComparable<T>
    {
        private T[] Base { get; set; }

        private const int INITIAL_CAPACITY = 16;

        public int Count { get; private set; }

        public Heap()
        {
            this.Base = new T[Heap<T>.INITIAL_CAPACITY];
        }

        public void Enqueue(T element)
        {
            this.Base[this.Count] = element;

            if (this.Count != 0)
            {
                int rootIndex = (int)((this.Count - 1) / 2);
                int childIndex = this.Count;

                this.MakeBalanceOfTheStructure(childIndex, rootIndex);
            }

            this.Count++;
        }

        public T Peek()
        {
            return this.Base[0];
        }

        public T Dequeue()
        {
            const int ROOT_INDEX = 0;

            T rootElement = this.Base[ROOT_INDEX];

            this.Base[ROOT_INDEX] = this.Base[this.Count - 1];
            this.Base[this.Count - 1] = default(T);

            this.Count--;

            int rootIndex = ROOT_INDEX;
            int childIndex = (int)(2 * rootIndex + 1);

            this.ReBalanceStructure(childIndex, rootIndex);

            return rootElement;
        }

        // when enqueue
        private void MakeBalanceOfTheStructure(int indexChild, int indexRoot)
        {
            T child = this.Base[indexChild];

            T parent = this.Base[indexRoot];

            if (child.CompareTo(parent) < 0)
            {
                T tmp = parent;
                this.Base[indexRoot] = child;
                this.Base[indexChild] = tmp;

                indexChild = indexRoot;
                indexRoot = (int)((indexChild - 1) / 2);

                this.MakeBalanceOfTheStructure(indexChild, indexRoot);
            }
        }

        // when dequeue
        private void ReBalanceStructure(int indexChild, int indexRoot)
        {
            T child = this.Base[indexChild];

            T parent = this.Base[indexRoot];

            if (child.CompareTo(parent) < 0 || (child.CompareTo(parent) == 0))
            {
                T tmp = parent;
                this.Base[indexRoot] = child;
                this.Base[indexChild] = tmp;

                indexRoot = (int)(2 * indexRoot + 1);
                if (this.Base[2 * indexRoot + 2].CompareTo(this.Base[2 * indexRoot + 1]) > 0)
                {
                    indexChild = (int)(2 * indexRoot + 2);
                }
                else
                {
                    indexChild = (int)(2 * indexRoot + 1);
                }

                this.MakeBalanceOfTheStructure(indexChild, indexRoot);
            }
        }
    }
}
