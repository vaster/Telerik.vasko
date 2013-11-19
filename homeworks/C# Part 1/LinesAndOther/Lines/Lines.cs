using System;

class Lines
{
    static void Main()
    {
        short[] n0 = new short[8];
        short[] n1 = new short[8];
        short[] n2 = new short[8];
        short[] n3 = new short[8];
        short[] n4 = new short[8];
        short[] n5 = new short[8];
        short[] n6 = new short[8];
        short[] n7 = new short[8];
        ////////////////////////////////////////
        short[] onesInRows = new short[64];
        short[] onesInCols = new short[64];
        short ones = 0;
        short ones2 = 0;
        bool order = true;
        bool order2 = true;
        int countCols = 0;
        int countRows = 0;
        ////////////////////////////////////////
        short[] n0Reverse = new short[8];
        short[] n1Reverse = new short[8];
        short[] n2Reverse = new short[8];
        short[] n3Reverse = new short[8];
        short[] n4Reverse = new short[8];
        short[] n5Reverse = new short[8];
        short[] n6Reverse = new short[8];
        short[] n7Reverse = new short[8];



        int k = 0;
        int d = 0;
        int i = 0;
        int q = 0;
        int p = 0;

        int number0;
        int number1;
        int number2;
        int number3;
        int number4;
        int number5;
        int number6;
        int number7;
        int max = 0;
        int maxRow = 0;
        int maxCol = 0;

        number0 = byte.Parse(Console.ReadLine());
        max = number0;
        number1 = byte.Parse(Console.ReadLine());
        if (max < number1)
        {
            max = number1;
        }
        number2 = byte.Parse(Console.ReadLine());
        if (max < number2)
        {
            max = number2;
        }
        number3 = byte.Parse(Console.ReadLine());
        if (max < number3)
        {
            max = number3;
        }
        number4 = byte.Parse(Console.ReadLine());
        if (max < number4)
        {
            max = number4;
        }
        number5 = byte.Parse(Console.ReadLine());
        if (max < number5)
        {
            max = number5;
        }
        number6 = byte.Parse(Console.ReadLine());
        if (max < number6)
        {
            max = number6;
        }
        number7 = byte.Parse(Console.ReadLine());
        if (max < number7)
        {
            max = number7;
        }


        int toOnes0;
        int toOnes1;
        int toOnes2;
        int toOnes3;
        int toOnes4;
        int toOnes5;
        int toOnes6;
        int toOnes7;

        //toOnes0 = number0;
        do
        {
            toOnes0 = number0 % 2;
            toOnes1 = number1 % 2;
            toOnes2 = number2 % 2;
            toOnes3 = number3 % 2;
            toOnes4 = number4 % 2;
            toOnes5 = number5 % 2;
            toOnes6 = number6 % 2;
            toOnes7 = number7 % 2;
            ////////////////////////////
            n0[i] = (short)toOnes0;
            n0Reverse[d] = n0[i];
            n1[i] = (short)toOnes1;
            n2[i] = (short)toOnes2;
            n3[i] = (short)toOnes3;
            n4[i] = (short)toOnes4;
            n5[i] = (short)toOnes5;
            n6[i] = (short)toOnes6;
            n7[i] = (short)toOnes7;
            ////////////////////////////
            number0 = number0 / 2;
            number1 = number1 / 2;
            number2 = number2 / 2;
            number3 = number3 / 2;
            number4 = number4 / 2;
            number5 = number5 / 2;
            number6 = number6 / 2;
            number7 = number7 / 2;
            max = max / 2;
            /////////////////////////////

            i++;
        } while (max > 0);


       /* for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", n0[j]);

        }
        Console.WriteLine();
        ////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", n1[j]);

        }
        Console.WriteLine();
        //////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", n2[j]);

        }
        Console.WriteLine();
        ////////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", n3[j]);

        }
        Console.WriteLine();
        ///////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", n4[j]);

        }
        Console.WriteLine();
        /////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", n5[j]);

        }
        Console.WriteLine();
        ///////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", n6[j]);

        }
        Console.WriteLine();
        /////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", n7[j]);

        }
        ///////////////////////////
        Console.WriteLine();*/


        n0Reverse[d] = n0[0];
        d++;
        n0Reverse[d] = n1[0];
        d++;
        n0Reverse[d] = n2[0];
        d++;
        n0Reverse[d] = n3[0];
        d++;
        n0Reverse[d] = n4[0];
        d++;
        n0Reverse[d] = n5[0];
        d++;
        n0Reverse[d] = n6[0];
        d++;
        n0Reverse[d] = n7[0];
        ///////////////////////////////
        d = 0;
        n1Reverse[d] = n0[1];
        d++;
        n1Reverse[d] = n1[1];
        d++;
        n1Reverse[d] = n2[1];
        d++;
        n1Reverse[d] = n3[1];
        d++;
        n1Reverse[d] = n4[1];
        d++;
        n1Reverse[d] = n5[1];
        d++;
        n1Reverse[d] = n6[1];
        d++;
        n1Reverse[d] = n7[1];
        ////////////////////////////////
        d = 0;
        n2Reverse[d] = n0[2];
        d++;
        n2Reverse[d] = n1[2];
        d++;
        n2Reverse[d] = n2[2];
        d++;
        n2Reverse[d] = n3[2];
        d++;
        n2Reverse[d] = n4[2];
        d++;
        n2Reverse[d] = n5[2];
        d++;
        n2Reverse[d] = n6[2];
        d++;
        n2Reverse[d] = n7[2];
        //////////////////////////////////
        d = 0;
        n3Reverse[d] = n0[3];
        d++;
        n3Reverse[d] = n1[3];
        d++;
        n3Reverse[d] = n2[3];
        d++;
        n3Reverse[d] = n3[3];
        d++;
        n3Reverse[d] = n4[3];
        d++;
        n3Reverse[d] = n5[3];
        d++;
        n3Reverse[d] = n6[3];
        d++;
        n3Reverse[d] = n7[3];
        /////////////////////////////////
        d = 0;
        n4Reverse[d] = n0[4];
        d++;
        n4Reverse[d] = n1[4];
        d++;
        n4Reverse[d] = n2[4];
        d++;
        n4Reverse[d] = n3[4];
        d++;
        n4Reverse[d] = n4[4];
        d++;
        n4Reverse[d] = n5[4];
        d++;
        n4Reverse[d] = n6[4];
        d++;
        n4Reverse[d] = n7[4];
        /////////////////////////////////////////
        d = 0;
        n5Reverse[d] = n0[5];
        d++;
        n5Reverse[d] = n1[5];
        d++;
        n5Reverse[d] = n2[5];
        d++;
        n5Reverse[d] = n3[5];
        d++;
        n5Reverse[d] = n4[5];
        d++;
        n5Reverse[d] = n5[5];
        d++;
        n5Reverse[d] = n6[5];
        d++;
        n5Reverse[d] = n7[5];
        /////////////////////////////////////////
        d = 0;
        n6Reverse[d] = n0[6];
        d++;
        n6Reverse[d] = n1[6];
        d++;
        n6Reverse[d] = n2[6];
        d++;
        n6Reverse[d] = n3[6];
        d++;
        n6Reverse[d] = n4[6];
        d++;
        n6Reverse[d] = n5[6];
        d++;
        n6Reverse[d] = n6[6];
        d++;
        n6Reverse[d] = n7[6];
        ///////////////////////////////////////
        d = 0;
        n7Reverse[d] = n0[7];
        d++;
        n7Reverse[d] = n1[7];
        d++;
        n7Reverse[d] = n2[7];
        d++;
        n7Reverse[d] = n3[7];
        d++;
        n7Reverse[d] = n4[7];
        d++;
        n7Reverse[d] = n5[7];
        d++;
        n7Reverse[d] = n6[7];
        d++;
        n7Reverse[d] = n7[7];





        ///////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n0[j] == 1)
            {
                ones++;
                onesInRows[q] = ones;
                order = true;
            }
            if (n0[j] == 0 && order)
            {
                ones = 0;
                q++;
                order = false;
            }
        }
        ones = 0;
        q++;
        ///////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n1[j] == 1)
            {
                ones++;
                onesInRows[q] = ones;
                order = true;
            }
            if (n1[j] == 0 && order)
            {
                ones = 0;
                q++;
                order = false;
            }
        }
        ones = 0;
        q++;
        /////////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n2[j] == 1)
            {
                ones++;
                onesInRows[q] = ones;
                order = true;
            }
            if (n2[j] == 0 && order)
            {
                ones = 0;
                q++;
                order = false;
            }
        }
        ones = 0;
        q++;
        /////////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n3[j] == 1)
            {
                ones++;
                onesInRows[q] = ones;
                order = true;
            }
            if (n3[j] == 0 && order)
            {
                ones = 0;
                q++;
                order = false;
            }
        }
        ones = 0;
        q++;
        //////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n4[j] == 1)
            {
                ones++;
                onesInRows[q] = ones;
                order = true;
            }
            if (n4[j] == 0 && order)
            {
                ones = 0;
                q++;
                order = false;
            }
        }
        ones = 0;
        q++;
        /////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n5[j] == 1)
            {
                ones++;
                onesInRows[q] = ones;
                order = true;
            }
            if (n5[j] == 0 && order)
            {
                ones = 0;
                q++;
                order = false;
            }
        }
        ones = 0;
        q++;
        /////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n6[j] == 1)
            {
                ones++;
                onesInRows[q] = ones;
                order = true;
            }
            if (n6[j] == 0 && order)
            {
                ones = 0;
                q++;
                order = false;
            }
        }
        ones = 0;
        q++;
        ////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n7[j] == 1)
            {
                ones++;
                onesInRows[q] = ones;
                order = true;
            }
            if (n7[j] == 0 && order)
            {
                ones = 0;
                q++;
                order = false;
            }
        }

        ////////////////////////////////////
        //////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n0Reverse[j] == 1)
            {
                ones2++;
                onesInCols[p] = ones2;
                order2 = true;
            }
            if (n0Reverse[j] == 0 && order2)
            {
                ones2 = 0;
                p++;
                order2 = false;
            }
        }
        p++;
        ones2 = 0;
        ///////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n1Reverse[j] == 1)
            {
                ones2++;
                onesInCols[p] = ones2;
                order2 = true;
            }
            if (n1Reverse[j] == 0 && order2)
            {
                ones2 = 0;
                p++;
                order2 = false;
            }
        }
        p++;
        ones2 = 0;
        /////////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n2Reverse[j] == 1)
            {
                ones2++;
                onesInCols[p] = ones2;
                order2 = true;
            }
            if (n2Reverse[j] == 0 && order2)
            {
                ones2 = 0;
                p++;
                order2 = false;
            }
        }
        p++;
        ones2 = 0;
        /////////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n3Reverse[j] == 1)
            {
                ones2++;
                onesInCols[p] = ones2;
                order2 = true;
            }
            if (n3Reverse[j] == 0 && order2)
            {
                ones2 = 0;
                p++;
                order2 = false;
            }
        }
        p++;
        ones2 = 0;
        //////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n4Reverse[j] == 1)
            {
                ones2++;
                onesInCols[p] = ones2;
                order2 = true;
            }
            if (n4Reverse[j] == 0 && order2)
            {
                ones2 = 0;
                p++;
                order2 = false;
            }
        }
        p++;
        ones2 = 0;
        /////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n5Reverse[j] == 1)
            {
                ones2++;
                onesInCols[p] = ones2;
                order2 = true;
            }
            if (n5Reverse[j] == 0 && order2)
            {
                ones2 = 0;
                p++;
                order2 = false;
            }
        }
        p++;
        ones2 = 0;
        /////////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n6Reverse[j] == 1)
            {
                ones2++;
                onesInCols[p] = ones2;
                order2 = true;
            }
            if (n6Reverse[j] == 0 && order2)
            {
                ones2 = 0;
                p++;
                order2 = false;
            }
        }
        p++;
        ones2 = 0;
        ////////////////////////////
        for (int j = 7; j >= 0; j--)
        {
            if (n7Reverse[j] == 1)
            {
                ones2++;
                onesInCols[p] = ones2;
                order2 = true;
            }
            if (n7Reverse[j] == 0 && order2)
            {
                ones2 = 0;
                p++;
                order2 = false;
            }
        }

        for (int j = q; j >= 0; j--)
        {
            //Console.Write("{0}", onesInRows[j]);
            if (onesInRows[j] > maxRow)
            {
                maxRow = onesInRows[j];
            }
        }
        //Console.WriteLine();
        for (int j = p; j >= 0; j--)
        {
            //Console.Write("{0}", onesInCols[j]);
            if (onesInCols[j] > maxCol)
            {
                maxCol = onesInCols[j];
            }
        }
        if (maxRow >= maxCol)
        {
            //countRows = -1;
            for (int j = q; j >= 0; j--)
            {
                if (maxRow == onesInCols[j])
                {
                    countCols++;
                }
                if (maxRow == onesInRows[j])
                {
                    countRows++;
                }
            }
            //Console.WriteLine();
            if (maxRow == 1 )
            {
                Console.WriteLine("{0}", maxRow);
                Console.WriteLine("{0}", (countRows + countCols)/2);
            }
            else
            {
                Console.WriteLine("{0}", maxRow);
                Console.WriteLine("{0}", countRows + countCols);
            }
        }
        if (maxRow < maxCol)
        {

            //countCols = -1;
            for (int j = q; j >= 0; j--)
            {
                if (maxCol == onesInCols[j])
                {
                    countCols++;
                }
                if (maxCol == onesInRows[j])
                {
                    countRows++;
                }
            }
            //Console.WriteLine();
            if (maxCol == 1)
            {
                Console.WriteLine("{0}", maxCol);
                Console.WriteLine("{0}", (countRows + countCols)/2);
            }
            else
            {
                Console.WriteLine("{0}", maxCol);
                Console.WriteLine("{0}", countRows + countCols);
            }
        }

        

    }
}

