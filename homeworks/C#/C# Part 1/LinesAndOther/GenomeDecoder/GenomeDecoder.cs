using System;

class GenomeDecoder
{
    static void Main()
    {
        int n;
        int m;
        string countA =null;
        string countB =null;
        string countC =null;
        string countD =null;
        char a = '\0';
        char b = '\0';
        char c = '\0';
        char d = '\0';
        int checkA = 0;
        int checkB = 0;
        int checkC = 0;
        int checkD = 0;
        int checkCharA = 0;
        int checkCharB = 0;
        int checkCharC = 0;
        int checkCharD = 0;
        string[] space = Console.ReadLine().Split();
        string genome;
        

        n = int.Parse(space[0]);
        m = int.Parse(space[1]);
        
            genome = Console.ReadLine();
            char[] charGenome = genome.ToCharArray();
            for (int i = 0; i < charGenome.Length; i++)
            {
                if (char.IsDigit(charGenome[i]) && checkCharA==0)
                {
                    countA = countA + charGenome[i];
                    checkA++;
                }
                if (char.IsLetter(charGenome[i]) && checkCharA==0)
                {
                    a = charGenome[i];
                    checkCharA++;
                }
                if (char.IsDigit(charGenome[i])&& checkCharB==0 && checkCharA)
                {
                    countB = countB + charGenome[i];
                    checkB++;
                }
                if (char.IsLetter(charGenome[i]) && checkCharB == 0)
                {
                    b = charGenome[i];
                    checkCharB++;
                }
                
            }
            
        
        /*for (int i = 0; i < genome.Length; i++)
        {
            if (char.IsNumber(charGenome[i]))
            {
                countA = charGenome[i];
            }
        }*/

        Console.WriteLine("{0} {1}",countA,countB);
        Console.WriteLine("{0} {1}",a,b);
        //Console.ReadKey();
    }
}

