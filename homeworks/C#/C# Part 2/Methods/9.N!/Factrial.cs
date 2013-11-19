using System;
using System.Numerics;

class Factorial
{
    static BigInteger CalculateFactorial(int end)
    {
        BigInteger fact = 1;
        for (int i = 1; i <= end; i++)
        {
            fact = fact*i + fact;
        }
        return fact;
    }
    static void Main(string[] args)
    {
        BigInteger factorial = 0;

        for (int end = 0; end < 100; end++)
        {
            factorial = CalculateFactorial(end);
            Console.WriteLine(factorial);
        }

        
        
    }
}

