using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.EightQueensProblem
{
    public class GameBoard
    {
        public const int SIZE = 8;

        public const char FREE_CELL_SYMBOL = '*';

        public const char QUEEN_SYMBOL = 'Q';

        private char[,] Base { get; set; }

        public GameBoard()
        {
            this.Base = new char[GameBoard.SIZE, GameBoard.SIZE];
        }

        public void Initialize()
        {
            for (int row = 0; row < GameBoard.SIZE; row++)
            {
                for (int col = 0; col < GameBoard.SIZE; col++)
                {
                    this.Base[row, col] = GameBoard.FREE_CELL_SYMBOL;
                }
            }
        }

        public void PrintOnConsole()
        {
            for (int row = 0; row < GameBoard.SIZE; row++)
            {
                for (int col = 0; col < GameBoard.SIZE; col++)
                {
                    Console.Write(this.Base[row, col] + " ");
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
