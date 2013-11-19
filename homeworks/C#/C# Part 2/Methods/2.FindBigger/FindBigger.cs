using System;

class FindBigger
{
    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else if (a < b)
        {
            return b;
        }
        else
        {
            return 0;
        }
    }

    //////////////////////////////////

    static void Main(string[] args)
    {
        int numberA = int.Parse(Console.ReadLine());
        int numberB = int.Parse(Console.ReadLine());
        int numberC = int.Parse(Console.ReadLine());
        int max;

        max = GetMax(numberA, numberB);
        max = GetMax(max, numberC);


        Console.WriteLine(max);



    }
}

