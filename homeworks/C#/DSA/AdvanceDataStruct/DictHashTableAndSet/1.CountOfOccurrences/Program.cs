using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CountOfOccurrences
{
    /*
     * Write a program that counts in a given array of double values the number of occurrences of each value. 
     * Use Dictionary<TKey,TValue>.
     */
    public class Program
    {
        static void Main(string[] args)
        {
            double[] sequence = new double[] { 1, 2, 2, 22, 3, 4, 5, 2.2, 5, 1, -2.3 };
            Dictionary<string, double> occurrences = new Dictionary<string, double>();
            int startCount = 0;

            foreach (double item in sequence)
            {
                if (occurrences.ContainsKey(item.ToString()))
                {
                    occurrences[item.ToString()]++;
                }
                else
                {
                    occurrences.Add(item.ToString(), startCount + 1);
                }
            }

            foreach (var item in occurrences)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
