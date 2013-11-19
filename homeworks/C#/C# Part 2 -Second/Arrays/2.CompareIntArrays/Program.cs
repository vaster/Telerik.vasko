using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CompareIntArrays
{
    public class Program
    {

        /*
         Write a program that reads two arrays from the console and compares them element by element.
         */
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] other = { 5, 4, 3, 2, 1 };

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
