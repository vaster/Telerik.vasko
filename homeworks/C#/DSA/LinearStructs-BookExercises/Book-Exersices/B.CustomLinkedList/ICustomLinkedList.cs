using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.CustomLinkedList
{
    public interface ICustomLinkedList<T>
    {
        /// <summary>
        /// Returns the number of elements.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Appends given element at the end.
        /// </summary>
        /// <param name="element"></param>
        void Add(T element);

        /// <summary>
        /// Access element by index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        ListItem<T> this[int index] { get; }

        /// <summary>
        /// Inserts given element to the list at a specified position.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="element"></param>
        void Insert(int index, T element);

        /// <summary>
        /// Removes the firs occurrence of given element
        /// </summary>
        /// <param name="element"></param>
        void Remove(T element);

        /// <summary>
        /// Removes the element at the specified position.
        /// </summary>
        /// <param name="index"></param>
        void RemoveAt(int index);

        /// <summary>
        /// Removes all elements.
        /// </summary>
        void Clear();

        /// <summary>
        /// Determines whether an element is part of the list.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        bool Contains(T element);
    }
}
