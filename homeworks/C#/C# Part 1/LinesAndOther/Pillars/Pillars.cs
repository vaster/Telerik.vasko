using System;

class Pillars
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
       

        int[] keepOnes = new int[8];

        int[] arrayN0 = new int[8];
        int[] arrayN1 = new int[8];
        int[] arrayN2 = new int[8];
        int[] arrayN3 = new int[8];
        int[] arrayN4 = new int[8];
        int[] arrayN5 = new int[8];
        int[] arrayN6 = new int[8];
        int[] arrayN7 = new int[8];

        int sum1 = 0;
        int sum2 = 0;

        bool firstOne = true;
        bool firstTwo = true;
        bool no = true;


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


       
        for (int q = 6; q >=0 ; q--)
        {
            firstOne = true;
            firstTwo = true;
            
            for (int j = q; j < 8; j++)
            {
                
                if (!firstOne)
                {
                    sum1 = sum1 + keepOnes[j];
                    
                }
                firstOne = false;
            }
            
            for (int j = q; j >= 0; j--)
            {
                if (!firstTwo)
                {
                    sum2 = sum2 + keepOnes[j];
                    
                }
                firstTwo = false;
            }
            
            if (sum1 == sum2)
            {
                no = false;
                Console.WriteLine(q);
                Console.WriteLine(sum1);
                break;
            }
            sum1 = 0;
            sum2 = 0;
        }
        if (no)
        {
            Console.WriteLine("No");
        }
         

    }
}
