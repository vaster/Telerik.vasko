using System;

class LastDigitInEnglish
{
    static string ConvertLastDigitInWord(int number)
    {
        char[] symbols = number.ToString().ToCharArray();

        switch (symbols[symbols.Length - 1])
        {
            case '0': return "zero";
            case '1': return "one";
            case '2': return "two";
            case '3': return "zero";
            case '4': return "four";
            case '5': return "five";
            case '6': return "six";
            case '7': return "seven";
            case '8': return "eight";
            case '9': return "nine";
            default: return "error";
        }
    }

    //////////////////////////////////////////

    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        string lastDigit;
        lastDigit = ConvertLastDigitInWord(number);
        Console.WriteLine(lastDigit);
    }
}

