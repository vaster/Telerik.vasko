using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BiDict
{
    public interface IBiDictionary<K, T, Q>
    {
        /// <summary>
        /// Add element by two keys and a value.
        /// </summary>
        /// <param name="keyOne"></param>
        /// <param name="keyTwo"></param>
        /// <param name="value"></param>
        void Add(K keyOne, T keyTwo, Q value);

        /// <summary>
        /// Search for items with type of first key.
        /// </summary>
        /// <param name="keyOne"></param>
        /// <returns></returns>
        ICollection<Q> this[K keyOne] { get; }

        /// <summary>
        /// Search for itmes with type of second key.
        /// </summary>
        /// <param name="keyTwo"></param>
        /// <param name="resolveInterfere">
        /// If the the types of the keys types K and T are the same(string and string for an example)
        ///     we have to be able to delimitate the keys from each other. Adding fictive second parameter
        ///     is a possible solution.
        /// </param>
        /// <returns></returns>
        ICollection<Q> this[T keyTwo, bool resolveInterfere] { get; }

        /// <summary>
        /// Search for items by two keys. If item is associeted by each of the keys
        ///     it will be return as a part of a collection.
        /// </summary>
        /// <param name="keyOne"></param>
        /// <param name="keyTwo"></param>
        /// <returns></returns>
        ICollection<Q> this[K keyOne, T keyTwo] { get; }

    }
}
