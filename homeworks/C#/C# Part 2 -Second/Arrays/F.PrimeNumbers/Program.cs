using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.PrimeNumbers
{
    public class Program
    {
        /*
         Write a program that finds all prime numbers in the range [1...10 000 000]. 
         Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

         */

       public static void prime_num(long num)
        {
            for (long i = 0; i <= num; i++)
            {
                bool isPrime = true; 
                for (long j = 2; j < i; j++) 
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime:" + i);
                }
              
            }
        }

        static void Main(string[] args)
        {
            prime_num(100);
        }
    }
}
