using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ActionsWithMatrix
{
    public class Matrix
    {
        private int[,] Base { get; set; }

        public int Row { get; private set; }

        public int Col { get; private set; }

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;

            this.Base = new int[this.Row, this.Col];
        }

        public void Add(int value, int row, int col)
        {
            if (row >= this.Row)
            {
                throw new ArgumentException(String.Format("Row is not in the range of the matrix!"));
            }
            if (col >= this.Col)
            {
                throw new ArgumentException(String.Format("Col is not in the range of the matrix!"));
            }

            this.Base[row, col] = value;
        }

        public static Matrix operator +(Matrix matrix, Matrix other)
        {
            if (matrix.Row != other.Row && matrix.Col != other.Col)
            {
                throw new NotImplementedException("You're not allowed to add matrixes of different types!");
            }

            Matrix result = new Matrix(matrix.Row, matrix.Col);

            int value = 0;

            for (int row = 0; row < matrix.Row; row++)
            {
                for (int col = 0; col < matrix.Col; col++)
                {
                    value = matrix[row, col] + other[row, col];
                    result.Add( value,row, col);
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix matrix, Matrix other)
        {
            if (matrix.Row != other.Row && matrix.Col != other.Col)
            {
                throw new NotImplementedException("You're not allowed to add matrixes of different types!");
            }

            Matrix result = new Matrix(matrix.Row, matrix.Col);

            int value = 0;

            for (int row = 0; row < matrix.Row; row++)
            {
                for (int col = 0; col < matrix.Col; col++)
                {
                    value = matrix[row, col] - other[row, col];
                    result.Add(value, row, col);
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix matrix, Matrix other)
        {
            // TODO:
            return null;
        }

        public int this[int row, int col]
        {
            get
            {
                return this.Base[row, col];
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.Row; row++)
            {
                result.Append("|");
                for (int col = 0; col < this.Col; col++)
                {
                    result.Append(this.Base[row, col] + " ");
                }
                result.AppendLine("|");
            }

            return result.ToString();
        }
    }
}
