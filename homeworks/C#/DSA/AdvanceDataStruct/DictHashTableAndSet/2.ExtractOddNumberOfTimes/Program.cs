using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ExtractOddNumberOfTimes
{
    /*
     * Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. Example:
       {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
    */

    public class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            HashSet<string> resultHolder = new HashSet<string>();
            int startCount = 0;

            foreach (var item in sequence)
            {
                if (occurences.ContainsKey(item))
                {
                    occurences[item]++;
                }
                else
                {
                    occurences.Add(item, startCount + 1);
                }
            }

            foreach (var item in occurences)
            {
                if (item.Value % 2 != 0)
                {
                    resultHolder.Add(item.Key);
                }
            }

            Console.WriteLine("Original:{ C#, SQL, PHP, PHP, SQL, SQL }");
            Console.WriteLine("Result:");
            foreach (var item in resultHolder)
            {
                Console.WriteLine(item);
            }
        }
    }
}
