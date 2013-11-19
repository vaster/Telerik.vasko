using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SqrtRoot
{
    /*
     Write a program that reads an integer number and calculates and prints its square root.
     If the number is invalid or negative, print "Invalid number".
     In all cases finally print "Good bye". Use try-catch-finally.

     */

    public class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            double output = 0;

            string input = Console.ReadLine();

            try
            {
                number = int.Parse(input);
                if (number < 0)
                {
                    throw new ArgumentException("Negative not allowed!");
                }
                output = Math.Sqrt(number);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Wrong Number!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong Number!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Wrong Number!");
            }
            finally
            {
                Console.WriteLine("Good Bye!");
            }

        }
    }
}
