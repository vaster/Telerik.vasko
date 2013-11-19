using System;

class FindMaxSort
{

    static int FindBigges(int startPosition, params int[] array)
    {
        int max = int.MinValue;

        for (int i = startPosition; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        if (startPosition > array.Length || startPosition < 0)
        {
            return -1;
        }

        return max;

    }
    ///////////////////////////
    static int[] SortIt(params int[] array)
    {
        int tempMax;
        int tempPosition = 0;
        int temp = 0;
        int sortingOrder;


        Console.WriteLine("1.Ascending:");
        Console.WriteLine("2.Descending:");
        sortingOrder = int.Parse(Console.ReadLine());

        tempMax = FindBigges(0, array);
        for (int j = 0; j < array.Length; j++)
        {

            if (sortingOrder == 1)
            {
                for (int i = 0; i < array.Length - j; i++)
                {

                    if (array[i] >= tempMax)
                    {
                        tempMax = array[i];
                        tempPosition = i;
                    }

                }
            }
 ///////////////////////////////////////////////////////////////////////
            if (sortingOrder == 2)
            {
                for (int i = 0 + j; i < array.Length; i++)
                {

                    if (array[i] >= tempMax)
                    {
                        tempMax = array[i];
                        tempPosition = i;
                    }

                }
            }


            if (sortingOrder == 1)
            {
                temp = array[array.Length - 1 - j];
                array[array.Length - 1 - j] = tempMax;
                array[tempPosition] = temp;
            }
            if (sortingOrder == 2)
            {
                temp = array[0 + j];
                array[0 + j] = tempMax;
                array[tempPosition] = temp;
            }

            tempMax = int.MinValue;


        }

        return array;
    }
    ///////////////////////////

    static void Main(string[] args)
    {
        int lenght;
        int start;
        int max;

        Console.Write("Enter lenght of array:");
        lenght = int.Parse(Console.ReadLine());

        int[] array = new int[lenght];

        for (int i = 0; i < lenght; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter index to start searching from it:");
        start = int.Parse(Console.ReadLine());

        max = FindBigges(start, array);
        if (max != -1)
        {
            Console.WriteLine(max);
        }
        else
        {
            Console.WriteLine("starting position is wrong,No max");
        }
        //1
        Console.WriteLine("Sorted array:");
        int[] sortedArray = SortIt(array);
        for (int i = 0; i < sortedArray.Length; i++)
        {
            Console.Write("{0},", sortedArray[i]);
        }
    }
}

