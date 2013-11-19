using System;

class FirTree
{
    static void Main()
    {
        int n;
        int dotLeft;
        int dotRight;
        int star = 1;
        int printStar = 0;
        int i = 0;
        bool right = true;
        bool left = true;
        bool coree = true;



        n = int.Parse(Console.ReadLine());
        string[] core = new string[2 * (n - 1) + 1];

        do
        {
            dotLeft = n - 2;
            dotRight = n - 2;
            printStar = star;
            while (dotLeft > 0)
            {
                
                Console.Write(".");
                if (left)
                {
                    core[i] = ".";
                    i++;
                }
                dotLeft--;
                

            }
            left = false;
            while (printStar > 0)
            {
                Console.Write("*");
                if (right)
                {
                    core[i] = "*";
                    i++;
                }
                printStar--;

            }
            coree = false;
            while (dotRight > 0)
            {
                Console.Write(".");
                if (right)
                {
                    core[i] = ".";
                    i++;
                }
                dotRight--;

            }
            right = false;
            n--;
            star = star + 2;
            Console.WriteLine();
        } while (n > 1);
        for (int j = 0; j < core.Length; j++)
        {
            Console.Write("{0}",core[j]);
        }
        Console.WriteLine();
    }
}

