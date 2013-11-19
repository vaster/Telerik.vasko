using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.DoesPathExist
{

    /*
     Modify the above program to check whether a path exists between two cells without finding all possible paths.
     *Test it over an empty 100 x 100 matrix.     
     */

    public class Program
    {
        public static void FindPath(Matrix matrix, int startRow, int startCol, ref bool doesExist)
        {
            if (startCol < 0 || startRow < 0 || startCol >= Matrix.MATRIX_SIZE || startRow >= Matrix.MATRIX_SIZE)
            {
                return;
            }

            if (matrix[startRow, startCol] == Matrix.FINALE_SYMBOL)
            {
                doesExist = true;
                return;
            }
            else
            {
                if (matrix[startRow, startCol] != Matrix.EMPTY_CELL_SYMBOL)
                {
                    return;
                }

                matrix[startRow, startCol] = Matrix.PASSED_CELL_SYMBOL;
                //Console.Clear();
                //matrix.PrintOnConsole();
                //System.Threading.Thread.Sleep(100);

                // if - if- if- if construction helps preventing of going in diff directions if we have founded the finale,
                // so when we are going back over the recursion stack the other directions won't be called.
                // Using 'ref' guarantee as that 'doesExists' parameter  won't change its value over the diff recursion calls from the stack. 
                // So ones the finale is founded, 'doesExists' will remain 'true' over all calls of the recursion.

                if (!doesExist)
                {
                    Program.FindPath(matrix, startRow + 1, startCol, ref doesExist);
                }
                if (!doesExist)
                {
                    Program.FindPath(matrix, startRow - 1, startCol, ref doesExist);
                }
                if (!doesExist)
                {
                    Program.FindPath(matrix, startRow, startCol + 1, ref doesExist);
                }
                if (!doesExist)
                {
                    Program.FindPath(matrix, startRow, startCol - 1, ref doesExist);
                }
                
                matrix[startRow, startCol] = Matrix.EMPTY_CELL_SYMBOL;
            }

        }

        // start is at {0,0}
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            // Finale 
            matrix.FinaleRow = 36;
            matrix.FinaleCol = 32;

            matrix.Initialize();

            bool doesExist = false;
            Program.FindPath(matrix, 0, 0, ref doesExist);

            Console.WriteLine(doesExist);
        }
    }
}
