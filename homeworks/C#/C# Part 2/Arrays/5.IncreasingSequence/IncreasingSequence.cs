using System;

class IncreasingSequence
{
    static void Main()
    {
        int lenght;
        int sequence = 1;
        int store = 0;
        int max  = 0;

        Console.Write("Enter lenght of array:");
        lenght = int.Parse(Console.ReadLine());

        int[] storeNumbers = new int[lenght];
        int[] storeSequence = new int[lenght];

        for (int i = 0; i < storeNumbers.Length ; i++)
        {
            Console.Write("storeNumbers[{0}] = ",i);
            storeNumbers[i] = int.Parse(Console.ReadLine());
        }
        //////////////////////////////////////////////////
        for (int i = 0; i < storeNumbers.Length - 1; i++)
        {
            if (storeNumbers[i] + 1 == storeNumbers[i + 1])
            {
                sequence++;
                if(sequence>max)
                {
                    max = sequence;
                }
                storeSequence[store] = storeNumbers[i];
                storeSequence[store + 1] = storeNumbers[i + 1];
                store++;
            }
            if (storeNumbers[i] + 1 != storeNumbers[i + 1])
            {
                sequence = 1;
                store = 0;
            }
        }
        Console.Write("{");
        for (int i = 0; i < max; i++)
        {
            Console.Write("{0}",storeSequence[i]);
            if (i != max - 1)
            {
                Console.Write(",");
            }
        }
        Console.Write("}");
    }
}

