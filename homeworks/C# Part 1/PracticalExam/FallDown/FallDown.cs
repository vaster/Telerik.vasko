using System;

class FallDown
{
    static void Main()
    {
        int n0;
        int n1;
        int n2;
        int n3;
        int n4;
        int n5;
        int n6;
        int n7;
        int i = 0;
        int oneOrZero = 0;

        int[] keepOnes = new int[8];

        int[] arrayN0 = new int[8];
        int[] arrayN1 = new int[8];
        int[] arrayN2 = new int[8];
        int[] arrayN3 = new int[8];
        int[] arrayN4 = new int[8];
        int[] arrayN5 = new int[8];
        int[] arrayN6 = new int[8];
        int[] arrayN7 = new int[8];


        n0 = int.Parse(Console.ReadLine());
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());
        n5 = int.Parse(Console.ReadLine());
        n6 = int.Parse(Console.ReadLine());
        n7 = int.Parse(Console.ReadLine());

        do
        {

            arrayN0[i] = n0 % 2;
            if (arrayN0[i] == 1)
            {
                keepOnes[i]++;
            }
            n0 = n0 / 2;
            /////////////
            arrayN1[i] = n1 % 2;
            if (arrayN1[i] == 1)
            {
                keepOnes[i]++;
            }
            n1 = n1 / 2;
            ////////////
            arrayN2[i] = n2 % 2;
            if (arrayN2[i] == 1)
            {
                keepOnes[i]++;
            }
            n2 = n2 / 2;
            ////////////
            arrayN3[i] = n3 % 2;
            if (arrayN3[i] == 1)
            {
                keepOnes[i]++;
            }
            n3 = n3 / 2;
            ////////////
            arrayN4[i] = n4 % 2;
            if (arrayN4[i] == 1)
            {
                keepOnes[i]++;
            }
            n4 = n4 / 2;
            ////////////
            arrayN5[i] = n5 % 2;
            if (arrayN5[i] == 1)
            {
                keepOnes[i]++;
            }
            n5 = n5 / 2;
            ////////////
            arrayN6[i] = n6 % 2;
            if (arrayN6[i] == 1)
            {
                keepOnes[i]++;
            }
            n6 = n6 / 2;
            ////////////
            arrayN7[i] = n7 % 2;
            if (arrayN7[i] == 1)
            {
                keepOnes[i]++;
            }
            n7 = n7 / 2;
            i++;
        } while (i <= 7);


        n0 = 0;
        n1 = 0;
        n2 = 0;
        n3 = 0;
        n4 = 0;
        n5 = 0;
        n6 = 0;
        n7 = 0;
        /*for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", arrayN0[j]);

        }
        Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", arrayN1[j]);

        }
        Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", arrayN2[j]);

        }
        Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", arrayN3[j]);

        }
        Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", arrayN4[j]);

        }
        Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", arrayN5[j]);

        }
        Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", arrayN6[j]);

        }
        Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
            Console.Write("{0}", arrayN7[j]);

        }*/

        //Console.WriteLine();

       // Console.WriteLine("{0}", keepOnes[1]);

        for (int j = 0; j <= 7; j++)
        {
            int k = 0;
            k++;
            if (k <= keepOnes[j])
            {
                oneOrZero = 2;
            }
            if (k > keepOnes[j])
            {
                oneOrZero = 0;
            }
            arrayN7[j] = oneOrZero;
            /////////////////////////
            k++;
            if (k <= keepOnes[j])
            {
                oneOrZero = 2;
            }
            if (k > keepOnes[j])
            {
                oneOrZero = 0;
            }
            arrayN6[j] = oneOrZero;
            //////////////////////
            k++;
            if (k <= keepOnes[j])
            {
                oneOrZero = 2;
            }
            if (k > keepOnes[j])
            {
                oneOrZero = 0;
            }
            arrayN5[j] = oneOrZero;
            ////////////////////////
            k++;
            if (k <= keepOnes[j])
            {
                oneOrZero = 2;
            }
            if (k > keepOnes[j])
            {
                oneOrZero = 0;
            }
            arrayN4[j] = oneOrZero;
            ///////////////////////
            k++;
            if (k <= keepOnes[j])
            {
                oneOrZero = 2;
            }
            if (k > keepOnes[j])
            {
                oneOrZero = 0;
            }
            arrayN3[j] = oneOrZero;
            //////////////////////
            k++;
            if (k <= keepOnes[j])
            {
                oneOrZero = 2;
            }
            if (k > keepOnes[j])
            {
                oneOrZero = 0;
            }
            arrayN2[j] = oneOrZero;
            /////////////////////
            k++;
            if (k <= keepOnes[j])
            {
                oneOrZero = 2;
            }
            if (k > keepOnes[j])
            {
                oneOrZero = 0;
            }
            arrayN1[j] = oneOrZero;
            //////////////////////
            k++;
            if (k <= keepOnes[j])
            {
                oneOrZero = 2;
            }
            if (k > keepOnes[j])
            {
                oneOrZero = 0;
            }
            arrayN0[j] = oneOrZero;
            ///////////////////

        }
        //Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
            //Console.Write("{0}", arrayN0[j]);
            if(arrayN0[j]==2)
            n0 = (int)Math.Pow(arrayN0[j], j) + n0;

        }
        //Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
            //Console.Write("{0}", arrayN1[j]);
            if (arrayN1[j] == 2)
            n1 = (int)Math.Pow(arrayN1[j], j) + n1;

        }
        //Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
            //Console.Write("{0}", arrayN2[j]);
            if (arrayN2[j] == 2)
            n2 = (int)Math.Pow(arrayN2[j], j) + n2;

        }
        //Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
           //Console.Write("{0}", arrayN3[j]);
            if (arrayN3[j] == 2)
            n3 = (int)Math.Pow(arrayN3[j], j) + n3;

        }
        //Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
            //Console.Write("{0}", arrayN4[j]);
            if (arrayN4[j] == 2)
            n4 = (int)Math.Pow(arrayN4[j], j) + n4;

        }
       //Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
            //Console.Write("{0}", arrayN5[j]);
            if (arrayN5[j] == 2)
            n5 = (int)Math.Pow(arrayN5[j], j) + n5;

        }
        //Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
            //Console.Write("{0}", arrayN6[j]);
            if (arrayN6[j] == 2)
            n6 = (int)Math.Pow(arrayN6[j], j) + n6;

        }
        //Console.WriteLine();
        for (int j = 7; j >= 0; j--)
        {
            //Console.Write("{0}", arrayN7[j]);
            if (arrayN7[j] == 2)
            n7 = (int)Math.Pow(arrayN7[j], j) + n7;

        }

        //Console.WriteLine();
        //Console.WriteLine();

        Console.WriteLine("{0}", n0);
        Console.WriteLine("{0}", n1);
        Console.WriteLine("{0}", n2);
        Console.WriteLine("{0}", n3);
        Console.WriteLine("{0}", n4);
        Console.WriteLine("{0}", n5);
        Console.WriteLine("{0}", n6);
        Console.WriteLine("{0}", n7);






    }
}