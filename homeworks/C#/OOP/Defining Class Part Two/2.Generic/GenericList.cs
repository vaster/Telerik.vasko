using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Generic
{
    public class GenericList<T>
        where T : class                         //by inheriting 'class' we make constrains for 'T' that will aways be a reference type.
    {                                           //The reason is if we use a value type in the 'Main' lets say 'int' when we try to remove
        private const int capacity = 10;        //   a specific element we won't actualy remove it, but only zero it(becouse of default(T)).
        private T[] listOfElements;             //Another problem is if we want a given element to be actualy '0', by this algoritm the program
        private int fillPosition;               //   will think of it as a free cell in the array and will fill it if we add any new data to the array.
        private int trueCapacity = capacity;    //So when we pass value types as parameters to a methods they will be treated as reference types 
                                                //   this allow as to use 'null' and solve the above problems.


        public GenericList()
            : this(capacity)
        {

        }

        public GenericList(int capacity)
        {
            this.listOfElements = new T[capacity];
            fillPosition = 0;
        }


        public void AddElement(T currElement)
        {
            T[] tempArray;
            if (fillPosition >= trueCapacity)         //autoGrow func
            {
                trueCapacity = trueCapacity * 2;
                tempArray = this.listOfElements;
                this.listOfElements = new T[trueCapacity];
                tempArray.CopyTo(this.listOfElements,0);
            }

            for (int i = 0; i < listOfElements.Length; i++)
            {

                if (this.listOfElements[i] == null)
                {
                    this.listOfElements[i] = currElement;
                    break;
                }
            }

            fillPosition++;
        }

        public T returnElement(int index)
        {
            if (index < 0 || index >= capacity)
            {
                throw new IndexOutOfRangeException("No such element referend by this index ->." + index);
            }
            return this.listOfElements[index];
        }

        public void RemoveElement(int index)
        {
            if (index < 0 || index >= capacity)
            {
                throw new IndexOutOfRangeException("No such element referend by this index ->." + index);
            }
            this.listOfElements[index] = null;
            this.listOfElements[index] = null;
            for (int i = index; i < listOfElements.Length - 1; i++)
            {
                this.listOfElements[i] = this.listOfElements[i + 1];
            }

            fillPosition--;

        }

        public void InsertElement(T element, int index)
        {
            if (index < 0 || index >= trueCapacity)
            {
                throw new IndexOutOfRangeException("No such position referend by this index ->." + index);
            }
            if (fillPosition == trueCapacity)
            {
                throw new IndexOutOfRangeException("There are no empty cells.");
            }

            for (int i = fillPosition, y = 0; i > index; i--, y++)
            {
                this.listOfElements[fillPosition - y] = this.listOfElements[fillPosition - y - 1];

            }
            this.listOfElements[index] = element;
            fillPosition++;


        }


        public void ClearList()
        {
            for (int i = 0; i < trueCapacity; i++)
            {
                this.listOfElements[i] = null;
            }
        }

        public T FindElement(T value)
        {

            int seekedIndex = 0;
            bool ensure = false;
            for (int i = 0; i < trueCapacity; i++)
            {
                if (value.Equals(this.listOfElements[i]))
                {
                    ensure = true;
                    seekedIndex = i;
                    break;
                }
            }
            if (ensure)
            {
                return this.listOfElements[seekedIndex];
            }
            else
            {
                throw new Exception("No such element.");
            }
        }

        public T Min()
        {
            T min = this.listOfElements[0];
            IComparable[] comparableArray = new IComparable[trueCapacity];
            this.listOfElements.CopyTo(comparableArray,0);
            for (int i = 0; i < this.listOfElements.Length; i++)
            {
                if (comparableArray[i].CompareTo(min)<0)
                {
                    min = this.listOfElements[i];
                }
            }
            return min;
        }


        public T Max()
        {
            T max = this.listOfElements[0];
            IComparable[] comparableArray = new IComparable[trueCapacity];
            this.listOfElements.CopyTo(comparableArray, 0);
            for (int i = 0; i < this.listOfElements.Length; i++)
            {
                if (comparableArray[i].CompareTo(max) > 0)
                {
                    max = this.listOfElements[i];
                }
            }
            return max;
        }






        public T[] returnList()
        {
            return this.listOfElements; // if we want to test the functionality of the class in the 'Main'
        }

        public override string ToString()
        {
            return string.Format("{0}", this.listOfElements[fillPosition - 1]);
        }



    }
}
