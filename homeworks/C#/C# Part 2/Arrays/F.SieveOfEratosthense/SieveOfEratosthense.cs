using System;
using System.Numerics;
using System.Collections.Generic;




class SieveOfEratosthense
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int prime;
        bool flag = true;
        bool check = false;
        int y = 0;
        int count = 0;

        for (int i = 1; i <= 10000; i++)
        {
            numbers.Add(i);
        }
        //Програмата работи срашно бавно с 10 000 000 числа с този код.
        prime = numbers[1];
        while (flag)
        {
            for (int i = 1+y; i < 10000-count; i++)
            {
                //Console.WriteLine(i);
                if (numbers[i] != 1)
                {
                   
                    //Console.WriteLine("{0}predi{1} ",numbers[i], prime);
                    if (numbers[i] % prime != 0 && check)
                    {
                        prime = numbers[i];
                        check = false; 
                    }
                    
                    
                    if (numbers[i] % prime == 0 && numbers[i]!=prime)
                    {
                        numbers[i] = 1;
                        numbers.Remove(1);
                        count++;
                    }
                    //Console.WriteLine("{0}sled{1}", numbers[i], prime);
                }
            }
            check = true;
            y++;
            if (y == 299)
            {
                flag = false;
            }
        }
        for (int i = 0; i < 10000-count; i++)
        {
            if (numbers[i] != 1)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}

