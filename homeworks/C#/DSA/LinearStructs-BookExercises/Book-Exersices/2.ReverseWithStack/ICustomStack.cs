using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReverseWithStack
{
    /// <summary>
    /// Sample implementaion of stack for the purpouse of the task.
    /// </summary>
    /// <typeparam name="T">Generic type with constrains of a struct.</typeparam>
    public interface ICustomStack<T>
        where T : struct
    {
        /// <summary>
        /// Add Element to the front of the Stack.
        /// </summary>
        /// <param name="element">Element for adding.</param>
        void Push(T element);

        /// <summary>
        /// Return the last added element and removing it from the stack.
        /// </summary>
        T Pop();
    }
}
