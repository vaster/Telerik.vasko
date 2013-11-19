using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.LongestSubsequenceOfEquals
{
    /// <summary>
    /// Integer linear structure of data with dynamicly resizable array for base.
    /// </summary>
    public interface ICustomList
    {
        /// <summary>
        /// Count of elements in the list.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Add element to next free position in the list.
        /// </summary>
        /// <param name="element">Element for addition.</param>
        void Add(int element);

        /// <summary>
        /// Finds the longest sequenece of equal elements in the list.
        /// </summary>
        /// <returns>The founded sequence.</returns>
        ICustomList FindLongestSubsetOfEquals();

        /// <summary>
        /// Lazy implementation of indexer.
        /// </summary>
        /// <param name="index">Index in the list.</param>
        /// <returns>The allocated element or exception for wrong index.</returns>
        int this[int index] { get; }
    }
}
