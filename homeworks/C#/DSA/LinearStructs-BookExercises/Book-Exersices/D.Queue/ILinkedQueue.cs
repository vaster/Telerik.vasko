using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Queue
{
    /// <summary>
    /// Queue structure realized with dynamic list.
    /// </summary>
    public interface ILinkedQueue<T>
    {

        /// <summary>
        /// Add element at the back of the queue.
        /// </summary>
        void Enqueue(T element);

        /// <summary>
        /// Returns the the first enqueued element and remove it from the queue.
        /// </summary>
        T Dequeue();

        /// <summary>
        /// Returns the the first enqueued element without removing it from the queue.
        /// </summary>
        T Peek();

        /// <summary>
        /// Represents the count of the elements in the queue.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Removes all elements from the queue.
        /// </summary>
        void Clear();

        /// <summary>
        /// Determines if a given element exist in the queue.
        /// </summary>
        /// <param name="element">The seeked element.</param>
        /// <returns>True if such exists and false for opposite.</returns>
        bool Contains(T element);

        /// <summary>
        /// Returns the queue as array
        /// </summary>
        T[] ToArray();
    }
}
