using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IEnumerableExtMethod
{
    public static class IEnumerableExtensionMethods
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = default(T);
            foreach (var item in collection)
            {
                sum = sum + item;
            }
            return sum;

        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic product = collection.First();
            foreach (var item in collection)
            {
                product = product * item;
            }

            return product / collection.First();
        }

        public static T Min<T>(this IEnumerable<T> collection)
        {
            dynamic min = collection.First();
            foreach (var item in collection)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
        {
            dynamic max = collection.First();
            foreach (var item in collection)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T Avarage<T>(this IEnumerable<T> collection)
        {
            dynamic avarage = default(T);
           
            foreach (var item in collection)
            {
                avarage = avarage + item;
            }
            return avarage/collection.Count();
        }
    }
}
