using System;

class MaxSum
{
    static void Main()
    {
        int n;
        int k;
        int sum = 0;
        int maxSum = 0;
        int sortIt = 0;
        int doIt = 0;

        Console.WriteLine("Enter N:");
        n = int.Parse(Console.ReadLine());
        ////////////////////////////////////
        int[] array = new int[n];
        ////////////////////////////////////
        Console.WriteLine("Enter K:");
        k = int.Parse(Console.ReadLine());

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ",i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (; doIt < k + sortIt; doIt++)
        {
            //Console.WriteLine("i = {0}", doIt);
            //Console.WriteLine("SortIt = {0}", sortIt);
            sum = sum + array[doIt];
            if (sum > maxSum)
            {
                maxSum = sum;
            }
            if (doIt == k + sortIt - 1 && k + sortIt < n)
            {
                sortIt++;
                sum = 0;
                doIt = 0;
                doIt = doIt + sortIt - 1;
                //Console.WriteLine("|||||||||||||||||||");
                ///////////////////////////////////////////

            }
        }

        Console.WriteLine("Max sum is {0}",maxSum);
    }
}

