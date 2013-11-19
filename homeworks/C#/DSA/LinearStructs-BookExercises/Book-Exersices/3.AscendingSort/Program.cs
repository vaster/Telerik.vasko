using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AscendingSort
{
    /*
     Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.
     */

    public class Program
    {
        /// <summary>
        /// Read from the console untill an invalid number is entered.
        /// </summary>
        /// <param name="linkedListSample">ICustomList to store the numbers.</param>
        static void ConsoleReader(DynamicList<int> linkedListSample)
        {
            int input = 0;
            bool toProceed = true;

            Console.WriteLine("Enter number(ends when invalid number is entered):");
            while (toProceed)
            {
                toProceed = int.TryParse(Console.ReadLine(), out input);
                if (toProceed)
                {
                    linkedListSample.Add(input);
                }
            }
        }

        static void Main(string[] args)
        {

            DynamicList<int> sample = new DynamicList<int>();
            Program.ConsoleReader(sample);

            for (int i = 0; i < sample.Count; i++)
            {
                Console.WriteLine(sample[i]);
            }
        }
    }
}
