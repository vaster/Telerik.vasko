using System;

class CheckNeighborsReturnIndex
{
    static int FindPosition(params int[] array)
    {
        int iFoundIt;
        if (array.Length >= 2)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    return iFoundIt = i;
                }
            }
        }
        return -1;
    }


    static void Main(string[] args)
    {
        int lenght;
        int position;

        Console.Write("Enter leght of array:");
        lenght = int.Parse(Console.ReadLine());

        int[] array = new int[lenght];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ");
            array[i] = int.Parse(Console.ReadLine());
        }

        position = FindPosition(array);
        Console.WriteLine("It is on position {0}",position);
    }
}

