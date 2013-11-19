using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BitArray
{
    public class BitArray64 : IEnumerable<ulong>
    {
        private List<ulong> valueOf64Bits;


        //construcor
        public BitArray64()
        {
            ValueOf64Bits = new List<ulong>();
        }

        //methods
        public void Add(ulong longValue)
        {
            this.ValueOf64Bits.Add(longValue);
        }
        //foreach
        public IEnumerator<ulong> GetEnumerator()
        {
            return this.ValueOf64Bits.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        //Equals
        public override bool Equals(object param)
        {
            BitArray64 longValue = param as BitArray64;
            if (this.Equals(longValue))
            {
                return true;
            }
            return false;
        }
        //==
        public static bool operator ==(BitArray64 firstValue, BitArray64 secondValue)
        {
            if (firstValue.Equals(secondValue))
            {
                return true;
            }
            return false;
        }
        //!=
        public static bool operator !=(BitArray64 firstValue, BitArray64 secondValue)
        {
            if (!(firstValue.Equals(secondValue)))
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode() + this.GetHashCode() / 2 ^ 3; // random implementation, probably not good.
        }
        public ulong this[int index]
        {
            
            get 
            {
                if (index >= 0 && index < ValueOf64Bits.Count())
                {
                    return this.ValueOf64Bits[index];
                }
                throw new IndexOutOfRangeException("No such element at index ->" + index);
            }
            set
            {
                if (index >= 0 && index < ValueOf64Bits.Count())
                {
                    this.ValueOf64Bits[index] = value;
                }
                throw new IndexOutOfRangeException("No such element at index ->" + index);
            }
        }
        //properties

        private List<ulong> ValueOf64Bits
        {
            get { return this.valueOf64Bits; }
            set { this.valueOf64Bits = value; }
        }


    }
}
