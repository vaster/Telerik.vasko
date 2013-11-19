using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SumOfSubsetInMatrix
{
    public class Program
    {
        /*Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.*/

        public const int N = 6;

        public const int M = 8;

        public static void FillMatrix(int[,] matrix)
        {
            Random randomGenerator = new Random();
            // numbers in the matrix are from 0 - 30
            const int UP = 30;
            const int DOWN = 0;

            int value = 0;

            for (int row = 0; row < Program.N; row++)
            {
                for (int col = 0; col < Program.M; col++)
                {
                    value = randomGenerator.Next(DOWN, UP);
                    matrix[row, col] = value;
                }
            }
        }

        public static void PrintMatrix(int[,] matrix, bool[,] bestSqure)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (bestSqure[i, j])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write("{0,4}", matrix[i, j]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }

        public static void FindBiggestSumBySquareOfThree(int[,] matrix, int startRow, int startCol,ref int bestSum, bool[,] bestSquare)
        {
            StringBuilder sumator = new StringBuilder();
            int currSum = 0;

            bool[,] currSqure = new bool[Program.N, Program.M];

            for (int row = startRow; row < 3 + startRow; row++)
            {
                for (int col = startCol; col < 3 + startCol; col++)
                {
                    currSqure[row, col] = true;
                    currSum = currSum + matrix[row,col];
                }
            }

            if (currSum > bestSum)
            {
                bestSum = currSum;
                Array.Copy(currSqure,bestSquare,N*M);
            }

        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[Program.N, Program.M];
            int bestSum = 0;
            bool[,] bestSquare = new bool[Program.N, Program.M];

            Program.FillMatrix(matrix);

            Console.WriteLine("Matrix " + Program.N + " X " + Program.M);
            Console.WriteLine();

            for (int row = 0; row < Program.N - 2; row++)
            {
                for (int col = 0; col < Program.M - 2; col++)
                {
                    Program.FindBiggestSumBySquareOfThree(matrix, row, col,ref bestSum, bestSquare);
                }
            }

            Program.PrintMatrix(matrix,bestSquare);
            Console.WriteLine();
            Console.WriteLine("Best Sum " + bestSum);
        }
    }
}
