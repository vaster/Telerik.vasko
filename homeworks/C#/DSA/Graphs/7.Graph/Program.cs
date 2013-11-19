using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Graph
{
    public class Program
    {

       
        public static int count = 0;
        public static int MacCount = 0;
        public static int Length = 0;


        public static void Traverser(char[,] matrix, int startRow, int startCol)
        {
            if (startRow >= Length || startRow < 0 || startCol >= Length || startCol < 0)
            {
                return;
            }
            if (matrix[startRow, startCol] == 'e')
            {
                if (count > MacCount)
                {
                    MacCount = count;
                }
                return;
            }


            if (matrix[startRow, startCol] != '-')
            {
                return;
            }

           
            matrix[startRow, startCol] = 's';
            count++;

            Traverser(matrix, startRow + 2, startCol + 1);
            Traverser(matrix, startRow + 2, startCol - 1);
            Traverser(matrix, startRow - 2, startCol + 1);
            Traverser(matrix, startRow - 2, startCol - 1);
            Traverser(matrix, startRow - 1, startCol + 2);
            Traverser(matrix, startRow + 1, startCol + 2);
            Traverser(matrix, startRow + 1, startCol - 2);
            Traverser(matrix, startRow - 1, startCol - 2);
            count--;

            matrix[startRow, startCol] = '-';


        }


        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Length = n;

            int startRow = 0;
            int startCol = 0;
            int coeff = 0;

            char[,] field = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                coeff = 0;
                string colInfo = Console.ReadLine();

                for (int col = 0; col < colInfo.Length; col++)
                {
                    if (colInfo[col] == 's')
                    {
                        startRow = row;
                        startCol = col - coeff;
                    }
                    if (colInfo[col] != ' ')
                    {
                        field[row, col - coeff] = (colInfo[col]);
                    }
                    else
                    {
                        coeff++;
                    }
                }
            }

            field[startRow, startCol] = '-';

            Traverser(field, startRow, startCol);

            if (MacCount != 0)
            {
                Console.WriteLine(MacCount);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
