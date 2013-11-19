using System;

class MatrixByPatern
{
    static void Printing(int n, int[,] matrix)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0} ", matrix[col, row]);

            }

            Console.WriteLine();

        }
    }
    /*___________________________________________________________*/
    static void ManipulationByFirstPatern(int n, int[,] matrix)
    {
        int value = 1;
        int col = 0;
        int row = 0;
        int coef = 1;
        int coef2 = 0;
        for (; col < n; col++)
        {
            if (col % 2 != 0)
            {

                coef = -1;
                coef2 = n + 1;
                row--;

            }
            if (col % 2 == 0 && col != 0)
            {
                row++;
                coef = 1;
                coef2 = 0;
            }


            for (; row != n - coef2; row = row + coef, value++)
            {
                matrix[col, row] = value;

            }

        }

        Printing(n, matrix);
    }
    /*___________________________________________________________*/
    static void ManipulationBySecondPatern(int n, int[,] matrix)
    {
        int value = 1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++, value++)
            {
                matrix[col, row] = value;

            }
        }

        Printing(n, matrix);
    }
    /*____________________________________________________________*/
    static void Main(string[] args)
    {
        int n;


        Console.Write("Enter N for NxN matrix :");
        n = int.Parse(Console.ReadLine());
        ////////////////////////////////////
        int[,] matrix = new int[n, n];
        ///////////////////////////////////
        ManipulationByFirstPatern(n, matrix);
        Console.WriteLine();
       // ManipulationBySecondPatern(n, matrix);
    }
}

