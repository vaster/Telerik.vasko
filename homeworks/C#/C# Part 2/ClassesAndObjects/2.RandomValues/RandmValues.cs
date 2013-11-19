using System;
using System.Collections.Generic;

class RandmValues
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomGenerator.Next(100,200));
        }
    }
}

