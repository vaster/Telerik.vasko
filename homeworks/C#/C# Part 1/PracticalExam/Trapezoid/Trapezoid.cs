using System;

class Trapezoid
{
    static void Main()
    {
        int n;
        int row = 0;
        int col;
        bool top = true;
        //int check = 0;


        n = int.Parse(Console.ReadLine());
        string[] trapz = new string[n * 2];
        col = n + 1;

        do
        {

            do
            {

                trapz[row] = ".";
                if (row >= n && top)
                {
                    trapz[row] = "*";

                }
                if (row >= n * 2 - 1)
                {
                    trapz[row] = "*";
                }
                if (row == col - 1)
                {
                    trapz[row] = "*";
                }

                if (col == 1)
                {
                    trapz[row] = "*";
                }
                Console.Write("{0}", trapz[row]);
                row++;
            } while (row < n * 2);
            col--;
            row = 0;
            top = false;

            Console.WriteLine();
        } while (col > 0);


    }
}

