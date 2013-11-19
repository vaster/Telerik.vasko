using System;
using System.Collections.Generic;

class HexToBin
{
    static List<int> ConvertToBin(string hexRepresentation)
    {
        char[] hexRepChar = hexRepresentation.ToCharArray();
        int toBit = 0;
        int toBitTemp = 0;
        int lenght = 0;
        int lenghtCount=0;
        List<int> inBits = new List<int>();
        

        for (int i = 0; i < hexRepChar.Length; i++)
        {
            if (hexRepChar[i] > '9')
            {
                toBit = hexRepChar[i] - 55;
            }
            if (hexRepChar[i] <= '9')
            {

                toBit = hexRepChar[i] - 48;
            }
            toBitTemp = toBit;
            lenght = toBit;
            do
            {
                lenght = lenght/2;
                lenghtCount++;
            }while(lenght!=0);
            if (lenghtCount < 4)
            {
                lenghtCount = 4;
            }
            
            int[] reverseIt = new int[lenghtCount];
            lenghtCount--;
            do
            {
                toBit = toBitTemp % 2;
                //inBits.Add(toBit);
                reverseIt[lenghtCount] = toBit;
                toBitTemp = toBitTemp / 2;
                lenghtCount--;
                //Console.WriteLine("{0}", toBitTemp);
            } while (lenghtCount>=0);
            inBits.AddRange(reverseIt);
        }

        return inBits;
    }
    /*_______________________________________________________*/
    static void Main(string[] args)
    {
        List<int> hexValueToBin = new List<int>();
        string hexValue;

        Console.Write("Enter 0x value:");
        hexValue = Console.ReadLine();
        hexValueToBin.AddRange(ConvertToBin(hexValue));
        Console.WriteLine();
        Console.Write("Binary ->");
        foreach (var item in hexValueToBin)
        {
            Console.Write(item);
        }
    }
}

