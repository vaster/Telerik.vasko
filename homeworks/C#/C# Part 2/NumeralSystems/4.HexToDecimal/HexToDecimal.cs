using System;
using System.Collections.Generic;

class HexToDecimal
{
    static int ConvertToDecimal(string hexRepresentation)
    {
        int decim = 0;
        char[] hexRepInChar =hexRepresentation.ToCharArray();
        Array.Reverse(hexRepInChar);

        for (int i = 0; i < hexRepInChar.Length; i++)
        {
            if (hexRepInChar[i] >= '1' && hexRepInChar[i] <= '9')
            {
                decim = decim + (hexRepInChar[i] - 48)*(int)(Math.Pow(16,i));
            }
            if (hexRepInChar[i] > '9')
            {
                decim = decim + (hexRepInChar[i]-55)*(int)(Math.Pow(16,i));
            }

        }
        return decim;
    }
    /*_____________________________________________________*/
    static void Main(string[] args)
    {
        string hexValue;
        int decimalValue;

        Console.Write("Enter 0x value:");
        hexValue = Console.ReadLine();

        decimalValue = ConvertToDecimal(hexValue);

        Console.WriteLine();
        Console.Write("Decimal ->{0}",decimalValue);
    }
}

