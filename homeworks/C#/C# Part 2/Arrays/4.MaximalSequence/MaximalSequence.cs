using System;

class MaximalSequence
{
    static void Main()
    {
        int lenght;
        int max = 0;
        int store = 0;
        int sequenceLenght = 1;


        Console.Write("Enter How many number you need:");
        lenght = int.Parse(Console.ReadLine());

        int[] sequenceOfInts = new int[lenght];
        int[] keepSequence = new int[lenght];

        for (int i = 0; i < sequenceOfInts.Length; i++)
        {
            Console.Write("sequenceOfInts[{0}] = ", i);
            sequenceOfInts[i] = int.Parse(Console.ReadLine());
        }
        //////////////////////////////////////////////////
        for (int i = 0; i < sequenceOfInts.Length - 1; i++)
        {
            if (sequenceOfInts[i] == sequenceOfInts[i + 1])
            {
                sequenceLenght++;
                if (sequenceLenght > max)
                {
                    max = sequenceLenght;
                }
                keepSequence[store] = sequenceOfInts[i];
                keepSequence[store + 1] = sequenceOfInts[i + 1];
                store++;
            }
            if (sequenceOfInts[i] != sequenceOfInts[i + 1])
            {
                sequenceLenght = 1;
                store = 0;
            }
        }
        Console.Write("{");
        for (int i = 0; i < keepSequence.Length-(keepSequence.Length-max); i++)
        {
            Console.Write("{0}",keepSequence[i]);
            if (i != keepSequence.Length - (keepSequence.Length - max)-1)
            {
                Console.Write(",");
            }
        }
        Console.Write("}");
    }
}

