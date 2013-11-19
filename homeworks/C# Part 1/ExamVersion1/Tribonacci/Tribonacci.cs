using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger n1;
        BigInteger n2;
        BigInteger n3;
        BigInteger n;
        BigInteger findN = 0;

        n1 = BigInteger.Parse(Console.ReadLine());
        n2 = BigInteger.Parse(Console.ReadLine());
        n3 = BigInteger.Parse(Console.ReadLine());
        n = BigInteger.Parse(Console.ReadLine());

        n = n - 3;

        do
        {
            findN = n1 + n2 + n3;
            n1 = n2;
            n2 = n3;
            n3 = findN;
            n--;
        } while (n > 0);

        Console.WriteLine("{0}",findN);
    }
}

