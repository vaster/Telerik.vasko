using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ReverseDecimal
{
    public class Program
    {
        public static decimal Reverse(decimal number)
        {
            string numberAsString = number.ToString();

            StringBuilder result = new StringBuilder();

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                result.Append(numberAsString[i]);
            }

            return Convert.ToDecimal(result.ToString());
        }
        static void Main(string[] args)
        {
            decimal number = 12.59M;

            decimal result = Program.Reverse(number);

            Console.WriteLine(number + " -> " + result);
        }
    }
}
