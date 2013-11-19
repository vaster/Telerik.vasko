using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SubRange
{
    public class ComparableKeyValuePair<T, K> : IComparable<ComparableKeyValuePair<T, K>>
        where K : IComparable
    {
        public T Key { get; private set; }
        public K Value { get; private set; }

        public ComparableKeyValuePair(T key, K value)
        {
            this.Key = key;
            this.Value = value;
        }

        public int CompareTo(ComparableKeyValuePair<T, K> obj)
        {
            if (this.Value.CompareTo(obj.Value) > 0)
            {
                return 1;
            }
            else if (this.Value.CompareTo(obj.Value) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
