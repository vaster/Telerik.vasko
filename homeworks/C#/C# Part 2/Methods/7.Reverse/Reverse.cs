using System;

class Reverse
{
    static decimal ReverseIt(decimal number)
    {
        char[] toElements = number.ToString().ToCharArray();
        char[] toElementsReversed = new char[toElements.Length];
        string numberToString;
        decimal numberReversed;
        for (int i = 0, j = toElements.Length - 1; i < toElements.Length; i++, j--)
        {
            toElementsReversed[i] = toElements[j];
        }
        numberToString = new string(toElementsReversed);
        numberReversed = Convert.ToDecimal(numberToString);

        return numberReversed;
    }
    static void Main(string[] args)
    {
        decimal number;

        Console.Write("enter number to be reversed(For decimal use ',' for decimal point):");
        number = decimal.Parse(Console.ReadLine());

        number = ReverseIt(number);

        Console.WriteLine(number);

    }
}

