using System;
using System.Collections.Generic;

class AnyToAny
{
    static string ConvertFromDecimalToAny(string decimalRep, int toThisBase)
    {
        int decimalRepInt = Convert.ToInt32(decimalRep);
        int likeDecimalRepInt = decimalRepInt;
        string finalString = "null";


        do
        {
            decimalRepInt = likeDecimalRepInt % toThisBase;
            if (decimalRepInt <= 9)
            {
                finalString = finalString + decimalRepInt;
            }
            if (decimalRepInt > 9)
            {
                finalString = finalString + (char)(decimalRepInt + 55);
            }
            likeDecimalRepInt = likeDecimalRepInt / toThisBase;

        } while (likeDecimalRepInt != 0);
        finalString = finalString.Trim('n', 'u', 'l');
        char[] finalChar = finalString.ToCharArray();
        finalString = "null";
        for (int i = 0; i < finalChar.Length; i++)
        {
            finalString = finalChar[i] + finalString;
        }
        finalString = finalString.Trim('n', 'u', 'l');
        return finalString;
    }
    /*______________________________________________________________________________________*/
    static string ConvertFromAnyBaseToDecimal(string currentBaseRep, int currentBase)
    {
        char[] randomBaseRepChar = currentBaseRep.ToCharArray();
        int decimalRep = 0;
        string decimalStringRep;
        for (int i = 0, power = currentBaseRep.Length - 1; i < randomBaseRepChar.Length; i++, power--)
        {
            decimalRep = decimalRep + (randomBaseRepChar[i] - 48) * (int)Math.Pow(currentBase, power);
        }
        decimalStringRep = decimalRep.ToString();
        //Console.WriteLine(decimalStringRep);
        return decimalStringRep;
    }
    /*__________________________________________________________________________________*/
    static void Main(string[] args)
    {
        int fromBase;
        int toBase;
        int digitsOfCurrentBase = 0;
        string fromThisBaseRep;
        string decimalRep;
        string toBaseRep;
        Console.WriteLine("Choose to convert from s base --> to d base:");
        Console.Write("From ");
        fromBase = int.Parse(Console.ReadLine());
        Console.Write("To ");
        toBase = int.Parse(Console.ReadLine());


        Console.Write("Enter only sequence of this symbols:");
        do
        {
            Console.Write("{0}, ", digitsOfCurrentBase);
            digitsOfCurrentBase++;
        } while (digitsOfCurrentBase != fromBase);
        Console.WriteLine("for the current base.");
        //////////////////////////////////////////////
        Console.Write("your number:");
        fromThisBaseRep = Console.ReadLine();
        //////////////////////////////////////////////
        decimalRep = ConvertFromAnyBaseToDecimal(fromThisBaseRep, fromBase);
        toBaseRep = ConvertFromDecimalToAny(decimalRep, toBase);

        Console.WriteLine(toBaseRep);


    }


}


