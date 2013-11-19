using System;

class CompareTwoIntArrays
{
    static void Main()
    {
        int lenghtAndValuesFirst;
        int lenghtAndValuesSecond;
        bool even = true;

        Console.WriteLine("Enter lenght of arrays:");
        lenghtAndValuesFirst = int.Parse(Console.ReadLine());
        lenghtAndValuesSecond = lenghtAndValuesFirst;
        //////////////////////////////////////////////////
        int[] first = new int[lenghtAndValuesFirst];
        //////////////////////////////////////////////////
        for (int i = 0; i < first.Length; i++)
        {
            Console.Write("first[{0}] = ", i);
            lenghtAndValuesFirst = int.Parse(Console.ReadLine());
            first[i] = lenghtAndValuesFirst;
        }
        /////////////////////////////////////////////////////
        int[] second = new int[lenghtAndValuesSecond];
        /////////////////////////////////////////////////
        for (int i = 0; i < second.Length; i++)
        {
            Console.Write("second[{0}] = ", i);
            lenghtAndValuesSecond = int.Parse(Console.ReadLine());
            second[i] = lenghtAndValuesSecond;
        }
        ////////////////////////////////////////////////
        for (int i = 0; i < first.Length; i++)
        {
            if (first[i] != second[i])
            {
                Console.WriteLine("Sorry.");
                even = false;
                break;
            }
        }
        if (even)
        {
            Console.WriteLine("They're even.");
        }
    }
}

