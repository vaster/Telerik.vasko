using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SumOfAStrings
{
    public class Program
    {
        /*
         You are given a sequence of positive integer values written into a string, separated by spaces.
         Write a function that reads these values from given string and calculates their sum. Example:
		    string = "43 68 9 23 318"  result = 461

         */
        static void Main(string[] args)
        {

            string input = "43 68 9 23 318";

            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int currNumber = 0;
            int sum = 0;
            foreach (var number in numbers)
            {
                currNumber = int.Parse(number);
                sum = sum + currNumber;
                
            }

            Console.WriteLine(input + " = " + sum);
        }
    }
}
