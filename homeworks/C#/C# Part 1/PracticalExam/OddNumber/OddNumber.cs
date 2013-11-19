using System;

class OddNumber
{
    static void Main()
    {
        int n;
        int count=0;
        bool doItRight = true;
        
        
        n = int.Parse(Console.ReadLine());
        long[] keepCount = new long[n];
        long[] array = new long[n];

        do
        {
            array[n-1] = long.Parse(Console.ReadLine());
            n--;
        }while(n>0);

        for (int i = 0; i < array.Length; i++)
        {
            count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;

                    //Console.WriteLine("{0}{1}->{2}",array[i],array[j] , count);
                    keepCount[i] = count;
                }
                /*if (array[i] != array[j])
                {
                    count++;
                    keepCount[i] = count;
                }*/
            }
            
        }
        //Console.WriteLine();
        for (int i = 0; i < keepCount.Length; i++)
        {
            if (keepCount[i] % 2 != 0 && doItRight)
            {
                Console.WriteLine("{0}", array[i]);
                doItRight = false;
            }
        }
            
    }        
}

