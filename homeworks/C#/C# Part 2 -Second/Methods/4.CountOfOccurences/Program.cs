using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CountOfOccurences
{
    public class Program
    {
        public static int CountOfOccurences(int[] array, int number)
        {
            int count = 0;

            foreach (var element in array)
            {
                if (element == number)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 3, 4, 5, 4, 10, 2, -3 };

            int number = 3;

            // expected 2
            int countOfNumberOccurences = Program.CountOfOccurences(array,number);

            Console.WriteLine(String.Join(",",array));
            Console.WriteLine("Number " + number + " occurence " + countOfNumberOccurences + " times.");
        }
    }
}
