using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.ReverseWithStack;

namespace C.CustomStack
{
    /*
     * Write a program that reads N integers from the console and reverses them using a stack.
     * Use the Stack<int> class.
    */

    public class Program
    {
        /// <summary>
        /// Read from the console untill an invalid number is entered.
        /// </summary>
        /// <param name="sampleStack">ICustomList to store the numbers.</param>
        static void ConsoleReader(ICustomStack<int> sampleStack)
        {
            int input = 0;
            bool toProceed = true;

            while (toProceed)
            {
                toProceed = int.TryParse(Console.ReadLine(), out input);
                if (toProceed)
                {
                    sampleStack.Push(input);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Numbers for Static Stack:");
            Console.WriteLine("(Until u enter empty line or invalid format for a number)");

            StaticStack<int> sampleStack = new StaticStack<int>();

            Program.ConsoleReader(sampleStack);
            Console.WriteLine("Result:");
            while (sampleStack.Count > 0)
            {
                Console.WriteLine(sampleStack.Pop());
            }

            Console.WriteLine();
            Console.WriteLine("Numbers for Dynamic Stack:");
            Console.WriteLine("(Until u enter empty line or invalid format for a number)");

            DynamicStack<int> sampleDynamicStack = new DynamicStack<int>();

            Program.ConsoleReader(sampleDynamicStack);
            Console.WriteLine("Result:");

            while (sampleDynamicStack.Count > 0)
            {
                Console.WriteLine(sampleDynamicStack.Pop());
            }
          
        }
    }
}
