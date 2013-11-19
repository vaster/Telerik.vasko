using System;
using System.Collections.Generic;
using System.Text;

class Reverse
{
    static void Main(string[] args)
    {
        string toBeReversed;
        StringBuilder reverseIt = new StringBuilder();

        Console.Write("Enter symbols to reverse them:");
        toBeReversed = Console.ReadLine();

        for (int i = toBeReversed.Length-1; i >=0 ; i--)
        {
            reverseIt.Append(toBeReversed[i]);
        }

        Console.WriteLine("Result: {0}",reverseIt.ToString());
    }
}

