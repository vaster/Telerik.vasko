using System;
using Wintellect.PowerCollections;

namespace _1.PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
          Heap<int> sampleHeap = new Heap<int>();

            sampleHeap.Enqueue(1);
            sampleHeap.Enqueue(2);
            sampleHeap.Enqueue(3);
            sampleHeap.Enqueue(4);
            sampleHeap.Enqueue(5);
            sampleHeap.Enqueue(3);


            Console.WriteLine(sampleHeap.Dequeue());
            Console.WriteLine(sampleHeap.Dequeue());
        }
    }
}
