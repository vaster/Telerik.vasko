using System;

class MaximalSum
{
    static void Main(string[] args)
    {
        int n;
        int m;
        Console.WriteLine("For NxM");
        Console.Write("Enter N:");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter M:");
        m = int.Parse(Console.ReadLine());
        int currSum = 0;
        int max = 0;
        /////////////////////////////////////
        int[,] matrix =  new int[n,m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("Enter number for matrix[{0},{1}]:",row,col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        for (int row = 1; row <= n-2; row++)
        {
            for (int col = 1; col <= m-2; col++)
            {
                currSum = matrix[row, col] + matrix[row - 1, col - 1] + matrix[row + 1, col + 1] + matrix[row, col - 1] + matrix[row + 1, col] + matrix[row+1, col - 1]
                    + matrix[row, col + 1] + matrix[row-1, col + 1] + matrix[row-1,col];
                if (currSum > max)
                {
                    max = currSum;
                }
            }
        }

        Console.WriteLine("max sum is {0}",max); 



    }
}

