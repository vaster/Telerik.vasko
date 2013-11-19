using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.Factorial
{
    public class Program
    {
        public static BigInteger Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return Program.Factorial(n-1) * n;
            }
        }
        static void Main(string[] args)
        {
            int n = 14;

            BigInteger result = Program.Factorial(n);

            Console.WriteLine(result);
        }
    }
}
