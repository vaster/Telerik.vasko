using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.CustomStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace C.CustomStack
    {
        public class CustomStack<T> : ICustomStack<T>
            where T : struct
        {
            private const int INITIAL_CAPACITY = 4;
            private T[] Array { get; set; }
            public int Count { get; private set; }
            private int HeadIndex { get; set; }

            public CustomStack()
            {
                this.Array = new T[CustomStack<T>.INITIAL_CAPACITY];
                this.HeadIndex = -1;
                this.Count = 0;
            }

            public void Push(T element)
            {
                if (this.ToExtend())
                {
                    this.Extend();
                }

                this.Array[this.Count] = element;

                this.Count++;
                this.HeadIndex++;

            }

            public T Pop()
            {
                if (this.HeadIndex < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Stack is empty!"));
                }

                T headElement = this.Array[this.HeadIndex];

                this.HeadIndex--;
                this.Count--;

                return headElement;
            }

            public T Peek()
            {
                if (this.HeadIndex < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Stack is empty!"));
                }

                T headElement = this.Array[this.HeadIndex];

                return headElement;
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
                T[] extendedArray = new T[this.Array.Length * 2];
                System.Array.Copy(this.Array, extendedArray, this.Array.Length);
                this.Array = extendedArray;
            }
        }
    }

}
