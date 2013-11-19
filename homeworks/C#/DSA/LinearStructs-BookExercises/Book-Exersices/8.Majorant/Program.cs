using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Majorant
{
    /*
     * * The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
     * Write a program to find the majorant of given array (if exists)
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

            int majorant = count / 2 + 1;

            if (data.Values.Contains(majorant))
            {
                Console.WriteLine("Majorant is " + data.FirstOrDefault(x => x.Value == majorant).Key);
            }
            else
            {
                Console.WriteLine("No majorant founded!");
            }
        }
    }
}
