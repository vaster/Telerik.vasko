using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeUnderstanding
{
    public static class GenericExtension 
    {
        public static T ChangeType<T>(this object obj)
        {
            return (T)Convert.ChangeType(obj, typeof(T));
        }

        public static T Sum<T>(this object obj, object other)
        {
            return (T)Convert.ChangeType(Convert.ToInt32(obj) + Convert.ToInt32(other),typeof(T));
        }
    }
}
