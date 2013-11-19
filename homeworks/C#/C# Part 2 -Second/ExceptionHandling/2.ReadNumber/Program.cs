using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReadNumber
{
    /*
     Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
     If an invalid number or non-number text is entered, the method should throw an exception.
     Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100

     */
    public class Program
    {
        public static void ReadNumberByPattern(int start, int end)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nubmer:");
                string input = Console.ReadLine();

                int number = 0;

                if (!int.TryParse(input, out number))
                {
                    throw new FormatException("Not a number!");
                }

                if (number <= start || number >= end)
                {
                    throw new ArgumentException("Number not in range!");
                }

                start = number;
            }
        }

        static void Main(string[] args)
        {
            Program.ReadNumberByPattern(1,100);
        }
    }
}
