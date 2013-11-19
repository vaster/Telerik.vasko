using System;

class PrintIndexOfLetter
{
    static void Main()
    {
        string word;
        char[] alph = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        Console.Write("Enter word(only capitals):");
        word = Console.ReadLine();

        char[] wordIntLetters = word.ToCharArray();

        for (int i = 0; i < wordIntLetters.Length; i++)
        {
            for (int j = 0; j < alph.Length; j++)
            {
                if (wordIntLetters[i] < 97)
                {
                    if (wordIntLetters[i] == alph[j])
                    {
                        Console.WriteLine("{0}->{1}", wordIntLetters[i], j);
                    }
                }
                ///////////////////////////////
                if (wordIntLetters[i] >= 97)
                {
                    if (wordIntLetters[i] - 32 == alph[j])
                    {
                        Console.WriteLine("{0}->{1}", wordIntLetters[i], j);
                    }
                }
            }

        }

    }
}

