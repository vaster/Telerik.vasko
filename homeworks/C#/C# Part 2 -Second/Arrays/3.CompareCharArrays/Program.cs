using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompareCharArrays
{
    public class Program
    {
        /*
         Write a program that compares two char arrays lexicographically (letter by letter).
         */

        static void Main(string[] args)
        {

            char[] array = { 'a', 'b', 'c', 'd', 'e' };
            char[] other = { 'e', 'd', 'c', 'b', 'a' };

            bool areEqual = false;

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                areEqual = array[i] == other[i];

                result.Append(array[i]);

                if (areEqual)
                {
                    result.Append(" equals ");
                }
                else
                {
                    result.Append(" not equals ");
                }

                result.Append(other[i]);
                result.AppendLine();
            }

            Console.WriteLine(result);
        }
    }
}
