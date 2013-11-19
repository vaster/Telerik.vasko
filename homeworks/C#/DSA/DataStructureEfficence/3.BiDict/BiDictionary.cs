using System;
using System.Collections;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace _3.BiDict
{
    public class BiDictionary<K, T, Q> : IBiDictionary<K,T,Q>
    {
        private MultiDictionary<K, Q> BiDictLogicalPartOne { get; set; }

        private MultiDictionary<T, Q> BiDictLogicalPartTwo { get; set; }

        public BiDictionary()
        {
            this.BiDictLogicalPartOne = new MultiDictionary<K, Q>(true);
            this.BiDictLogicalPartTwo = new MultiDictionary<T, Q>(true);
        }

        public void Add(K keyOne, T keyTwo, Q value)
        {
            this.BiDictLogicalPartOne.Add(keyOne, value);
            this.BiDictLogicalPartTwo.Add(keyTwo, value);
        }

        public ICollection<Q> this[K keyOne]
        {
            get
            {
                ICollection<Q> result = null;
                result = this.BiDictLogicalPartOne[keyOne];

                return result;
            }
        }

        public ICollection<Q> this[T keyTwo, bool resolveInterfere]
        {
            get
            {
                ICollection<Q> result = null;
                result = this.BiDictLogicalPartTwo[keyTwo];

                return result;
            }
        }

        public ICollection<Q> this[K keyOne, T keyTwo]
        {
            get
            {
                ICollection<Q> result = new List<Q>();

                foreach (Q item in this.BiDictLogicalPartOne[keyOne])
                {
                    if (this.BiDictLogicalPartTwo.Contains(keyTwo,item))
                    {
                        result.Add(item);
                    }
                }

                return result;
            }
        }
    }
}
