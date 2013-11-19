using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CountOfOccurrences
{
    /*
     * Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
    */

    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> data = new Dictionary<string, int>();
            string input;

            Console.Write("Enter count of numbers:");
            int count = int.Parse(Console.ReadLine());

            for (int index = 0; index < count; index++)
            {
                Console.Write("Element = ");
                input = Console.ReadLine();

                if (!data.ContainsKey(input))
                {
                    data.Add(input, 1);
                }
                else
                {
                    data[input] = data[input] + 1;
                }
            }

            Console.WriteLine();
            foreach (var element in data)
            {
                Console.WriteLine(element.Key + " --> " + element.Value);
            }
        }
    }
}
