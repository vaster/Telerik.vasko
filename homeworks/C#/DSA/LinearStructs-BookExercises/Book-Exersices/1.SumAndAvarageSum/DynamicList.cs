using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SumAndAvarageSum
{
    /// <summary>
    /// Sample implementation of a Dynamic List with generics.
    /// </summary>
    /// <typeparam name="T">A generic type with constrains of a value types.</typeparam>
    public class DynamicList<T> : ICustumList<T>
        where T : struct
    {
        private class Node
        {
            public T Element { get; set; }
            public Node Next { get; set; }

            public Node(T elememt, Node previousNote)
            {
                this.Element = elememt;
                previousNote.Next = this;
            }

            public Node(T element)
            {
                this.Element = element;
                this.Next = null;
            }
        }

        private Node Head { get; set; }
        private Node Tail { get; set; }
        private int Count { get; set; }

        /// <summary>
        /// Initializes a new Insance of the <see cref="DynamicList"/> class.
        /// </summary>
        public DynamicList()
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
        }

        /// <summary>
        /// Add new new node to the Dynamic list.
        /// </summary>
        /// <param name="element">Value of the new node's element.</param>
        public void Add(T element)
        {
            if (this.Head == null)
            {
                this.Head = new Node(element);
                this.Tail = this.Head;
            }
            else
            {
                Node newNode = new Node(element, this.Tail);
                this.Tail = newNode;
            }

            this.Count++;
        }

        /// <summary>
        /// Sums all elements in the Dynamic list.
        /// </summary>
        /// <returns>Value type.</returns>
        public T Sum()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException(String.Format("The List is empty! No calculations are possible."));
            }
            T sum = default(T);
            Node newNode = this.Head;

            while (newNode != null)
            {
                sum = (dynamic)sum + newNode.Element;
                newNode = newNode.Next;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the avarage sum of all elements in the Dynamic list.
        /// </summary>
        /// <returns>Value type.</returns>
        public T AvarageSum()
        {
            T avgSum = default(T);

            avgSum = (dynamic)this.Sum() / this.Count;

            return avgSum;
        }
    }
}
