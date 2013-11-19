using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.RemoveOddOccurrences
{
    /// <summary>
    /// Linear structure of data using dynamicly resizable array for base.
    /// </summary>
    /// <typeparam name="T">Generic with constrains of a value type.</typeparam>
    public interface ICustomList<T>
        where T : struct, IComparable
    {
        /// <summary>
        /// Represents the count of elements in the list.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Add new element to the list.
        /// </summary>
        /// <param name="element">Element for addition.</param>
        void Add(T element);

        /// <summary>
        /// Removes all elements with odd number of occurrences
        /// </summary>
        void RemoveOddOccurrences();

        /// <summary>
        /// Lazy implementation of indexer.
        /// </summary>
        /// <param name="index">Position from the list.</param>
        /// <returns>Element at the given position if exists any.</returns>
        T this[int index] { get; }
    }
}
