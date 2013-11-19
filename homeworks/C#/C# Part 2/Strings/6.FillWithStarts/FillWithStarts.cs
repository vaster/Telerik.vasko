using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillWithStarts
{
    static void Main(string[] args)
    {
        StringBuilder inputManipulation = new StringBuilder(20);
        string input;

        input = Console.ReadLine();
        if (input.Length >= 20)
        {
            input = input.Substring(0, 20);
        }
        inputManipulation.Append(input);
        for (int i = inputManipulation.Length; i < 20; i++)
        {
            inputManipulation.Append('*');
        }


        Console.WriteLine("Result: {0}",inputManipulation.ToString());
    }
}

