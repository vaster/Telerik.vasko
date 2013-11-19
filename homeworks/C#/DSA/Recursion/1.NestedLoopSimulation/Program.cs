using System;

class CombinationsGenerator
{
    static void Main()
    {
        Console.Write("N:");
        int n = int.Parse(Console.ReadLine());
        int endNum = n;

        int[] arr = new int[n];
        GenerateCombinations(arr, 0, endNum);
    }

    static void GenerateCombinations(int[] arr, int index, int endNum)
    {
        if (index >= arr.Length)
        {
            Console.WriteLine("(" + String.Join(", ", arr) + ")");
        }
        else
        {
            for (int i = 1; i <= endNum; i++)
            {
                arr[index] = i;
                GenerateCombinations(arr, index + 1,  endNum);

            }
        }
    }
}
