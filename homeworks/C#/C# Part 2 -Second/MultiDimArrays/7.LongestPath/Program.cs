using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LongestPath
{
    public class Program
    {

        public const int ROW = 6;

        public const int COL = 8;

        public static bool[,] bestPath = new bool[Program.ROW, Program.COL];

        public static int bestPathLenght = 0;

        public static void Initilize(int[,] matrix, List<int> uniqeValues)
        {
            Random randomGenerator = new Random();

            int value = 0;

            for (int row = 0; row < Program.ROW; row++)
            {
                for (int col = 0; col < Program.COL; col++)
                {
                    value = randomGenerator.Next(1, 4);

                    if (!uniqeValues.Contains(value))
                    {
                        uniqeValues.Add(value);
                    }

                    matrix[row, col] = value;
                }
            }
        }

        public static void Print(int[,] matrix, int currRow, int currCol, bool[,] passedCell)
        {
            for (int row = 0; row < Program.ROW; row++)
            {
                for (int col = 0; col < Program.COL; col++)
                {
                    if (passedCell[row, col])
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    Console.Write(matrix[row, col] + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }

        public static void Interate(int[,] matrix, bool[,] passedCell, int currElementValue, int currLenght, int row, int col)
        {
            if (row >= Program.ROW || col >= Program.COL || row < 0 || col < 0)
            {
                return;
            }
            if (passedCell[row, col])
            {
                return;
            }


            if (!(matrix[row, col] == currElementValue))
            {
                if (currLenght > bestPathLenght)
                {
                    bestPathLenght = currLenght;
                    Array.Copy(passedCell, bestPath, Program.ROW * Program.COL);
                }
                return;
            }
            else
            {
                currLenght++;
                passedCell[row, col] = true;
            }


            // these are the four allowed directions

            // down
            Program.Interate(matrix, passedCell, currElementValue, currLenght, row + 1, col);
            // right
            Program.Interate(matrix, passedCell, currElementValue, currLenght, row, col + 1);
            // up
            Program.Interate(matrix, passedCell, currElementValue, currLenght, row - 1, col);
            // left
            Program.Interate(matrix, passedCell, currElementValue, currLenght, row, col - 1);
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[Program.ROW, Program.COL];
            bool[,] passedCell = new bool[Program.ROW, Program.COL];


            List<int> uniqeValues = new List<int>();

            Program.Initilize(matrix, uniqeValues);

            foreach (var number in uniqeValues)
            {

                for (int row = 0; row < Program.ROW; row++)
                {
                    for (int col = 0; col < Program.COL; col++)
                    {
                        if (!passedCell[row, col])
                        {
                            passedCell = new bool[Program.ROW, Program.COL];
                            Program.Interate(matrix, passedCell, number,0, row, col);
                            
                        }
                    }
                }
            }

            Program.Print(matrix,0,0,bestPath);
            Console.WriteLine("Lenght: " + bestPathLenght);
        }
    }
}
