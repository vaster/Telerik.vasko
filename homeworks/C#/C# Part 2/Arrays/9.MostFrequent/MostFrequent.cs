using System;

class MostFrequent
{
    static void Main()
    {
        int lenght;
        int count = 0;
        int maxCount = 0;
        int maxNumber = 0;

        Console.Write("Enter lenght of array:");
        lenght = int.Parse(Console.ReadLine());

        int[] array = new int[lenght];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
                maxNumber = array[i];
            }
            count = 0;
        }

        Console.WriteLine("{0}({1} times)",maxNumber,maxCount);
    }
}

