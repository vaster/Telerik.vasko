using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LongestSequence
{
    public class Program
    {
        /*
         * We are given a matrix of strings of size N x M. 
         * Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
         * Write a program that finds the longest sequence of equal strings in the matrix.
         */

        public const int ROW = 10;
        public const int COL = 7;

        public static void FillMatrix(int[,] matrix)
        {
            Random randomGenerator = new Random();
            // numbers in the matrix are from 0 - 4
            const int UP = 4;
            const int DOWN = 0;

            int value = 0;

            for (int row = 0; row < Program.ROW; row++)
            {
                for (int col = 0; col < Program.COL; col++)
                {
                    value = randomGenerator.Next(DOWN, UP);
                    matrix[row, col] = value;
                }
            }
        }

        public static void PrintMatrix(int[,] matrix, bool[,] bestSqure)
        {
            for (int i = 0; i < Program.ROW; i++)
            {
                for (int j = 0; j < Program.COL; j++)
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

        public static void InterateByRow(int[,] matrix, int startRow, ref int bestRowLength, bool[,] bestRow)
        {
            int currSequenceLenght = 0;
            int currBestSequenceLength = 0;
            bool[,] currSquare = new bool[Program.ROW, Program.COL];
            bool[,] currBestSquare = new bool[Program.ROW, Program.COL];

            for (int col = 0; col < Program.COL - 1; col++)
            {
                if (matrix[startRow, col] == matrix[startRow, col + 1])
                {
                    currSquare[startRow, col] = true;
                    currSquare[startRow, col + 1] = true;
                    currSequenceLenght++;
                }
                else
                {
                    if (currSequenceLenght > currBestSequenceLength)
                    {
                        currBestSequenceLength = currSequenceLenght;
                        Array.Copy(currSquare, currBestSquare, Program.ROW * Program.COL);
                    }
                    currSequenceLenght = 0;
                    currSquare = new bool[Program.ROW, Program.COL];
                }
            }

            if (currBestSequenceLength > bestRowLength)
            {
                bestRowLength = currBestSequenceLength;
                Array.Copy(currBestSquare, bestRow, Program.ROW * Program.COL);
            }
        }

        public static void InterateByCol(int[,] matrix, int startCol, ref int bestColLength, bool[,] bestCol)
        {
            int currSequenceLenght = 0;
            int currBestSequenceLength = 0;
            bool[,] currSquare = new bool[Program.ROW, Program.COL];
            bool[,] currBestSquare = new bool[Program.ROW, Program.COL];

            for (int row = 0; row < Program.ROW - 1; row++)
            {
                if (matrix[row, startCol] == matrix[row + 1, startCol])
                {
                    currSquare[row, startCol] = true;
                    currSquare[row + 1, startCol] = true;
                    currSequenceLenght++;
                }
                else
                {
                    if (currSequenceLenght > currBestSequenceLength)
                    {
                        currBestSequenceLength = currSequenceLenght;
                        Array.Copy(currSquare, currBestSquare, Program.ROW * Program.COL);
                    }
                    currSequenceLenght = 0;
                    currSquare = new bool[Program.ROW, Program.COL];
                }
            }

            if (currBestSequenceLength > bestColLength)
            {
                bestColLength = currBestSequenceLength;
                Array.Copy(currBestSquare, bestCol, Program.ROW * Program.COL);
            }
        }

        public static void InterateByDiagonalLeftToRight(int[,] matrix, int startCol, int startRow, ref int bestDiagonalLength, bool[,] bestDiagonal)
        {
            int currSequenceLenght = 0;
            int currBestSequenceLength = 0;
            bool[,] currSquare = new bool[Program.ROW, Program.COL];
            bool[,] currBestSquare = new bool[Program.ROW, Program.COL];

            int row = startRow;
            int col = startCol;

            do
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    currSquare[row, col] = true;
                    currSquare[row + 1, col + 1] = true;
                    currSequenceLenght++;
                }
                else
                {
                    if (currSequenceLenght > currBestSequenceLength)
                    {
                        currBestSequenceLength = currSequenceLenght;
                        Array.Copy(currSquare, currBestSquare, Program.ROW * Program.COL);
                    }
                    currSequenceLenght = 0;
                    currSquare = new bool[Program.ROW, Program.COL];
                }


                if (currBestSequenceLength > bestDiagonalLength)
                {
                    bestDiagonalLength = currBestSequenceLength;
                    Array.Copy(currBestSquare, bestDiagonal, Program.ROW * Program.COL);
                }

                row++;
                col++;

                if (row > Program.ROW - 2)
                {
                    break;
                }
                if (col > Program.COL - 2)
                {
                    break;
                }
            } while (true);
        }

        public static void InterateByDiagonalRightToLeft(int[,] matrix, int startCol, int startRow, ref int bestDiagonalLength, bool[,] bestDiagonal)
        {
            int currSequenceLenght = 0;
            int currBestSequenceLength = 0;
            bool[,] currSquare = new bool[Program.ROW, Program.COL];
            bool[,] currBestSquare = new bool[Program.ROW, Program.COL];

            int row = startRow;
            int col = startCol;

            do
            {
                if (matrix[row, col] == matrix[row + 1, col - 1])
                {
                    currSquare[row, col] = true;
                    currSquare[row + 1, col - 1] = true;
                    currSequenceLenght++;
                }
                else
                {
                    if (currSequenceLenght > currBestSequenceLength)
                    {
                        currBestSequenceLength = currSequenceLenght;
                        Array.Copy(currSquare, currBestSquare, Program.ROW * Program.COL);
                    }
                    currSequenceLenght = 0;
                    currSquare = new bool[Program.ROW, Program.COL];
                }


                if (currBestSequenceLength > bestDiagonalLength)
                {
                    bestDiagonalLength = currBestSequenceLength;
                    Array.Copy(currBestSquare, bestDiagonal, Program.ROW * Program.COL);
                }

                row++;
                col--;

                if (row > Program.ROW - 2)
                {
                    break;
                }
                if (col <= 0)
                {
                    break;
                }
            } while (true);
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[Program.ROW, Program.COL];

            bool[,] bestRow = new bool[Program.ROW, Program.COL];
            int bestRowLength = 0;

            bool[,] bestCol = new bool[Program.ROW, Program.COL];
            int bestColLength = 0;

            bool[,] bestDiagonalLeftToRight = new bool[Program.ROW, Program.COL];
            int bestDiagonalLengthLeftToRight = 0;

            bool[,] bestDiagonalRightToLeft = new bool[Program.ROW, Program.COL];
            int bestDiagonalLengthRightToLeft = 0;


            bool[,] bestSequence = new bool[Program.ROW, Program.COL];
            int bestLength = 0;

            Program.FillMatrix(matrix);



            for (int rows = 0; rows < Program.ROW; rows++)
            {
                Program.InterateByRow(matrix, rows, ref bestRowLength, bestRow);
            }

            if (bestRowLength >= bestLength)
            {
                bestSequence = bestRow;
                bestLength = bestRowLength;
            }

            for (int cols = 0; cols < Program.COL; cols++)
            {
                Program.InterateByCol(matrix, cols, ref bestColLength, bestCol);
            }

            if (bestColLength > bestLength)
            {
                bestSequence = bestCol;
                bestLength = bestColLength;
            }

            for (int rows = 0; rows < Program.ROW - 1; rows++)
            {
                for (int cols = 0; cols < Program.COL - 1; cols++)
                {
                    Program.InterateByDiagonalLeftToRight(matrix, cols, rows, ref bestDiagonalLengthLeftToRight, bestDiagonalLeftToRight);
                }

            }

            if (bestDiagonalLengthLeftToRight > bestLength)
            {
                bestSequence = bestDiagonalLeftToRight;
                bestLength = bestDiagonalLengthLeftToRight;
            }

            for (int rows = 0; rows < Program.ROW - 1; rows++)
            {
                for (int cols = Program.COL - 1; cols >0 ; cols--)
                {
                    Program.InterateByDiagonalRightToLeft(matrix, cols, rows, ref bestDiagonalLengthRightToLeft, bestDiagonalRightToLeft);
                }

            }

            if (bestDiagonalLengthRightToLeft > bestLength)
            {
                bestSequence = bestDiagonalRightToLeft;
                bestLength = bestDiagonalLengthRightToLeft;
            }

            Program.PrintMatrix(matrix, bestSequence);
            Console.WriteLine(bestLength + 1);

        }
    }
}
