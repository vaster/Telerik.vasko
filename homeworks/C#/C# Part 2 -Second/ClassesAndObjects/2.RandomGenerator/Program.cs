using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RandomGenerator
{
    public class Program
    {
        /*
         Write a program that generates and prints to the console 10 random values in the range [100, 200].

         */
        static void Main(string[] args)
        {
            const int N = 10;
            Random randomGenerator = new Random();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(randomGenerator.Next(100,200));
            }
        }
    }
}
