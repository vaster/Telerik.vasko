using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.AdjacentEmpyCells
{
    public class Matrix
    {
        public const int SIZE = 7;

        public const char EMPTY_CELL_SYMBOL = '0';

        public const char OBSTACLE_SYMBOL = '*';

        public const char PASSED_CELL_SYMBOL = '1';

        public char[,] Base { get; set; }

        public Matrix()
        {
            this.Base = new char[Matrix.SIZE, Matrix.SIZE];
        }


        public void Initialize()
        {
            Random randomGenerator = new Random();
            int obstacleRowIndex = 0;
            int obstacleColIndex = 0;

            for (int i = 0; i < 20; i++)
            {
                obstacleRowIndex = randomGenerator.Next(0, Matrix.SIZE);
                obstacleColIndex = randomGenerator.Next(0, Matrix.SIZE);

                this.Base[obstacleRowIndex, obstacleColIndex] = Matrix.OBSTACLE_SYMBOL;
            }

            //this.Base[0, 0] = Matrix.EMPTY_CELL_SYMBOL;

            for (int row = 0; row < Matrix.SIZE; row++)
            {
                for (int col = 0; col < Matrix.SIZE; col++)
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
            for (int row = 0; row < Matrix.SIZE; row++)
            {
                for (int col = 0; col < Matrix.SIZE; col++)
                {
                    if (this.Base[row, col] == Matrix.PASSED_CELL_SYMBOL)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    Console.Write(this.Base[row, col] + "|");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }

        public void Reset()
        {
            for (int row = 0; row < Matrix.SIZE; row++)
            {
                for (int col = 0; col < Matrix.SIZE; col++)
                {
                    if (this.Base[row, col] == Matrix.PASSED_CELL_SYMBOL)
                    {
                        this.Base[row, col] = Matrix.EMPTY_CELL_SYMBOL;
                    }
                }
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
