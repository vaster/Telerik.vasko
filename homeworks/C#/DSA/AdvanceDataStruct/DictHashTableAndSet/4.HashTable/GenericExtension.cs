using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HashTable
{
    public static class GenericExtension
    {
        public const int NEGATIVE_VALUE_CORRECTION_COEFFICENT = -1;

        /// <summary>
        /// Hash code generator for generics.
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="baseArray"></param>
        /// <remarks>It works but is not so good and only works for  key types convertable to int. In some cases it could be slowly.</remarks>
        /// <returns></returns>
        public static int GetHashCodeFromGeneric<K, T>(this K key, LinkedList<KeyValuePair<K, T>>[] baseArray)
        {
            // logic is this:
            //  the key is converted to an int, and this basiclly will represnt the hashcode
            //      for the current key wich later is used as indexer in the array of linkedlists.
            //  For Example: if we have key = "2" -> the element will be saved in the array of linkedliststs at index 2.
            //
            // There are several scenarios.

            int hashCode = 0;
            int objAsInt = Convert.ToInt32(key);

            if (objAsInt < 0)
            {
                objAsInt = objAsInt * GenericExtension.NEGATIVE_VALUE_CORRECTION_COEFFICENT;
            }

            hashCode = objAsInt;

            int firstNullIndex = 0;
            bool toGetFirstNull = true;

            // A scenario when the key has value bigger than the current length of the array of linkedlists.
            //  Example: if we enter as a key "19" -> this means index 19 in the array wich we can't be sure that 
            //      such index exists, so a convertion is needed.
            if (objAsInt >= baseArray.Length)
            {
                // first xor the hash code. (example 18 ^ 16 = 2)
                hashCode = objAsInt ^ baseArray.Length;
                // if xor dosn't help we make random one in the range of 0 - array length
                //      (example 35 ^ 16 = 19)
                if (hashCode >= baseArray.Length)
                {
                    Random gen = new Random();
                    hashCode = gen.Next(0, baseArray.Length - 1);
                }
            }

            // if the new hashcode is a index of none taken position in the array of linkedlists or
            //      we have collision and check for if mathing keys apears
            //          we return the hashcode
            if (baseArray[hashCode] == null || baseArray[hashCode].First.Value.Key.Equals(key))
            {
                return hashCode;
            }

            else
            {
                // interate all elements to chech for matching keys if not
                //      we return the first index with element of null
                for (int index = 0; index < baseArray.Length; index++)
                {
                    if (toGetFirstNull && baseArray[index] == null)
                    {
                        firstNullIndex = index;
                        toGetFirstNull = false;
                    }
                    if (baseArray[index] != null && baseArray[index].First.Value.Key.Equals(key))
                    {
                        return index;
                    }
                }
                return firstNullIndex;
            }
        }
    }
}
