using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.TaskFour
{
    class Program
    {
        // Part of the code is represented as method.
        // we change 'i' in the method so we passed as reference.
        static void DevidableBy10(ref int i, int[] array, int expectedValue)
        {
            if (i % 10 == 0)
            {
                Console.WriteLine(array[i]);
                if (array[i] == expectedValue)
                {
                    i = 666;
                }
                i++;
            }
            else
            {
                Console.WriteLine(array[i]);
                i++;
            }
        }

        static void Main(string[] args)
        {
            // Sample
            int i = 0;
            int[] array = new int[100];
            int expectedValue = 10;

            for (i = 0; i < 100; )
            {
                DevidableBy10(ref i, array, expectedValue);
            }
            // More code here
            if (i == 666)
            {
                Console.WriteLine("Value Found");
            }

        }
    }
}
