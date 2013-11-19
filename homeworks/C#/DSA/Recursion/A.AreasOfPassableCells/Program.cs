using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.AreasOfPassableCells
{
    /*
     * We are given a matrix of passable and non-passable cells.
     * Write a recursive program for finding all areas of passable cells in the matrix
     */
    public class Program
    {
        public static int currCellCount = 0;
        public static int maxCellCount = 0;

        public static void FindAllAreaOfEmptyCells(Matrix matrix, int startRow, int startCol, bool[,] passedCells)
        {
            if (startCol < 0 || startRow < 0 || startCol >= Matrix.SIZE || startRow >= Matrix.SIZE)
            {
                return;
            }

            if (matrix[startRow, startCol] != Matrix.EMPTY_CELL_SYMBOL)
            {
                return;
            }

            matrix[startRow, startCol] = Matrix.PASSED_CELL_SYMBOL;
            passedCells[startRow, startCol] = true;
            Program.currCellCount++;

            Console.Clear();
            matrix.PrintOnConsole();
            System.Threading.Thread.Sleep(150);

            Program.FindAllAreaOfEmptyCells(matrix, startRow + 1, startCol, passedCells);
            Program.FindAllAreaOfEmptyCells(matrix, startRow - 1, startCol, passedCells);
            Program.FindAllAreaOfEmptyCells(matrix, startRow, startCol + 1, passedCells);
            Program.FindAllAreaOfEmptyCells(matrix, startRow, startCol - 1, passedCells);
        }

        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();

            matrix.Initialize();
            bool[,] passedCells = new bool[Matrix.SIZE, Matrix.SIZE];
            List<Matrix> result = new List<Matrix>();
            for (int row = 0; row < Matrix.SIZE; row++)
            {
                for (int col = 0; col < Matrix.SIZE; col++)
                {
                    if (!passedCells[row, col] && matrix[row, col] != Matrix.OBSTACLE_SYMBOL)
                    {
                        Console.WriteLine(1);
                        Program.currCellCount = 0;
                        Program.FindAllAreaOfEmptyCells(matrix, row, col, passedCells);
                        Matrix currMatrix = new Matrix();
                        Matrix.Copy(matrix,currMatrix);
                        result.Add(currMatrix);
                        matrix.Reset();
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Possible areas:");

            foreach (Matrix currMatrix in result)
            {
                Console.WriteLine();
                currMatrix.PrintOnConsole();
            }
        }
    }
}
