using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        //not woring one
        
        int n;
        int k = 0;
        int look = 0;
        string words;
        int coef = 0;
        int helpToIndexCoef = 0;
        int indexCoef = 0;
        int wordcoec = 0;
        bool solution = false;
        StringBuilder verticalToHorizontal = new StringBuilder();
        List<string> sortItOut = new List<string>();

        n = int.Parse(Console.ReadLine());
        string[] input = new string[2*n];
        string[] inputVertical = new string[2 * n];
        ///////////////////////////////////
        do
        {
            input[look] = Console.ReadLine();
            look++;
        } while (look != n*2);
        ///////////////////////////////////


        for (int i = 0; i < input.Length; i++)
        {
            words = input[i];
            //Console.WriteLine(words[0]);
            //Console.WriteLine(indexCoef);
            //Console.WriteLine(wordcoec);
            verticalToHorizontal.Append(words[indexCoef]);
            
            {
                coef++;
                if (n - coef == 0)
                {
                    
                    inputVertical[k] = verticalToHorizontal.ToString();
                    k++;
                    verticalToHorizontal.Clear();
                    helpToIndexCoef++;
                    if (helpToIndexCoef == 2)
                    {
                        helpToIndexCoef = 0;
                        indexCoef++; 
                    }
                    coef = 0;
                   
                }
                
            }

            if (i == input.Length - 1)
            {
                wordcoec++;
                if (wordcoec <= n-1)
                {
                    i = -1;
                    //wordcoec++;
                }
               // Console.WriteLine(wordcoec);
                
            }
        }

        //for (int i = 0; i < input.Length; i++)
        {
            //Console.WriteLine(input[i]);
        }

        Console.WriteLine();
        for (int i = 0; i < inputVertical.Length; i++)
        {
            for (int h = 0; h < input.Length; h++)
            {
                if (inputVertical[i].Equals(input[h]))
                {

                    Console.WriteLine(inputVertical[i]);
                   // sortItOut.Add(inputVertical[i]);
                    solution = true;
                }
            }
        }

        //Console.WriteLine(sortItOut[0]);
        //string[] sorted = new string[sortItOut.Capacity];

        
        //string[] sorted = sortItOut.ToArray();
        

       // Array.Sort(sorted);
       // for (int i = 0; i < sorted.Length; i++)
        {
           // Console.WriteLine(sorted[i]);
        }

        if (!solution)
        {
            Console.WriteLine("NO SOLUTION!");
        }


    }
}

