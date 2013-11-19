using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public static class Renderer
    {
        // This class has method 'Render' used to render the current state of the game on the console
        // depending on what we passed as parameter.
        public static void Render(char[,] board)
        {
            int boardRow = board.GetLength(0);
            int boardCol = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < boardRow; row++)
            {
                Console.Write("{0} | ", row);
                for (int col = 0; col < boardCol; col++)
                {
                    if (board[row, col] == '*')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    if (board[row, col] >= '0' && board[row, col] < '9')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    Console.Write(string.Format("{0} ", board[row, col]));
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }
    }
}
