using System;

class CountNumber
{
    static int CountОccurrences(int lookFor, params int[] number)
    {
        int count = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (lookFor == number[i])
            {
                count++;
            }
        }

        return count;
    }


    static void Main(string[] args)
    {
        int lenght;
        int lookFor;
        int occurrences;

        Console.WriteLine("Enter leght of array:");
        lenght = int.Parse(Console.ReadLine());
        /////////////////////////////////
        int[] storeNumbers = new int[lenght];
        /////////////////////////////////
        for (int i = 0; i < storeNumbers.Length; i++)
        {
            Console.Write("storeNumbers[{0}] = ", i);
            storeNumbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter number to to be counter:");
        lookFor = int.Parse(Console.ReadLine());
        occurrences = CountОccurrences(lookFor,storeNumbers);

        Console.WriteLine("{0} occurrences {1} times",lookFor,occurrences);


    }
}

