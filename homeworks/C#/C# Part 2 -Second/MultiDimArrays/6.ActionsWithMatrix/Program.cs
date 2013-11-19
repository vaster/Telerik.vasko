using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ActionsWithMatrix
{
    public class Program
    {
        /*
         * Write a class Matrix, to holds a matrix of integers.
         Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().
         */

        static void Main(string[] args)
        {
            const int row = 5;
            const int col = 5;

            int value = 1;

            Matrix sampleMatrix = new Matrix(row,col);

            for (int rows = 0; rows < sampleMatrix.Row; rows++)
            {
                for (int cols = 0; cols < sampleMatrix.Col; cols++)
                {
                    sampleMatrix.Add(value, rows, cols); ;
                }
            }

            Console.WriteLine(sampleMatrix.ToString());
        }
    }
}
