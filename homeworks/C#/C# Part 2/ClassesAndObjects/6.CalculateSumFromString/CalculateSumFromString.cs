using System;
using System.Collections.Generic;

class CalculateSumFromString
{
    static void Main(string[] args)
    {
        string number;
        int sum = 0;
        List<string> splitNumber = new List<string>();

        Console.Write("Enter string with int numbers separetaed by space");
        number = Console.ReadLine();


        splitNumber.AddRange(number.Split(' '));
        foreach (var item in splitNumber)
        {
            sum = sum + int.Parse(item);
            
        }

        Console.WriteLine("Sum is {0}", sum);
    }
}

