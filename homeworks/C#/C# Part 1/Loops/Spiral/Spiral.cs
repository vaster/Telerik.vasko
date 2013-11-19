using System;

class Spiral
{
    static void Main()
    {
        int rows = 0;
        int cols = 0;
        int rowCounter = 0;
        int colCounter = 0;
        int flag = 0;
        int check = 0;
        int check2 = 0;

        Console.Write("Enter N,(N<20):");
        rows = int.Parse(Console.ReadLine());
        cols = rows;
        //Console.WriteLine("{0},{1}",rows,cols);
        int[,] spiral = new int[rows, cols];

        check = cols - 2;
        //check2 = cols +cols-2;

        for (int i = 1; i <= 9; i++)
        {
            spiral[rowCounter, colCounter] = i;
            
            if (i<cols)
            {
                colCounter++;
            }
            if (colCounter==cols-1&&i < cols * 2 - 1)
            {
                rowCounter++;
            }

            



        }

        for (int i = 0; i < rows; i++)
        {
            for (int p = 0; p < cols; p++)
            {
                Console.Write("{0} ", spiral[i, p]);
                if (p == cols - 1)
                    Console.WriteLine();
            }

        }
    }
}

