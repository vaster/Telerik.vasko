using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AscendingSort
{
    public class DynamicList<T>
        where T : struct, IComparable
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

        public DynamicList()
        {
            this.Head = null;
            this.CurrElement = null;
            this.Count = 0;
        }

        public void Add(T element)
        {
            if (this.Head == null)
            {
                this.Head = new Node(element);
                this.CurrElement = this.Head;
            }
            else
            {
                if (element.CompareTo(this.Head.Element) <= 0)
                {
                    this.CurrElement = new Node(element);
                    this.CurrElement.Next = this.Head;
                    this.Head = this.CurrElement;
                }
                if (element.CompareTo(this.Head.Element) > 0)
                {
                    bool toAddAtTheBack = true;
                    Node interator = this.Head;
                    Node breakPoint;
                    Node newElement = new Node(element);;

                    while (interator.Next != null)
                    {
                        if (element.CompareTo(interator.Next.Element) <= 0)
                        {
                            breakPoint = interator.Next;
                            newElement.Next = breakPoint;
                            interator.Next = newElement;
                            toAddAtTheBack = false;
                            break;
                        }

                        interator = interator.Next;
                    }

                    if (toAddAtTheBack)
                    {
                        interator.Next = newElement;
                    }
                }

            }
            this.Count++;
        }

        public T this[int index]
        {
            get
            {
                Node node = this.Head;
                if (index >= Count || index < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index. Index :" + index));
                }

                for (int i = 0; i < index; i++)
                {
                    node = node.Next;
                }

                return node.Element;
            }
        }
    }
}
