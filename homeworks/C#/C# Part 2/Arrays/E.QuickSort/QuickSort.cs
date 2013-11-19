using System;
using System.Collections.Generic;


class QuickSort
{
    static void Main()
    {
        int length;
        int pivot;
        List<string> befour = new List<string>();
        List<string> after = new List<string>();
        int bef = 0;
        int aft = 0;
        int des=0;
        bool doIt = false;
        int y = 0;
        string max;
        string temp;
        int indexer = 0;

        Console.Write("Enter legth of the array:");
        length = int.Parse(Console.ReadLine());
        string[] strings = new string[length];
        Console.WriteLine("Enter letters");
        for (int i = 0; i < length; i++)
        {
            Console.Write("array[{0}]=", i);
            strings[i] = Console.ReadLine();
        }

        pivot = length / 2;



        for (int i = 0; i < length; i++)
        {
            des = String.CompareOrdinal(strings[i], strings[pivot]);
            //Console.WriteLine(des);
            if (des < 0)
            {
                befour.Add(strings[i]);
                bef++;
                
            }
            if (des > 0)
            {
                after.Add(strings[i]);
                aft++;
            }

           
           
        }
        
        ///////////////////////////////
        for (int i = 0; i < bef; i++)
        {
            max = "a";
            if (bef - i <= 1)
            {
                break;
            }
            for (int u = 0; u < bef-i; u++)
            {
                
                //Console.Write(befour[u]);
                des = String.CompareOrdinal(befour[u], max);
                if (des > 0)
                {
                    max = befour[u];
                    indexer = u;
                }
                //Console.WriteLine(max);
            }
            temp = befour[bef - 1-i];
            befour[bef - 1-i] = max;
            befour[indexer] = temp;
            //Console.WriteLine("{0}++",temp);

        }
        indexer = 0;
        ////////////////////////////
        for (int i = 0; i < aft; i++)
        {
            max = "a";
            if (aft - i <= 1)
            {
                break;
            }
            for (int u = 0; u < aft - i; u++)
            {

                //Console.Write(befour[u]);
                des = String.CompareOrdinal(after[u], max);
                //Console.WriteLine(des);
                if (des > 0)
                {
                    max = after[u];
                    indexer = u;
                }
                
            }
            //Console.WriteLine("{0}+++", max);
            temp =after[aft - 1 - i];
            after[aft - 1 - i] = max;
            after[indexer] = temp;
            //Console.WriteLine("{0}++",temp);

        }
        ////////////////////////////
        //Console.WriteLine(pivot);
        ///////////////////////////////

        List<string> combine = new List<string>();
        combine.AddRange(befour);
        combine.Add(strings[pivot]);
        combine.AddRange(after);
        for (int u = 0; u < length; u++)
        {
            Console.Write(combine[u]);
        }
        ///////////////////////////////
    }
}

