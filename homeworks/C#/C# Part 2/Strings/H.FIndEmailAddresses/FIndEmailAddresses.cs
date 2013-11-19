using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


    class FIndEmailAddresses
    {
        static void Main(string[] args)
        {
            string text;

            Console.Write("Enter text:");
            text = Console.ReadLine();
            Regex emailPatern = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);


            MatchCollection emailMatches = emailPatern.Matches(text);
            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);
            }

            Console.WriteLine(sb.ToString());


            //Кода е взаимстван http://stackoverflow.com
        }
    }

