using System;

class BinnarySearch
{
    static void Main()
    {
        int seeked;
        int lenght;
        int range;
        int rangeOne=0;
        int rangeTwo = 0;
        int seekedIndex = 0;
        Console.Write("Enter number(to search for its position):");
        seeked = int.Parse(Console.ReadLine());

        Console.Write("Enter array's leght:");
        lenght = int.Parse(Console.ReadLine());
        ///////////////////////////////////
        int[] sortedSequenceOfInt = new int[lenght];
        Console.WriteLine("Enter sorted sequence of nubmers!");
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("array[{0}]=",i);
            sortedSequenceOfInt[i] = int.Parse(Console.ReadLine());
        }

        range = lenght / 2;
        
        
        if (sortedSequenceOfInt[range] == seeked)
        {
            seekedIndex = range;

        }
        if (sortedSequenceOfInt[range] < seeked)
        {
            rangeOne = range + 1;
            rangeTwo = sortedSequenceOfInt.Length;
            
        }
        if (sortedSequenceOfInt[range] > seeked)
        {
            rangeOne = 0;
            rangeTwo = range;
            
        }
        for (;rangeOne < rangeTwo; rangeOne++)
        {
            if (sortedSequenceOfInt[rangeOne] == seeked)
            {
                seekedIndex = rangeOne;
                
            }
        }

        Console.WriteLine("The idex of {0} is {1}",seeked,seekedIndex);

    }
}

