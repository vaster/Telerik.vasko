using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        int lenghtOfFirstSequence;
        int lenghtOfSecondSequence;

        Console.Write("Enter lenght of first char array:");
        lenghtOfFirstSequence = int.Parse(Console.ReadLine());

        char[] firstSequence = new char[lenghtOfFirstSequence];

        for (int i = 0; i < firstSequence.Length; i++)
        {
            Console.Write("Symbol {0} in first array =",i+1);
            firstSequence[i] = char.Parse(Console.ReadLine());         
        }

        Console.Write("Enter lenght of second char array:");
        lenghtOfSecondSequence = int.Parse(Console.ReadLine());

        

        char[] secondSequence = new char[lenghtOfSecondSequence];

        for (int i = 0; i < secondSequence.Length; i++)
        {
            Console.Write("Symbol {0} in second array = ",i+1);
            secondSequence[i] = char.Parse(Console.ReadLine());
        }

        if (lenghtOfFirstSequence != lenghtOfSecondSequence)
        {
            Console.WriteLine("Differs in lenghts");
        }
        if (lenghtOfFirstSequence == lenghtOfSecondSequence)
        {
            for (int i = 0; i < firstSequence.Length; i++)
            {
                if (firstSequence[i] == secondSequence[i])
                {
                    Console.WriteLine("firstSequence[{0}] even to secondSequence[{1}]",i,i);
                }
                if (firstSequence[i] > secondSequence[i])
                {
                    Console.WriteLine("firstSequence[{0}] comes befour secondSequence[{1}]",i,i);
                }
                if (firstSequence[i] < secondSequence[i])
                {
                    Console.WriteLine("secondSequence[{0}] comes befour firstSequence[{1}]",i,i);
                }
            }
        }
        
    }
}

