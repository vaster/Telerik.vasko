using System;

class CheckNeighbors
{
    static bool CheckIsItBigger(int position, params int[] array)
    {
        if (position >= 1)
        {
            if(array[position]>array[position-1] && array[position]>array[position+1])
            {
                return true;
            }
            if (array[position] <= array[position - 1] || array[position] <= array[position + 1])
            {
                return false;
            }
        }

        if (position < 1 || position >= array.Length - 1)
        {
            return false;
        }

        else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        int lenght;
        int position;
        bool result;

        Console.Write("Enter lenght of array:");
        lenght = int.Parse(Console.ReadLine());

        int[] array = new int[lenght];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter position:");
        position = int.Parse(Console.ReadLine());

        if (lenght >= 2)
        {
            result = CheckIsItBigger(position, array);

            if (result)
            {
                Console.WriteLine("It is bigger!");
            }

            else if (!result)
            {
                Console.WriteLine("It is not, or bad position choice!");
            }
        }
        else
        {
            Console.WriteLine("Not enough elements");
        }
    }
}

