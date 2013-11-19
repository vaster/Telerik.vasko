using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SequenceByPatternUsingQueue
{
    /*
        We are given the following sequence:
     
        S0 = N;
        S1 = S0 + 1;
        S2 = 2*S0 + 1;
        S3 = S0 + 2;
        S4 = S1 + 1;
        S5 = 2*S1 + 1;
        S6 = S1 + 2;
        ...
     
        Using the Queue<T> class write a program to print its first 50 members for given N.
    */

    public class Program
    {
        const int MEMBERS_COUNT = 50;

        static void Main(string[] args)
        {

            Queue<int> sample = new Queue<int>();

            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            int baseElement = 0;
            int addOneIndex = 1;
            int multiplyIndex = 2;
            int addTwoIndex = 3;
            int copy = 0;
            int cycle = 1;
            for (int index = 0; index < Program.MEMBERS_COUNT; index++)
            {
               
                if (index == 0)
                {
                    sample.Enqueue(n);
                    baseElement = sample.Peek();
                    Console.WriteLine(sample.Dequeue());
                }
                else
                {
                    if (index == addOneIndex)
                    {
                        sample.Enqueue(baseElement + 1);
                        if (index % 3 == 0)
                        {
                            copy = sample.Peek();
                        }
                        addOneIndex = addOneIndex + 3;
                        Console.WriteLine(sample.Dequeue());
                    }

                    if (index == multiplyIndex)
                    {
                        
                        sample.Enqueue(2 * baseElement + 1);
                        if (index % 6 == 0)
                        {
                            copy = sample.Peek();
                        }
                        multiplyIndex = multiplyIndex + 3;
                        Console.WriteLine(sample.Dequeue());
                    }

                    if (index == addTwoIndex)
                    {
                        sample.Enqueue(baseElement + 2);

                        if (index % 9 == 0)
                        {
                            copy = sample.Peek();
                        }
                        addTwoIndex = addTwoIndex + 3;
                        Console.WriteLine(sample.Dequeue());
                        baseElement = copy;
                    }
                }
            }

            /*Console.WriteLine("_____");
            foreach (var element in sample)
            {
                Console.WriteLine(element);
            }*/
        }
    }
}
