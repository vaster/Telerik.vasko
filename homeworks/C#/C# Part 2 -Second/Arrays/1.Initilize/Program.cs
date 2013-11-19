using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Initilize
{
    /*
     * Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
     * Print the obtained array on the console.
     */

    public class Program
    {
        static void Main(string[] args)
        {
            const int INITILIZE_COEFF = 5;

            int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * INITILIZE_COEFF;
            }

            Console.WriteLine("Result:");
            Console.WriteLine(String.Join(",",array));
        }
    }
}
