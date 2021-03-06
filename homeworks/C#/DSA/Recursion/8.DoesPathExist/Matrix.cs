﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.DoesPathExist
{
    public class Matrix
    {
        public const int MATRIX_SIZE = 100;

        public int FinaleRow;

        public int FinaleCol;

        public const char EMPTY_CELL_SYMBOL = '0';

        public const char OBSTACLE_SYMBOL = '*';

        public const char FINALE_SYMBOL = 'F';

        public const char PASSED_CELL_SYMBOL = '1';

        public char[,] Base { get; set; }

        public Matrix()
        {
            this.Base = new char[Matrix.MATRIX_SIZE, Matrix.MATRIX_SIZE];
            this.FinaleRow = 0;
            this.FinaleCol = 0;
        }


        public void Initialize()
        {
            Random randomGenerator = new Random();
           

            this.Base[this.FinaleRow, this.FinaleCol] = Matrix.FINALE_SYMBOL;

            for (int row = 0; row < Matrix.MATRIX_SIZE; row++)
            {
                for (int col = 0; col < Matrix.MATRIX_SIZE; col++)
                {
                    if (this.Base[row, col] == '\0')
                    {
                        this.Base[row, col] = Matrix.EMPTY_CELL_SYMBOL;
                    }
                }
            }
        }

        public void PrintOnConsole()
        {

            for (int row = 0; row < Matrix.MATRIX_SIZE; row++)
            {
                for (int col = 0; col < Matrix.MATRIX_SIZE; col++)
                {
                    if (this.Base[row, col] == Matrix.PASSED_CELL_SYMBOL)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    Console.Write(this.Base[row, col] + "|");

                    if (this.Base[row, col] == Matrix.FINALE_SYMBOL)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }

        public char this[int row, int col]
        {
            get
            {
                return this.Base[row, col];
            }
            set
            {
                this.Base[row, col] = value;
            }
        }
    }
}
