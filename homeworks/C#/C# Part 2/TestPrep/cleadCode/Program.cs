using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n;
        char ch;
        n = int.Parse(Console.ReadLine());
        string[] input = new string[n];
        string[] inputFinal = new string[n];
        string sentance;
        StringBuilder off = new StringBuilder();
        bool flag = true;
        bool flagClear = false;
        List<string> final = new List<string>();
        int counter = 0;
        int count = 0;
        int couuuter = 0;
        //Works on 60% in bgcoder
        for (int i = 0; i < n; i++)
        {
            input[i] = Console.ReadLine();
        }
        for (int i = 0; i < input.Length; i++)
        {
            couuuter = 0;
            sentance = input[i] + " ";

            //
            for (int y = 0; y < sentance.Length; y++)
            {
                flagClear = false;
                if (count == 2)
                {
                    flagClear = true;
                    count = 0;
                }
                ch = sentance[y];
                if (ch == '@')
                {
                    couuuter++;
                }
                if (ch == ';')
                {
                    couuuter--;
                }


                if (ch == '\"' && sentance[y-1]!='\\')
                {
                    count++;
                }
                if (flagClear || count == 0)
                {
                    if (sentance[y] == '/' && sentance[y + 1] == '*')
                    //i
                    {
                        flag = false;
                    }

                    if (!flag)
                    {

                        {
                            if (sentance[y] == '*' && sentance[y + 1] == '/')
                            {


                                flag = true;
                                y = y + 2;
                                ch = sentance[y];
                            }
                        }
                    }



                    if (sentance[y] == '/' && sentance[y + 1] == '/')
                    {
                        break;
                    }

                }
                //Console.WriteLine(flag);
                //Console.WriteLine(ch);

                if (flag)
                {
                    off.Append(ch);
                }







            }


            inputFinal[i] = off.ToString().TrimEnd();
            //if (couuuter <= 0)
            {
                off.Clear();
            }
        }
        //Console.WriteLine();

        for (int i = 0; i < inputFinal.Length; i++)
        {
            if (!inputFinal[i].Equals(string.Empty))
            {
                final.Add(inputFinal[i]);
                //counter++;
            }
            //Console.WriteLine(counter);
            /* if (inputFinal[i].Equals("{") && (!inputFinal[i + 1].Equals("}")))
             {
               
                 final[counter] = final[counter] + final[counter + 1];
                 final[counter + 1] = string.Empty;

             }*/
            if (!inputFinal[i].Equals(string.Empty))
            {
                counter++;
            }
        }
        //Console.WriteLine(final.Capacity);
        for (int i = 0; i < final.Count; i++)
        {
            //Console.WriteLine(final[i]);
            if (final[i].Equals("{") && !(final[i + 1].Equals("}")))
            {
                final[i] = final[i]+ " " + final[i + 1];
                final[i + 1] = string.Empty;
            }
            if (final[i] != string.Empty)
            {
                Console.WriteLine(final[i]);
            }
        }
    }
}

