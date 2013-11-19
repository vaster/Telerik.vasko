using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ForbbidenWords
{
    static void Main(string[] args)
    {
        string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        StringBuilder cencored = new StringBuilder();
        string[] forbbiden = { "Microsoft","PHP","CLR"};
        StringBuilder stars = new StringBuilder();
        string replace;
        int index = 0;
        char ch = ' ';
        int j = 0;

      

        for (int z = 0; z < input.Length; z++)
        {
            if (j < forbbiden.Length)
            {
                index = input.IndexOf(forbbiden[j]);
                //Console.WriteLine("{0} {1}", z, index);
                if (z != index)
                {
                    ch = input[z];
                    //cencored.Append(ch);
                }
                else
                {

                    for (int i = 0; i < forbbiden[j].Length-1; i++)
                    {
                        ch = '*';
                        cencored.Append(ch);
                        z++;
                    }
                    j++;
                    Console.WriteLine(j);

                    //cencored.Append(' ');
                }

                cencored.Append(ch);
            }

        }

        Console.WriteLine(cencored.ToString());

    }
}

