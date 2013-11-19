using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    // GameFieldCover, GameFieldContent are now part of the game egine, so they are not initialized every time for each method.
    // Now all method use them.
    // Implemented method 'smetki' into 'RewiewCellValue' to show where all numbers are positioned on the game field.
    // Repeated code reduced.
    public class Engine
    {
        public const int BOARD_ROWS = 5;
        public const int BOARD_COLS = 10;

        private char[,] GameFieldCover { get; set; }

        private char[,] GameFieldContent { get; set; }

        public Engine()
        {
            this.GameFieldCover = new char[BOARD_ROWS, BOARD_COLS];
            this.GameFieldContent = new char[BOARD_ROWS, BOARD_COLS];
        }

        public void MakeMove(char[,] gameFieldCover, char[,] gameFieldContent, int row, int col)
        {
            char cellValue = this.RewiedCellValueGenerator(gameFieldContent, row, col);
            gameFieldContent[row, col] = cellValue;
            gameFieldCover[row, col] = cellValue;
        }

        public void ReviewCellValue()
        {
            for (int row = 0; row < BOARD_ROWS; row++)
            {
                for (int col = 0; col < BOARD_COLS; col++)
                {
                    if (this.GameFieldContent[row, col] != '*')
                    {
                        char cellValue = this.RewiedCellValueGenerator(this.GameFieldContent, row, col);
                        this.GameFieldContent[row, col] = cellValue;
                    }
                }
            }
        }

        public char RewiedCellValueGenerator(char[,] gameField, int row, int col)
        {
            int cellValue = 0;

            if (row - 1 >= 0)
            {
                if (gameField[row - 1, col] == '*')
                {
                    cellValue++;
                }
            }

            if (row + 1 < BOARD_ROWS)
            {
                if (gameField[row + 1, col] == '*')
                {
                    cellValue++;
                }
            }

            if (col - 1 >= 0)
            {
                if (gameField[row, col - 1] == '*')
                {
                    cellValue++;
                }
            }

            if (col + 1 < BOARD_COLS)
            {
                if (gameField[row, col + 1] == '*')
                {
                    cellValue++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (gameField[row - 1, col - 1] == '*')
                {
                    cellValue++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < BOARD_COLS))
            {
                if (gameField[row - 1, col + 1] == '*')
                {
                    cellValue++;
                }
            }

            if ((row + 1 < BOARD_ROWS) && (col - 1 >= 0))
            {
                if (gameField[row + 1, col - 1] == '*')
                {
                    cellValue++;
                }
            }

            if ((row + 1 < BOARD_ROWS) && (col + 1 < BOARD_COLS))
            {
                if (gameField[row + 1, col + 1] == '*')
                {
                    cellValue++;
                }
            }

            return char.Parse(cellValue.ToString());
        }

        public void Intialize()
        {
            this.GameFieldCover = this.InitializeGameFieldCover();
            this.GameFieldContent = this.InitializeFieldCellsContent();
        }

        public void Start()
        {
            const int MAX_MOVES_COUNT = 35;
            int movesCount = 0;
            string command = string.Empty;
            HallOfFame theHallOfFame = new HallOfFame();

            this.Intialize();
            Renderer.Render(this.GameFieldCover);
            UserInputProccesser.PlayIntroduction();

            do
            {
                command = UserInputProccesser.CommandReader();

                switch (command)
                {
                    case "top":
                        theHallOfFame.PrintTopScores();
                        break;

                    case "restart":
                        Console.Clear();
                        this.Intialize();
                        Renderer.Render(this.GameFieldCover);
                        break;

                    case "exit":
                        Console.WriteLine("As you wish.");
                        Console.WriteLine("Bye.");
                        break;

                    case "invalid":
                        Console.WriteLine("InvalidCommand!");
                        break;

                    default:
                        string[] coordinate = command.Split(' ');
                        int row = int.Parse(coordinate[0]);
                        int col = int.Parse(coordinate[1]);

                        if (this.GameFieldContent[row, col] == '*' || MAX_MOVES_COUNT == movesCount)
                        {
                            Console.Clear();
                            this.ReviewCellValue();
                            Renderer.Render(this.GameFieldContent);
                            UserInputProccesser.PlayIntroduction();

                            if (this.GameFieldContent[row, col] == '*')
                            {
                                Console.WriteLine("\nYou hit a bomb. Score " + movesCount);
                            }

                            if (MAX_MOVES_COUNT == movesCount)
                            {
                                Console.WriteLine("\nGood job. You open all cells without hitting a bomb.");
                            }

                            Console.Write("Enter Nickname: ");
                            string nickName = Console.ReadLine();

                            theHallOfFame.AddScore(new Result(nickName, movesCount));
                            movesCount = 0;
                        }

                        if (this.GameFieldContent[row, col] == '-' || this.GameFieldContent[row, col] >= '0' && this.GameFieldContent[row, col] <= '9')
                        {
                            this.MakeMove(this.GameFieldCover, this.GameFieldContent, row, col);
                            movesCount++;
                            Console.Clear();
                            Renderer.Render(this.GameFieldCover);
                        }

                        break;
                }
            }
            while (command != "exit");
        }

        private char[,] InitializeGameFieldCover()
        {
            for (int row = 0; row < BOARD_ROWS; row++)
            {
                for (int col = 0; col < BOARD_COLS; col++)
                {
                    this.GameFieldCover[row, col] = '?';
                }
            }

            return this.GameFieldCover;
        }

        private char[,] InitializeFieldCellsContent()
        {
            for (int row = 0; row < BOARD_ROWS; row++)
            {
                for (int col = 0; col < BOARD_COLS; col++)
                {
                    this.GameFieldContent[row, col] = '-';
                }
            }

            List<int> bombHolder = new List<int>();

            while (bombHolder.Count < 15)
            {
                Random random = new Random();
                int bombCoordinateContainer = random.Next(50);

                if (!bombHolder.Contains(bombCoordinateContainer))
                {
                    bombHolder.Add(bombCoordinateContainer);
                }
            }

            foreach (int coordinateBox in bombHolder)
            {
                int col = (coordinateBox / BOARD_COLS);
                int row = (coordinateBox % BOARD_COLS);

                if (row == 0 && coordinateBox != 0)
                {
                    col--;
                    row = BOARD_COLS;
                }
                else
                {
                    row++;
                }

                this.GameFieldContent[col, row - 1] = '*';
            }

            return this.GameFieldContent;
        }
    }
}
