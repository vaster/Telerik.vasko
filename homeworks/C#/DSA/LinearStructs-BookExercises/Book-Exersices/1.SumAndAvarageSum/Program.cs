using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SumAndAvarageSum
{

    /*
     * Write a program that reads from the console a sequence of positive integer numbers.
     * The sequence ends when empty line is entered. 
     * Calculate and print the sum and average of the elements of the sequence. 
     * Keep the sequence in List<int>.
    */
    public class Program
    {
        /// <summary>
        /// Read from the console untill an invalid number is entered.
        /// </summary>
        /// <param name="linkedListSample">ICustomList to store the numbers.</param>
        static void ConsoleReader(ICustumList<int> linkedListSample)
        {
            int input = 0;
            bool toProceed = true;

            while (toProceed)
            {
                toProceed = int.TryParse(Console.ReadLine(), out input);
                if (toProceed)
                {
                    if (input > 0)
                    {
                        linkedListSample.Add(input);
                    }
                    else
                    {
                        Console.WriteLine("Enter positive number!");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            ICustumList<int> linkedListSample = new DynamicList<int>();

            Console.WriteLine("Numbers for Dynamic List:");
            Console.WriteLine("(Until u enter empty line or invalid format for a number)");
            Program.ConsoleReader(linkedListSample);

            Console.WriteLine("Dynamic List:");
            Console.WriteLine("Sum: {0}", linkedListSample.Sum());
            Console.WriteLine("Avarage Sum: {0}", linkedListSample.AvarageSum());

            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            ICustumList<int> staticListSample = new StaticList<int>();

            Console.WriteLine();
            Console.WriteLine("Numbers for Static List:");
            Console.WriteLine("(Until u enter empty line or invalid format for a number)");
            Program.ConsoleReader(staticListSample);

            Console.WriteLine("Static List:");
            Console.WriteLine("Sum: {0}", staticListSample.Sum());
            Console.WriteLine("Avarage Sum: {0}", staticListSample.AvarageSum());

        }
    }
}
