using System;

class BinarySearchMethod
{
    static void Main(string[] args)
    {
        int lenght;
        int min = 0;
        int j;
        int k;
        int search = 0;

        Console.Write("Enter K:");
        k = int.Parse(Console.ReadLine());



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


        for (int i = 0; i < array.Length; i++)
        {
            min = int.MaxValue;
            //Console.WriteLine("I is {0}",i);
            for (j = 0 + i; j < array.Length; j++)
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


            //search = Array.BinarySearch(array, k);
        }
        //if (Array.BinarySearch(array, k) >= 0)
        {
            search = Array.BinarySearch<int>(array,k);
        }

        if (search >= 0)
        {
            Console.WriteLine("Lagest number <= {0} is {1}", k, array[search]);
        }
        else
        {
            Console.WriteLine("Lagest number <= {0} is {1}", k, array[array.Length-1]);
        }
    }
}

