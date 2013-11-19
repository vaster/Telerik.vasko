using System;



class SandGlass
{
    static void Main()
    {
        int n;
        int check;
        int dotLeft;
        int dotRight;
        int checker = 0;
        int flag = 0;
        int flag2 = 0;
        int limiter = 1;
        int dotCounterRight = 0;
        int dotCounterLeft = 0;
        int i = 0;
        int limitCounter = 1;
        int limiterCheck = 0;
        string star = "*";
        string dot =".";
        string[] bottom = new string[10000];
        do
        {
            n = int.Parse(Console.ReadLine());
            check = n;
        } while ((n < 3 || n > 101)||(n%2==0));
        do
        {
            if(limitCounter==1)
                limiterCheck = (n - 5)/2;
            limitCounter++;
            if (n == 5)
            {
                limiter = -1;
            }
            if (n == 3)
            {
                limiter = -2;
            }
            limiter = limitCounter + limiter;
            
            limiterCheck--;
        }while(limiterCheck >=1);
        limiter = limiter - check;
        
        
        do
        {
            if (flag == 0)
            {
                flag++;
                for (dotLeft = (check - n) / 2; dotLeft >= 1; dotLeft--)
                {
                    
                    Console.Write("{0}",dot);
                    dotCounterLeft++;
                    
                    if(check + limiter >= dotCounterLeft)
                    {
                        bottom[i] = dot;
                        i++;
                    }
                    
                }
            }
            Console.Write("{0}", star);
            if (check + limiter>= dotCounterLeft)
            {
                bottom[i] = star;
                i++;
            }
            n--;

            if (n == 0)
            {


                flag = 0;
                flag2 = 0;
                checker++;
                n = check;
                n = n - 2 * checker;
                if (flag2 == 0)
                {
                    for (dotRight = (check - n) / 2; dotRight >= 2; dotRight--)
                    {

                        Console.Write("{0}", dot);
                        dotCounterRight++;
                        if (check + limiter >= dotCounterRight)
                        {
                            bottom[i] = dot;
                            i++;
                        }
                        flag2++;
                    }
                }
                if(n>=0)
                Console.WriteLine();
            }
            
        } while (n >= 0);
        
        for(;i>=0;i--)
        {

            Console.Write("{0}", bottom[i]);
            if (i % check == 0 )
            {
                
                Console.WriteLine();
            }
           
            
        }
    }
}

