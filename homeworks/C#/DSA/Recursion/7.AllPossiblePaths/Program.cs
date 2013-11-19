using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _7.AllPossiblePaths
{

    /*
     We are given a matrix of passable and non-passable cells.
     Write a recursive program for finding all paths between two cells in the matrix.

     */

    public class Program
    {
        public static void FindPaths(Matrix matrix, int startRow, int startCol, List<Matrix> result)
        {
            if (startCol < 0 || startRow < 0 || startCol >= Matrix.MATRIX_SIZE || startRow >= Matrix.MATRIX_SIZE)
            {
                return;
            }

            if (matrix[startRow, startCol] == Matrix.FINALE_SYMBOL)
            {
                Matrix currMatrix = new Matrix();
                for (int row = 0; row < Matrix.MATRIX_SIZE; row++)
                {
                    for (int col = 0; col < Matrix.MATRIX_SIZE; col++)
                    {
                        currMatrix[row, col] = matrix[row, col];
                    }
                }

                result.Add(currMatrix);
                return;
            }

            if (matrix[startRow, startCol] != Matrix.EMPTY_CELL_SYMBOL)
            {
                return;
            }

            matrix[startRow, startCol] = Matrix.PASSED_CELL_SYMBOL;
          
            Program.FindPaths(matrix, startRow + 1, startCol, result);
            Program.FindPaths(matrix, startRow - 1, startCol, result);
            Program.FindPaths(matrix, startRow, startCol + 1, result);
            Program.FindPaths(matrix, startRow, startCol - 1, result);

            matrix[startRow, startCol] = Matrix.EMPTY_CELL_SYMBOL;
        }

        // start is at {0,0}
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            // finale
            matrix.FinaleRow = 4;
            matrix.FinaleCol = 4;

            matrix.Initialize();
           
            List<Matrix> result = new List<Matrix>();
            Program.FindPaths(matrix, 0, 0, result);

            foreach (Matrix item in result)
            {
                item.PrintOnConsole();
                Console.WriteLine();
            }
        }
    }
}
