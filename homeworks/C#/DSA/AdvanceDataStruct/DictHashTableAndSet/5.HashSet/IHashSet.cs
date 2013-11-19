using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.HashSet
{
    public interface IHashSet<T>
    {
        void Add(T element);

        T Find(T element);

        void Remove(T element);

        int Count { get; }

        void Clear();

        IEnumerator GetEnumerator();

        IHashSet<T> Union(IHashSet<T> other);

        IHashSet<T> Intersect(IHashSet<T> other);

        bool Contains(T key);
    }
}
