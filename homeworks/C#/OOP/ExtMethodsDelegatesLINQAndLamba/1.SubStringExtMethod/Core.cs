using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and
    has the same functionality as Substring in the class String.*/

namespace _1.SubStringExtMethod
{
    class Core
    {
        static void Main(string[] args)
        {
            //Testing
            StringBuilder test = new StringBuilder();
            StringBuilder result = new StringBuilder();
            string sampleText = "Test me please.";

            test.Append(sampleText);
            result = test.SubString(14,0);
            Console.WriteLine(result);
   
        }
    }
}
