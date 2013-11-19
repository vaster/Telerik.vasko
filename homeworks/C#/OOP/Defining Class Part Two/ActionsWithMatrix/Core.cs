using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionsWithMatrix
{
    class Core
    {
        static void Main(string[] args)
        {
            //initialization
            Matrix<int> sampleMatrixOne = new Matrix<int>(2, 2);
            Matrix<int> sampleMatrixTwo = new Matrix<int>(2, 2);

            //testing
            sampleMatrixOne[0, 0] = 1;
            sampleMatrixOne[0, 1] = 1;
            sampleMatrixOne[1, 0] = 1;
            sampleMatrixOne[1, 1] = 1;

            sampleMatrixTwo[0, 0] = 1;
            sampleMatrixTwo[0, 1] = 1;
            sampleMatrixTwo[1, 0] = 1;
            sampleMatrixTwo[1, 1] = 1;



/*____________________________________________________________________________________________*/
            Matrix<int> resultOfAddition = sampleMatrixOne + sampleMatrixTwo;
            Console.WriteLine("Addition");
            for (int row = 0; row < resultOfAddition.Row; row++)
            {
                for (int col = 0; col < resultOfAddition.Col; col++)
                {
                    Console.Write(resultOfAddition[row, col] + " ");
                }
                Console.WriteLine();
            }
/*_____________________________________________________________________________________________*/

            Console.WriteLine("Substraction");
            Matrix<int> resultOfSubstraction = sampleMatrixOne - sampleMatrixTwo;
            for (int row = 0; row < resultOfSubstraction.Row; row++)
            {
                for (int col = 0; col < resultOfSubstraction.Col; col++)
                {
                    Console.Write(resultOfSubstraction[row, col] + " ");
                }
                Console.WriteLine();
            }




/*______________________________________________________________________________________________________________________*/

     
            //multiple
            sampleMatrixOne = new Matrix<int>(3, 2);
            sampleMatrixTwo = new Matrix<int>(2, 2);
             
            sampleMatrixOne[0, 0] = 1;
            sampleMatrixOne[0, 1] = 3;
            sampleMatrixOne[1, 0] = 0;
            sampleMatrixOne[1, 1] = -2;
            sampleMatrixOne[2, 0] = 4;
            sampleMatrixOne[2, 1] = 1;

            sampleMatrixTwo[0, 0] = 7;
            sampleMatrixTwo[0, 1] = 9;
            sampleMatrixTwo[1, 0] = 5;
            sampleMatrixTwo[1, 1] = 2;


            Matrix<int> result = sampleMatrixOne * sampleMatrixTwo;
            Console.WriteLine("Multiple");
            for (int row = 0; row < result.Row; row++)
            {
                for (int col = 0; col < result.Col; col++)
                {
                    Console.Write(result[row, col] + " ");
                }
                Console.WriteLine();
            }

         

        }
    }
}
