using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HashTable
{
    /// <summary>
    /// Structure of key and value allowing dupblicates in keys.
    /// </summary>
    /// <typeparam name="K">Key</typeparam>
    /// <typeparam name="T">Value</typeparam>
    public interface IHashTable<K,T>
    {
        /// <summary>
        /// Count of keys.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Add new element with a specific key and value to it.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void Add(K key, T value);

        /// <summary>
        /// Search for all elements in the collection by specific key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Return array of founded values.</returns>
        T[] Find(K key);

        /// <summary>
        /// Remove element by key.
        /// </summary>
        /// <param name="key">Key for removal.</param>
        void Remove(K key);

        /// <summary>
        /// Clear the hash table, but keeps the capacity.
        /// </summary>
        void Clear();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T this[int index] { get; }

        /// <summary>
        /// Returns array of all keys in the hash table.
        /// </summary>
        K[] Keys();

        /// <summary>
        /// Interator implementation to allow foreach-ing elements in the collection.
        /// </summary>
        /// <returns>Element from the collecion wich exists. If the current element is null it won't be returned.</returns>
        IEnumerator GetEnumerator();

        /// <summary>
        /// Determing if specific key is contained in the collection.
        /// </summary>
        /// <param name="key">Key to search for.</param>
        /// <returns>true if exists and false if not.</returns>
        bool Contains(K key);
    }
}
