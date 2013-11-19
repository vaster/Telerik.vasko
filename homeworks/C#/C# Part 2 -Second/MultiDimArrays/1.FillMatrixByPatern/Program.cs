using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FillMatrixByPatern
{
    public class Program
    {

        /*
         Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
         */

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}",matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void PatternOne(int n)
        {
            int[,] matrix = new int[n, n];

            int row = n;
            int col = n;

            int value = 1;

            for (int currRow = 0; currRow < col; currRow++)
            {
                for (int currCol = 0; currCol < row; currCol++)
                {
                    matrix[currCol, currRow] = value;
                    value++;
                }
            }

            Console.WriteLine("Pattern One:");
            Program.PrintMatrix(matrix);
            Console.WriteLine();
        }

        public static void PatternTwo(int n)
        {
            int[,] matrix = new int[n, n];

            int row = n;
            int col = n;

            int value = 1;
            int prev = 0;

            for (int currCol = 0; currCol < col; currCol++)
            {
                for (int currRow = 0; currRow < row; currRow++)
                {
                    matrix[currRow, currCol] = value;
                    if (currCol % 2 == 0)
                    {
                        value++;
                    }
                    else
                    {
                        value--;
                    }
                }
                prev = matrix[n - 1, currCol];
                value = prev + n;
            }

            Console.WriteLine("Pattern Two:");
            Program.PrintMatrix(matrix);
            Console.WriteLine();
        }

        public static void PatternFour(int n)
        {
            int[,] matrix = new int[n, n];

            int value = 1;

            int rowCoeff = 0;
            int colCoeff = 0;

           
            int interator = 1;

            do
            {
                interator++;
                //by first col down
                for (int row = 0; row < n; row++)
                {
                    if (matrix[row, 0 + colCoeff] == 0)
                    {
                        matrix[row, 0+ colCoeff] = value;
                        value++;
                    }
                }

                //by last row left
                for (int col = 0; col < n; col++)
                {
                    if (matrix[n - 1 - rowCoeff, col] == 0)
                    {
                        matrix[n - 1 - rowCoeff, col] = value;
                        value++;
                    }
                }

                //by last col up
                for (int row = n-1; row >= 0; row--)
                {
                    if (matrix[row, n-1 - colCoeff] == 0)
                    {
                        matrix[row, n-1 - colCoeff] = value;
                        value++;
                    }
                }

                for (int col = n-1; col >=0; col--)
                {
                    if (matrix[0 + rowCoeff, col] == 0)
                    {
                        matrix[0 + rowCoeff, col] = value;
                        value++;
                    }
                    
                }

                colCoeff++;
                rowCoeff++;

            } while (interator <= n / 2);

            Console.WriteLine("Pattern Four:");
            Program.PrintMatrix(matrix);
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            // N:
            int n = 4;

            Program.PatternOne(n);
            Program.PatternTwo(n);
            Program.PatternFour(n);
        }
    }
}
