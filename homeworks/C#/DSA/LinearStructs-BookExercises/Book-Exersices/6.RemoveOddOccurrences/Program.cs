using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.RemoveOddOccurrences
{
    /*
     * Write a program that removes from given sequence all numbers that occur odd number of times.
     */

    public class Program
    {
        static void Main(string[] args)
        {
            ICustomList<int> sample = new CustomList<int>();

            sample.Add(2);
            sample.Add(1);
            sample.Add(1);
            sample.Add(1);
            sample.Add(1);
            sample.Add(1);
            sample.Add(1);
            sample.Add(3);
            sample.Add(3);
            sample.Add(4);
            sample.Add(4);
            sample.Add(4);
            sample.Add(6);
            sample.Add(8);
            sample.Add(8);

            sample.RemoveOddOccurrences();

            Console.WriteLine("After removal:");
            for (int index = 0; index < sample.Count; index++)
            {
                Console.Write(sample[index]);
                if (index != sample.Count)
                {
                    Console.Write(',');
                }
            }
            Console.WriteLine();
        }
    }
}
