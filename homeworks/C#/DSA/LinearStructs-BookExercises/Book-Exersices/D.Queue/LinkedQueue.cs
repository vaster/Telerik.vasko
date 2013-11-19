using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Queue
{
    public class LinkedQueue<T> : ILinkedQueue<T>
    {
        private class Node
        {
            public T Element { get; set; }
            public Node Next { get; set; }

            public Node(T element)
            {
                this.Element = element;
                this.Next = null;
            }
        }

        private Node Head { get; set; }
        private Node CurrElement { get; set; }
        public int Count { get; private set; }

        public LinkedQueue()
        {
            this.Head = null;
            this.CurrElement = null;
            this.Count = 0;
        }


        public void Enqueue(T element)
        {
            if (this.Head == null)
            {
                this.Head = new Node(element);
                this.CurrElement = Head;
            }
            else
            {
                this.CurrElement.Next = new Node(element);
                this.CurrElement = this.CurrElement.Next;
            }
            this.Count++;
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException(String.Format("Queue is empty! No elements available."));
            }

            Node nodeForDequeue = new Node(this.Head.Element);
            this.Head = this.Head.Next;
            this.Count--;

            return nodeForDequeue.Element;
        }

        public T Peek()
        {
            T elementForPeek = this.Head.Element;

            return elementForPeek;
        }

        public void Clear()
        {
            Node forDelete;
            while (this.Count != 0)
            {
                forDelete = this.Head;
                this.Head = this.Head.Next;
                forDelete = null;

                this.Count--;
            }

        }

        public bool Contains(T element)
        {
            Node seekForNode = this.Head;

            while (seekForNode != null)
            {
                if (seekForNode.Element.Equals(element))
                {
                    return true;
                }
                seekForNode = seekForNode.Next;
            }

            return false;
        }

        public T[] ToArray()
        {
            T[] queueAsArray = new T[this.Count];
            Node iteratorNode = this.Head;

            for (int index = 0; index < queueAsArray.Length; index++)
            {
                queueAsArray[index] = iteratorNode.Element;
                iteratorNode = iteratorNode.Next;
            }

            return queueAsArray;
        }
    }
}
