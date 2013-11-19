using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



class ExtractDate
{
    static void Main(string[] args)
    {

        string text;

        Console.Write("Enter text:");
        text = Console.ReadLine();
        Regex datePatern = new Regex(@"\d+[-+.]\d+[-+.]\d+");


        MatchCollection dateMatches = datePatern.Matches(text);
        StringBuilder sb = new StringBuilder();

        foreach (Match emailMatch in dateMatches)
        {
            sb.AppendLine(emailMatch.Value);
        }

        Console.WriteLine(sb.ToString());
    }
}

