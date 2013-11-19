using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.AdjacentEmpyCells
{
    /*
     Write a recursive program to find the largest connected area of adjacent empty cells in a matrix
     */

    public class Program
    {
        public static int CurrCellCount = 0;
        public static int MaxCellCount = 0;
      
        public static void FindBiggestAreaOfEmptyCells(Matrix matrix, int startRow, int startCol, Matrix[] result, bool[,] passedCells)
        {
            if (startCol < 0 || startRow < 0 || startCol >= Matrix.SIZE || startRow >= Matrix.SIZE)
            {
                return;
            }

            if (matrix[startRow, startCol] != Matrix.EMPTY_CELL_SYMBOL)
            {
                Matrix currMatrix = new Matrix();

                if (Program.CurrCellCount > Program.MaxCellCount)
                {
                    Program.MaxCellCount = Program.CurrCellCount;

                    for (int row = 0; row < Matrix.SIZE; row++)
                    {
                        for (int col = 0; col < Matrix.SIZE; col++)
                        {
                            currMatrix[row, col] = matrix[row, col];
                        }
                    }

                    result[0] = currMatrix;
                }

                return;
            }

            matrix[startRow, startCol] = Matrix.PASSED_CELL_SYMBOL;
            passedCells[startRow, startCol] = true;
            Program.CurrCellCount++;

            Console.Clear();
            matrix.PrintOnConsole();
            System.Threading.Thread.Sleep(150);

            Program.FindBiggestAreaOfEmptyCells(matrix, startRow + 1, startCol, result,passedCells);
            Program.FindBiggestAreaOfEmptyCells(matrix, startRow - 1, startCol, result,passedCells);
            Program.FindBiggestAreaOfEmptyCells(matrix, startRow, startCol + 1, result,passedCells);
            Program.FindBiggestAreaOfEmptyCells(matrix, startRow, startCol - 1, result,passedCells);
       
        }

        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();

            matrix.Initialize();
            bool[,] passedCells = new bool[Matrix.SIZE,Matrix.SIZE];
            Matrix[] result = new Matrix[1];
            for (int row = 0; row < Matrix.SIZE; row++)
            {
                for (int col = 0; col < Matrix.SIZE; col++)
                {
                    if (!passedCells[row, col])
                    {
                        Program.CurrCellCount = 0;
                        Program.FindBiggestAreaOfEmptyCells(matrix, row, col, result, passedCells);
                        matrix.Reset();
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Best Area:");
            result[0].PrintOnConsole();
            
        }
    }
}

