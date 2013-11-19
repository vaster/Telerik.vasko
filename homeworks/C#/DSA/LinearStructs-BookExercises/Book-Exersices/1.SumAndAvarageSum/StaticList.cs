using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SumAndAvarageSum
{
    /// <summary>
    /// Sample implementation of a Static List with generics and dynamicly resizable array for base.
    /// </summary>
    /// <typeparam name="T">A generic type with constrains of a value types.</typeparam>
    public class StaticList<T> : ICustumList<T>
        where T:struct
    {
        private int Count { get; set; }
        private const int INITIAL_CAPACITY = 4;
        private T[] Array { get; set; }

        /// <summary>
        /// Initializes a new Insance of the <see cref="StaticList"/> class.
        /// </summary>
        public StaticList()
        {
            this.Count = 0;
            this.Array = new T[StaticList<T>.INITIAL_CAPACITY];
        }

        /// <summary>
        /// Add new new element to the Static list.
        /// </summary>
        /// <param name="element">Value of the new element.</param>
        public void Add(T element)
        {
            if (this.ToExtend())
            {
                this.Extend();
            }

            this.Array[this.Count] = element;
            this.Count++;
        }

        /// <summary>
        /// Sums all elements in the Static list.
        /// </summary>
        /// <returns>Value type.</returns>
        public T Sum()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException(String.Format("The List is empty! No calculations are possible."));
            }

            T sum = default(T);

            for (int index = 0; index < this.Count; index++)
            {
                sum = (dynamic)sum + this.Array[index];   
            }

            return sum;
        }

        /// <summary>
        /// Calculate avarage sum for all elements in the Static list.
        /// </summary>
        /// <returns></returns>
        public T AvarageSum()
        {
            T avgSum = default(T);

            avgSum = (dynamic)this.Sum() / this.Count;

            return avgSum;
        }

        private bool ToExtend()
        {
            if (this.Count == this.Array.Length)
            {
                return true;
            }

            return false;
        }

        private void Extend()
        {
            T[] extenedArray = new T[this.Array.Length * 2];

            System.Array.Copy(this.Array, extenedArray, this.Array.Length);

            this.Array = extenedArray;
        }
    }
}
