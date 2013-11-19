using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.RemoveNegative
{
    /// <summary>
    /// Linear data structure with dynamicly resizable array for base.
    /// </summary>
    /// <typeparam name="T">Generic with constrains of a value type.</typeparam>
    public interface ICustomList<T>
        where T : struct, IComparable
    {
        /// <summary>
        /// Represent the count of elements in the list.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Add new element to the list.
        /// </summary>
        /// <param name="element">Element for addition.</param>
        void Add(T element);

        /// <summary>
        /// Removes all negative elements from the list, and re-arrange it.
        /// </summary>
        void RemoveNegativeElements();

        /// <summary>
        /// Lazy implementation of indexer.
        /// </summary>
        /// <param name="index">Position from the list.</param>
        /// <returns>Element at the requested position if any exists.</returns>
        T this[int index] { get; }
    }
}
