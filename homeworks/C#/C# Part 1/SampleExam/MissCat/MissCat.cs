using System;

class MissCat
{
    static void Main()
    {
        int n;
        int vote;
        int voteCounterA = 0;
        int voteCounterB = 0;
        int voteCounterC = 0;
        int voteCounterD = 0;
        int voteCounterE = 0;
        int voteCounterF = 0;
        int voteCounterG = 0;
        int voteCounterH = 0;
        int voteCounterI = 0;
        int voteCounterJ = 0;
        int max = 0;
        int winner = 0;
        int[] array = new int[10];
        int i;
        int check;


        n = int.Parse(Console.ReadLine());
        check = n;
        do
        {
            do
            {
                vote = int.Parse(Console.ReadLine());
            } while (vote < 1 || vote > 10);
            if (vote == 1)
            {
                voteCounterA++;
                array[vote - 1] = voteCounterA;
                if (voteCounterA > max)
                {
                    max = voteCounterA;
                    winner = 1;
                }

            }
            if (vote == 2)
            {
                voteCounterB++;
                array[vote - 1] = voteCounterB;
                if (voteCounterB > max)
                {
                    max = voteCounterB;
                    winner = 2;
                }
            }
            if (vote == 3)
            {
                voteCounterC++;
                array[vote - 1] = voteCounterC;
                if (voteCounterC > max)
                {
                    max = voteCounterC;
                    winner = 3;
                }
            }
            if (vote == 4)
            {
                voteCounterD++;
                array[vote - 1] = voteCounterD;
                if (voteCounterD > max)
                {
                    max = voteCounterD;
                    winner = 4;
                }
            }
            if (vote == 5)
            {
                voteCounterE++;
                array[vote - 1] = voteCounterE;
                if (voteCounterE > max)
                {
                    max = voteCounterE;
                    winner = 5;
                }
            }
            if (vote == 6)
            {
                voteCounterF++;
                array[vote - 1] = voteCounterF;
                if (voteCounterF > max)
                {
                    max = voteCounterF;
                    winner = 6;
                }
            }
            if (vote == 7)
            {
                voteCounterG++;
                array[vote - 1] = voteCounterG;
                if (voteCounterG > max)
                {
                    max = voteCounterG;
                    winner = 7;
                }
            }
            if (vote == 8)
            {
                voteCounterH++;
                array[vote - 1] = voteCounterH;
                if (voteCounterH > max)
                {
                    max = voteCounterH;
                    winner = 8;
                }
            }
            if (vote == 9)
            {
                voteCounterI++;
                array[vote - 1] = voteCounterI;
                if (voteCounterI > max)
                {
                    max = voteCounterI;
                    winner = 9;
                }
            }
            if (vote == 10)
            {
                voteCounterJ++;
                array[vote - 1] = voteCounterJ;
                if (voteCounterJ > max)
                {
                    max = voteCounterJ;
                    winner = 10;
                }
            }
            n--;
        } while (n > 0);

        for (i = 0; i >= 9; i++)
        {
            if (array[i] == array[winner - 1])
            {
                winner = i + 1;
            }

        }

        Console.WriteLine("{0}", winner);
    }
}

