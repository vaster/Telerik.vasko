using System;
using System.Collections.Generic;

class DecimalToHex
{
    static char[] ConvertItToHex(int decimalRepresentation)
    {
        List<decimal> hex = new List<decimal>();
        decimal calculation;
        decimal calculationReminder;
        int x = 0;
        do
        {

            calculation = (decimal)decimalRepresentation / 16;
            decimalRepresentation = (int)Math.Truncate(calculation);
            calculationReminder = calculation - Math.Truncate(calculation);
            calculationReminder = Math.Truncate(calculationReminder * 16);
            hex.Add(calculationReminder);
            x++;
        } while (calculation != 0);

        char[] digitsChar = new char[hex.Capacity];
        for (int i = x - 2, y = 0; i >= 0; i--, y++)
        {
            if (hex[y] < 10)
            {
                digitsChar[i] = (char)(hex[y] + 48);
            }
            if (hex[y] == 10)
            {
                digitsChar[i] = 'A';
            }
            if (hex[y] == 11)
            {
                digitsChar[i] = 'B';
            }
            if (hex[y] == 12)
            {
                digitsChar[i] = 'C';
            }
            if (hex[y] == 13)
            {
                digitsChar[i] = 'D';
            }
            if (hex[y] == 14)
            {
                digitsChar[i] = 'E';
            }
            if (hex[y] == 15)
            {
                digitsChar[i] = 'F';
            }
        }


        return digitsChar;
    }
    /*_____________________________________________________________*/
    static void Main(string[] args)
    {
        int decim;

        Console.Write("Enter decimal number:");
        decim = int.Parse(Console.ReadLine());
        char[] hex = ConvertItToHex(decim);

        Console.WriteLine();
        Console.Write("0x");
        foreach (var item in hex)
        {
            Console.Write(item);
        }
       

    }
}

