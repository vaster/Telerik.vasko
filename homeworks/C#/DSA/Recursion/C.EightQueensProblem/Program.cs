using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C.EightQueensProblem
{
    public class Program
    {
        public static int queensCount = 0;

        public static GameBoard result = new GameBoard();

        public static void FillCells(bool[,] notAllowedCells, int rowQueenIndex, int colQueenIndex)
        {
            // vertically
            for (int row = 0; row < GameBoard.SIZE; row++)
            {
                notAllowedCells[row, colQueenIndex] = true;
            }

            // horizontally
            for (int col = 0; col < GameBoard.SIZE; col++)
            {
                notAllowedCells[rowQueenIndex, col] = true;
            }
            // diagonally down right
            if (rowQueenIndex > colQueenIndex)
            {
                for (int col = 0; col < GameBoard.SIZE - rowQueenIndex; col++)
                {
                    notAllowedCells[rowQueenIndex + col, colQueenIndex + col] = true;
                }
            }
            if (colQueenIndex > rowQueenIndex)
            {
                for (int col = 0; col < GameBoard.SIZE - colQueenIndex; col++)
                {
                    notAllowedCells[rowQueenIndex + col, colQueenIndex + col] = true;
                }
            }

            // diagonally up right 
            if (rowQueenIndex > colQueenIndex)
            {
                for (int col = 0; col < rowQueenIndex + 1 - colQueenIndex; col++)
                {
                    notAllowedCells[rowQueenIndex - col, colQueenIndex + col] = true;
                }
            }
            if (colQueenIndex > rowQueenIndex)
            {
                for (int col = 0; col < rowQueenIndex + 1 - colQueenIndex; col++)
                {
                    notAllowedCells[rowQueenIndex - col, colQueenIndex + col] = true;
                }
            }

            // diagonally down left
            if (rowQueenIndex > colQueenIndex)
            {
                for (int col = 0; col < colQueenIndex; col++)
                {
                    notAllowedCells[rowQueenIndex + col, colQueenIndex - col] = true;
                }
            }
            if (colQueenIndex > rowQueenIndex)
            {
                for (int col = 0; col < colQueenIndex; col++)
                {
                    notAllowedCells[rowQueenIndex + col, colQueenIndex - col] = true;
                }
            }


            // equals
            if (rowQueenIndex == colQueenIndex)
            {
                for (int diagonallyIndex = rowQueenIndex; diagonallyIndex < GameBoard.SIZE; diagonallyIndex++)
                {
                    notAllowedCells[diagonallyIndex, diagonallyIndex] = true;
                }

            }
        }

        public static void UnFill(bool[,] notAllowedCells, int rowQueenIndex, int colQueenIndex)
        {

            // vertically
            for (int row = 0; row < GameBoard.SIZE; row++)
            {
                notAllowedCells[row, colQueenIndex] = false;
            }

            // horizontally
            for (int col = 0; col < GameBoard.SIZE; col++)
            {
                notAllowedCells[rowQueenIndex, col] = false;
            }
            // diagonally down right
            if (rowQueenIndex > colQueenIndex)
            {
                for (int col = 0; col < GameBoard.SIZE - rowQueenIndex; col++)
                {
                    notAllowedCells[rowQueenIndex + col, colQueenIndex + col] = false;
                }
            }
            if (colQueenIndex > rowQueenIndex)
            {
                for (int col = 0; col < GameBoard.SIZE - colQueenIndex; col++)
                {
                    notAllowedCells[rowQueenIndex + col, colQueenIndex + col] = false;
                }
            }

            // diagonally up right 
            if (rowQueenIndex > colQueenIndex)
            {
                for (int col = 0; col < rowQueenIndex + 1 - colQueenIndex; col++)
                {
                    notAllowedCells[rowQueenIndex - col, colQueenIndex + col] = false;
                }
            }
            if (colQueenIndex > rowQueenIndex)
            {
                for (int col = 0; col < rowQueenIndex + 1 - colQueenIndex; col++)
                {
                    notAllowedCells[rowQueenIndex - col, colQueenIndex + col] = false;
                }
            }

            // diagonally down left
            if (rowQueenIndex > colQueenIndex)
            {
                for (int col = 0; col < colQueenIndex; col++)
                {
                    notAllowedCells[rowQueenIndex + col, colQueenIndex - col] = false;
                }
            }
            if (colQueenIndex > rowQueenIndex)
            {
                for (int col = 0; col < colQueenIndex; col++)
                {
                    notAllowedCells[rowQueenIndex + col, colQueenIndex - col] = false;
                }
            }


            // equals
            if (rowQueenIndex == colQueenIndex)
            {
                for (int diagonallyIndex = rowQueenIndex; diagonallyIndex < GameBoard.SIZE; diagonallyIndex++)
                {
                    notAllowedCells[diagonallyIndex, diagonallyIndex] = false;
                }

            }
        }

        public static void EightQueensProblemSolver(GameBoard gameBoard, int rowQueenIndex, int colQueenIndex, bool[,] notAllowedCells)
        {
            if (rowQueenIndex >= GameBoard.SIZE || rowQueenIndex < 0 || colQueenIndex >= GameBoard.SIZE || colQueenIndex < 0)
            {
                return;
            }

            if (notAllowedCells[rowQueenIndex, colQueenIndex])
            {
                //Program.UnFill(notAllowedCells, rowQueenIndex, colQueenIndex);
                //gameBoard[rowQueenIndex, colQueenIndex] = GameBoard.FREE_CELL_SYMBOL;
                return;
            }
            if (Program.queensCount == 8)
            {
                return;
            }

           


            Console.Clear();
            gameBoard.PrintOnConsole();
            

            Program.queensCount++;
            for (int row = 0; row < notAllowedCells.GetLongLength(0); row++)
            {
                for (int col = 0; col < notAllowedCells.GetLongLength(1); col++)
                {
                    Console.Write(notAllowedCells[row, col] + " ");
                }
                Console.WriteLine();
            }
            Thread.Sleep(2000);

            for (int row = 0; row < GameBoard.SIZE; row++)
            {
                gameBoard[rowQueenIndex, colQueenIndex] = GameBoard.QUEEN_SYMBOL;
                Program.FillCells(notAllowedCells, row, colQueenIndex);
                Program.EightQueensProblemSolver(gameBoard, row, colQueenIndex + 1, notAllowedCells);
                gameBoard[row, colQueenIndex] = GameBoard.FREE_CELL_SYMBOL;
                Program.UnFill(notAllowedCells, row, colQueenIndex);
                Program.queensCount--;
            }



        }

        static void Main(string[] args)
        {

            // Wrong implementation. Not Working!



            //GameBoard gameBoard = new GameBoard();
            //gameBoard.Initialize();

            //bool[,] notAllowedCells = new bool[GameBoard.SIZE, GameBoard.SIZE];

            //Program.EightQueensProblemSolver(gameBoard, 0, 0, notAllowedCells);
            //result.PrintOnConsole();
        }
    }
}
