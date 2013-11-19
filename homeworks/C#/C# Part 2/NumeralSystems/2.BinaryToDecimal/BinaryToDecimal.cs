using System;
using System.Collections.Generic;

class BinaryToDecimal
{
    static int ConvertItToDecimal(int bits)
    {
        int decimalRepresentaion = 0;
        char[] bitsArray = bits.ToString().ToCharArray();
        ///////////////////////////////////////////
        int[] bitsArr = new int[bitsArray.Length];
        //////////////////////////////////////////
        for (int i = 0; i < bitsArray.Length; i++)
        {
            bitsArr[i] = bitsArray[i] - 48;
            
        }
        for (int i = bitsArr.Length-1, power=0; i >= 0 ;i--,power++)
        {
            decimalRepresentaion = decimalRepresentaion + (int)(bitsArr[i] * Math.Pow(2, power));
        }
        return decimalRepresentaion;
    }
    /*________________________________________________________________________________________________*/
    static void Main(string[] args)
    {
        int binary;
        int decim;

        Console.Write("Enter sequence of bits(0's or 1's)");
        binary = int.Parse(Console.ReadLine());

        decim = ConvertItToDecimal(binary);

        Console.WriteLine();
        Console.Write("Decimal ->");
        Console.Write(decim);

    }
}

