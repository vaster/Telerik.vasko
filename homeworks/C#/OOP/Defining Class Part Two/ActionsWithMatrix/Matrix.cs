using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionsWithMatrix
{
    public class Matrix<T>
        where T:struct
        
        
    {
        private T[,] matrix;
        private int row;
        private int col;

        //properties
        public int Row
        {
            get
            {
                return this.row;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }
        }
        
        //constructor
        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.matrix = new T[this.row,this.col];
        }
        //indexer
        public T this[int row, int col]
        {
            set
            {
                if (row > this.row)
                {
                    throw new IndexOutOfRangeException("No such row!");
                }
                if (col > this.col)
                {
                    throw new IndexOutOfRangeException("No such col!");
                }
                matrix[row, col] = value;
            }
            get
            {
                if (row > this.row)
                {
                    throw new IndexOutOfRangeException("No such row!");
                }
                if (col > this.col)
                {
                    throw new IndexOutOfRangeException("No such col!");
                }
                return matrix[row,col];
            }
        }

        //
        public override string ToString()
        {
            return string.Format("Matrix[{0},{1}] = {2}",this.row,this.col,matrix[this.row,this.col]);
        }


        //operators
        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            Matrix<T> resultOfAdd = new Matrix<T>(matrixOne.row,matrixTwo.col);

            if (resultOfAdd.row != resultOfAdd.col)
            {
                throw new Exception("Matrixes of differents cols or different rows can't be added.");
            }

            for (int row = 0; row < matrixOne.row; row++)
            {
                for (int col = 0; col < matrixTwo.col; col++)
                {
                    var sumOne = matrixOne[row,col];
                    var sumTwo = matrixTwo[row, col];
                    resultOfAdd[row, col] = (dynamic)sumOne + (dynamic)sumTwo;//One way is that by woring in run - time.
                }                                                              //Second is try to Convert the values of the matrixes in the type we are going to use for T again run - time with 'GetTypeOf'(not sure for this)

                
            }

            return resultOfAdd;
        }

        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            Matrix<T> resultOfSub = new Matrix<T>(matrixOne.row, matrixTwo.col);

            if (resultOfSub.row != resultOfSub.col)
            {
                throw new Exception("Matrixes of differents cols or different rows can't be substracted.");
            }

            for (int row = 0; row < matrixOne.row; row++)
            {
                for (int col = 0; col < matrixTwo.col; col++)
                {
                    var sumOne = matrixOne[row, col];
                    var sumTwo = matrixTwo[row, col];
                    resultOfSub[row, col] = (dynamic)sumOne - (dynamic)sumTwo; //One way is that by woring in run - time.
                }                                                              //Second is try to Convert the values of the matrixes in the type we are going to use for T again run - time with 'GetTypeOf'(not sure for this)

            }

            return resultOfSub;
        }


        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            Matrix<T> resultOfMult = new Matrix<T>(matrixOne.row, matrixTwo.col);
            var sumOne = 0;
            if (matrixOne.col != matrixTwo.row)
            {
                throw new Exception("Error, this statemant is not true: Rows of second matrix must equals Cols of first matrix.");
            }
            for (int seconMatrixCol = 0; seconMatrixCol < matrixTwo.col; seconMatrixCol++)
            {
                //for (int secondMatricRow = 0; secondMatricRow < matrixTwo.row; secondMatricRow++)
                {

                    for (int firstMatrixRow = 0; firstMatrixRow < matrixOne.row; firstMatrixRow++)
                    {
                        for (int firstMatrixCol = 0, secondMatricRow = 0; firstMatrixCol < matrixOne.col; firstMatrixCol++, secondMatricRow++)
                        {

                            sumOne = (dynamic)matrixOne[firstMatrixRow, firstMatrixCol] * (dynamic)matrixTwo[secondMatricRow,seconMatrixCol] + sumOne;

                            
                        }
                        resultOfMult[firstMatrixRow, seconMatrixCol] = (dynamic)sumOne;
                        sumOne = 0;

                    }
                }
            }


            return resultOfMult;

        }


        /*static public bool operator true(Matrix<T> matrix)
        {
           
                return matrix >= (dynamic)0;
        }

        static public bool operator false(Matrix<T> matrix)
        {

            return matrix <  (dynamic)0;

        }*/
    }
}
