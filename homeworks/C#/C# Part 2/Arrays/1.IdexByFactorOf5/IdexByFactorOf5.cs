using System;

class IdexByFactorOf5
{
    static void Main()
    {
        int[] indexBy5Array = new int[20];
        for (int i = 0; i < indexBy5Array.Length; i++)
        {
            indexBy5Array[i] = i * 5;
        }

        foreach(var content in indexBy5Array)
        {
            Console.WriteLine(content);
        }
    }
}

