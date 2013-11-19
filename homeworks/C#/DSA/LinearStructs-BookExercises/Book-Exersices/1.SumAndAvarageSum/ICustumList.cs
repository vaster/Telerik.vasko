using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SumAndAvarageSum
{
    /// <summary>
    /// List to store elements.
    /// </summary>
    /// <typeparam name="T">Generic type with constrains of a value type.</typeparam>
    public interface ICustumList<T>
        where T : struct
    {
        /// <summary>
        /// Add new element to the data structure.
        /// </summary>
        /// <param name="element"></param>
        void Add(T element);

        /// <summary>
        /// Calculate the sum of all elements in the structure.
        /// </summary>
        T Sum();

        /// <summary>
        /// Calculate the avarage sum of all elements in the structure.
        /// </summary>
        /// <returns></returns>
        T AvarageSum();
    }
}
