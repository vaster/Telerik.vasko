using System;
using System.Text.RegularExpressions;
class DancingBits
{
    static void Main()
    {
        int countZero = 0;
        int countOne = 0;
        //int b = 0;
        // int a=0;
        int k;
        int n;
        // int i = 0;
        int bin;
        // int lenght = 0;
        //int lenghtCounter = 0;
        int cicleCounter = 0;
        string zero = null;
        string one = null;

        // int countCouples = 0;

        //int check = 0;

        do
        {
            k = int.Parse(Console.ReadLine());
        } while (k < 1 || k > 25600);
        for (int j = 1; j <= k; j++)
        {
            zero = "0" + zero;
            one = "1" + one;
        }
        //Console.WriteLine("{0}",one);
        do
        {
            n = int.Parse(Console.ReadLine());
        } while (n < 1 || n > 800);
        string binarryArray = null;
        cicleCounter = n;
        do
        {
            do
            {
            n = int.Parse(Console.ReadLine());
            }while(n<1);
         
            bin = n;
            //lenght = n;
            // if (check > 0)
            //lenghtCounter = lenghtCounter + 1;

            /* do
             {
                 lenght = lenght / 2;
                 lenghtCounter++;
                 if (n == 1)
                 {
                    lenght = 1;
                   
                        lenghtCounter = lenghtCounter-1;
                    
                 }
             } while (lenght != 1);*/

            do
            {

                //Console.WriteLine("{0}",lenghtCounter);
                bin = n % 2;
                binarryArray = Convert.ToString(bin) + binarryArray;

                n = n / 2;
            } while (n != 0);
            cicleCounter--;
            //check++;
        } while (cicleCounter > 0);
        //Console.WriteLine("{0}", binarryArray);
        // for (int j = 0; j < binarryArray.Length; j=j+3)

        {


            countZero = Regex.Matches(binarryArray, zero).Count;
            countOne = Regex.Matches(binarryArray, one).Count;

        }

        Console.WriteLine("{0}", countZero + countOne);
    }
}

