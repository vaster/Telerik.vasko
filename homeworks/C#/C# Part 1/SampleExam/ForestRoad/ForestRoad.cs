using System;

class ForestRoad
{
    static void Main()
    {
        int n;
        int m;
        int i = 0;
        int star = 0;
        bool check = true;
        bool go = false;
        bool wait = false;


        n = int.Parse(Console.ReadLine());
        m = n;
        string[] forest = new string[n];
        n = (n * 2) - 1;
        do
        {
            if (go)
            {
                if (star <m-1 && check)
                {
                    star++;
                    
                    //Console.Write("dasda");
                  
                }
                if ((star >= m-1  || !check)&&wait)
                {
                    star--;
                    check = false;
                    
                    //Console.Write("nn=enen");
                }
                if (star == m - 1)
                {
                    wait = true;
                }
                
            }
            do
            {

                forest[i] = ".";


                forest[star] = "*";
                go = true;


                i++;
            } while (i < m);
            n--;
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0}", forest[j]);
            }
            Console.WriteLine();
            i = 0;

        } while (n > 0);


    }
}

