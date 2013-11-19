using System;

class LongestSequence
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

        int maxCol = 0;
        int currLenght = 1;
        int maxRow = 0;
        int maxDiagonal = 0;
        string stringCol = null;
        string stringRow = null;
        string stringDiagonal = null;
        string[,] matrix = new string[n, m];
        /////////////////////////////////////


        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("Enter string for matrix[{0},{1}]:", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }


        for (int row = 0; row < n; row++)
        {
            currLenght = 1;
            for (int col = 0; col < m - 1; col++)
            {
                if (matrix[row, col].Equals(matrix[row, col + 1]))
                {
                    currLenght++;
                    if (currLenght > maxCol)
                    {
                        // stringCol = null;
                        maxCol = currLenght;
                        stringCol = matrix[row, col];
                    }
                }
                else
                {
                    currLenght = 1;
                    //
                }

            }
        }
        ////////////////////////////////////////////////////

        for (int col = 0; col < m; col++)
        {
            currLenght = 1;
            for (int row = 0; row < n - 1; row++)
            {
                if (matrix[row, col].Equals(matrix[row + 1, col]))
                {
                    currLenght++;
                    if (currLenght > maxRow)
                    {
                        // stringCol = null;
                        maxRow = currLenght;
                        stringRow = matrix[row, col];
                    }
                }
                else
                {
                    currLenght = 1;
                    //
                }

            }
        }
        //////////////////////////////////////////////////////

        for (int row = 0; row < n - 1; row++)
        {
            //currLenght = 1;
            for (int col = 0; col < m - 1; col++)
            {
                if (matrix[row, col].Equals(matrix[row + 1, col + 1]))
                {
                    currLenght++;
                    if (currLenght > maxDiagonal)
                    {
                        // stringCol = null;
                        maxDiagonal = currLenght;
                        stringDiagonal = matrix[row, col];
                    }
                }
               
            }
        }

        Console.WriteLine(maxDiagonal);
        /////////////////////////////////////////////////

        if (maxCol > maxRow && maxCol > maxDiagonal)
        {
            for (int i = 0; i < maxCol; i++)
            {
                Console.Write(stringCol + ",");
            }
        }
        //////////////////////////////////////
        if (maxRow > maxCol && maxRow > maxDiagonal)
        {
            for (int i = 0; i < maxRow; i++)
            {
                Console.Write(stringRow + ",");
            }
        }

        if (maxDiagonal > maxCol && maxDiagonal > maxRow)
        {
            for (int i = 0; i < maxDiagonal; i++)
            {
                Console.Write(stringDiagonal + ",");
            }
        }


    }
}

