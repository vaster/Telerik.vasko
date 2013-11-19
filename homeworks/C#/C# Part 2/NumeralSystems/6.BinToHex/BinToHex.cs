using System;
using System.Collections.Generic;

class BinToHex
{
    static string ConvertToHex(string binRepresentation)
    {
        char[] binRepChar = binRepresentation.ToString().ToCharArray();
        int lenght = binRepChar.Length;
        int lenghtCount= 0;
        int upper = 0;
        int lower = 0;
        int power;
        int inHex = 0;
        char hex ='0';
        string result=null;
        do
        {
            lenght = lenght/4;
            lenghtCount++;
        }while(lenght!=0);

        lower = binRepChar.Length;
        //Console.WriteLine(binRepChar.Length);
        do
        {
            upper = lower-1;
            power = upper - 4;
            if (power >= 0)
            {
                power = 3;
            }
            if (power < 0)
            {
                power = power + 4;
            }
            lower = lower - 4;
            
            if (lower <= 0)
            {
                lower = 0;
            }
            for (int i = lower; i <= upper; i++, power--)
            {
                //Console.WriteLine("lower{0}  upper{1}",lower,upper);
                
                {
                    //Console.WriteLine("chislo{0} po {1}",binRepChar[i],power);
                    inHex = (binRepChar[i] - 48 )* ((int)Math.Pow(2, power)) + inHex;
                    //Console.WriteLine(inHex);
                }
            }
            //Console.WriteLine(inHex);
            if (inHex > 9)
            {
                hex = (char)(inHex + 55);
               
            }
            if (inHex <= 9)
            {
                hex = (char)(inHex+48);
            }
            result = hex.ToString() + result;
            //Console.WriteLine("{0}+++++",result);
            inHex = 0;
            lenghtCount--;
        } while (lenghtCount > 0);

        return result;
    }
    /*__________________________________________________________________________*/
    static void Main(string[] args)
    {
        string binValue;
        string hexValue;
        Console.Write("Enter sequence of bits(1's and 0's)");
        binValue = Console.ReadLine();

        hexValue = ConvertToHex(binValue);
        Console.WriteLine();
        Console.Write("In Hex ->");
        Console.Write(hexValue);
        Console.WriteLine();
    }
}

 