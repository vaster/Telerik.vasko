using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Define a class BitArray64 to hold 64 bit values inside an ulong value.
 Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

 */
namespace _3.BitArray
{
    class Core
    {
        static void Main(string[] args)
        {
            //testing
            BitArray64 simpleArray = new BitArray64();
            simpleArray.Add(1);
            simpleArray.Add(2);
            simpleArray.Add(3);
            simpleArray.Add(3);

            Console.WriteLine(simpleArray[2] == simpleArray[3]);
            foreach (var value in simpleArray)
            {
                Console.WriteLine(value);
            }
        }
    }
}
