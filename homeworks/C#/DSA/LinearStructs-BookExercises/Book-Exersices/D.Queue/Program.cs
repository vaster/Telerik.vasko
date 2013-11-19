using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Queue
{
    class Program
    {
        /*
         * Implement the ADT queue as dynamic linked list. 
         * Use generics (LinkedQueue<T>) to allow storing different data types in the queue.
        */

        static void Main(string[] args)
        {
            ILinkedQueue<int> sample = new LinkedQueue<int>();

            sample.Enqueue(1);
            sample.Enqueue(2);
            sample.Enqueue(3);

            int[] sampleAsArray = sample.ToArray();

            Console.WriteLine("Queue as array:");
            for (int index = 0; index < sampleAsArray.Length; index++)
            {
                Console.WriteLine(sampleAsArray[index]);
            }

            Console.WriteLine("Dequeue + Peek");
            Console.WriteLine(sample.Dequeue() + " Dequeue");
            Console.WriteLine(sample.Dequeue() + " Dequeue");
            Console.WriteLine(sample.Peek() + " Peek");
            Console.WriteLine(sample.Dequeue() + " Dequeue");

            sample.Enqueue(4);
            Console.WriteLine("Does Contains 4? " + sample.Contains(4));

            sample.Enqueue(5);
            sample.Enqueue(6);

            sample.Clear();
            Console.WriteLine("Count after clear: " + sample.Count);
            // Console.WriteLine(sample.Dequeue()); // exception expected


        }
    }
}
