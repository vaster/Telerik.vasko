using System;

class Sort
{
    static void Main()
    {
        int lenght;
        int min = 0;
        int search = 0;
        int j;
        int position = 0;



        Console.Write("Enter lenght of array:");
        lenght = int.Parse(Console.ReadLine());

        int[] array = new int[lenght];
        int temp;
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        ////////////////

        ///////////////
        
        for (int i = 0; i < array.Length; i++)
        {
            min = int.MaxValue;
            //Console.WriteLine("I is {0}",i);
            for (j = 0+i; j < array.Length; j++)
            {
                if (array[j] < min)
                {
                    min = array[j];
                    index = j;
                }
                
            }
            temp = array[i];
            array[i] = min;
            array[index] = temp;
           
            //search++;

        }
        foreach (var number in array)
        {
            Console.WriteLine(number);
        }
    }
}

