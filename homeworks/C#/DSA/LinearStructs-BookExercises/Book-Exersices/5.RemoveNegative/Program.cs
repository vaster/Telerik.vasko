using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.RemoveNegative
{
    /*
     * Write a program that removes from given sequence all negative numbers.
    */

    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> sample = new CustomList<int>();
            sample.Add(1);
            sample.Add(0);
            sample.Add(-3);
            sample.Add(-12);
            sample.Add(-2);
            sample.Add(100);
            sample.Add(-1);
            sample.Add(1);
            sample.Add(-1);

            Console.WriteLine("Befoure we remove negative elements:");
            for (int index = 0; index < sample.Count; index++)
            {
                Console.Write(sample[index]);
                if (index != sample.Count - 1)
                {
                    Console.Write(',');
                }
            }
            Console.WriteLine();
            sample.RemoveNegativeElements();

            Console.WriteLine("After we removed negative elements:");
            for (int index = 0; index < sample.Count; index++)
            {
                Console.Write(sample[index]);
                if (index != sample.Count - 1)
                {
                    Console.Write(',');
                }
            }
            Console.WriteLine();
        }
    }
}
