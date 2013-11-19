using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReverseWithStack
{
    public class DynamicStack<T> : ICustomStack<T>
        where T : struct
    {
        private class Node
        {
            public T Element { get; set; }

            public Node Previouse { get; set; }

            public Node(T element, Node next)
            {
                this.Element = element;
                this.Previouse = next;
            }

            public Node(T element)
            {
                this.Element = element;
                this.Previouse = null;
            }
        }

        private Node Head { get; set; }
        private Node Tail { get; set; }
        public int Count { get; private set; }

        public DynamicStack()
        {
            this.Head = null;
            this.Tail = null;
        }


        public void Push(T element)
        {
            if (this.Head == null)
            {
                this.Head = new Node(element);
                this.Tail = this.Head;
            }
            else
            {
                Node newNode = new Node(element, this.Head);
                this.Head = newNode;
            }

            this.Count++;
        }

        public T Pop()
        {
            if (this.Count <= 0)
            {
                throw new IndexOutOfRangeException(String.Format("Stack is empty!"));
            }

            T headElement = this.Head.Element;
            this.Head = this.Head.Previouse;

            this.Count--;

            return headElement;
        }
    }
}
