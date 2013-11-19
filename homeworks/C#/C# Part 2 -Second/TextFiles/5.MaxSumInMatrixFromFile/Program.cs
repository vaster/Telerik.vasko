using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _5.MaxSumInMatrixFromFile
{
    public class Program
    {
        /*
         Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
         The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space.
         The output should be a single number in a separate text file. Example:
         */

        public static int[,] CreateMatrix(string path)
        {
            int[,] matrix = null;

            StreamReader reader = new StreamReader(path);

            string matrixSize = null;

            int matrixLength = 0;

            string line = null;

            string[] numbers = null;

            int row = 0;

            using (reader)
            {
                matrixSize = reader.ReadLine();
                matrixLength = int.Parse(matrixSize);

                matrix = new int[matrixLength, matrixLength];

                do
                {
                    line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    numbers = line.Split(new char[] { ' ' });

                    for (int currCol = 0; currCol < numbers.Length; currCol++)
                    {
                        matrix[row, currCol] = int.Parse(numbers[currCol]);
                    }
                    row++;

                } while (line != null);
            }

            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void FindBiggestSumBySquareOfTwo(int[,] matrix, int startRow, int startCol, ref int bestSum, bool[,] bestSquare)
        {
            StringBuilder sumator = new StringBuilder();
            int currSum = 0;

            bool[,] currSqure = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            for (int row = startRow; row < 2 + startRow; row++)
            {
                for (int col = startCol; col < 2 + startCol; col++)
                {
                    currSqure[row, col] = true;
                    currSum = currSum + matrix[row, col];
                }
            }

            if (currSum > bestSum)
            {
                bestSum = currSum;
                Array.Copy(currSqure, bestSquare, matrix.GetLength(0) * matrix.GetLength(1));
            }

        }

        static void Main(string[] args)
        {
            string path = @"../../text/matrix-info.txt";
            
            int[,] matrix = Program.CreateMatrix(path);

            Program.PrintMatrix(matrix);
            
            bool[,] bestSquare = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            int bestSum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    Program.FindBiggestSumBySquareOfTwo(matrix, row, col, ref bestSum, bestSquare);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Best Sum " + bestSum);

            string resultPath = @"../../text/matrix-best-sum.txt";

            StreamWriter writer = new StreamWriter(resultPath);

            using(writer)
            {
                writer.WriteLine(bestSum);
            }
        }
    }
}
