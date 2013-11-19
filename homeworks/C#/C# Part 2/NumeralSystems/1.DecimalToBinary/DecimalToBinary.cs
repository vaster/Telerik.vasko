using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static List<int> ConvertItToBinary(int numberForConvertation)
    {
        int numberForConv2 = numberForConvertation;
        List<int> binary = new List<int>();
        do
        {
            numberForConvertation = numberForConv2 % 2;
            binary.Add(numberForConvertation);
            numberForConv2 = numberForConv2/2;
            
        }while(numberForConv2!=0);
        return binary;
    }

    /*________________________________________________*/
    static void Main(string[] args)
    {
        int decimalNumber;

        Console.Write("Enter decimal number:");
        decimalNumber = int.Parse(Console.ReadLine());

        List<int> binaryRepresentation = new List<int>();
            binaryRepresentation.AddRange( ConvertItToBinary(decimalNumber));

        Console.WriteLine();
        Console.Write("Binarry ->");
        
        for (int i = binaryRepresentation.Capacity-1;i>=0;i--)
        {
            
            Console.Write(binaryRepresentation[i]);
        }
       
    }
}

