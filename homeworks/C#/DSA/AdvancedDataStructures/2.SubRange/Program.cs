using System;
using Wintellect.PowerCollections;
using System.Collections.Generic;
using System.Diagnostics;

namespace _2.SubRange
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedBag<ComparableKeyValuePair<string, int>> catalog =
                new OrderedBag<ComparableKeyValuePair<string, int>>();

            for (int i = 0; i < 25; i++)
            {
                ComparableKeyValuePair<string, int> item = new ComparableKeyValuePair<string, int>(i.ToString(), i);
                catalog.Add(item);
            }

            ComparableKeyValuePair<string, int> downRange = new ComparableKeyValuePair<string, int>("3", 3);
            ComparableKeyValuePair<string, int> upRange = new ComparableKeyValuePair<string, int>("23", 23);

            OrderedBag<ComparableKeyValuePair<string, int>>.View range = catalog.Range(downRange, true, upRange, true);
            Console.WriteLine("from 3");
            foreach (ComparableKeyValuePair<string, int> item in range)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("to 23");


            // Test for 500 000 products and 10 000 price searches.

            catalog =
                new OrderedBag<ComparableKeyValuePair<string, int>>();

            Stopwatch timer = new Stopwatch();

            timer.Start();

            for (int i = 0; i <= 500000; i++)
            {
                ComparableKeyValuePair<string, int> item = new ComparableKeyValuePair<string, int>(i.ToString(), i);
                catalog.Add(item);
            }
            Console.WriteLine("Adding 500 000 elements: " + timer.Elapsed.TotalSeconds + " sec");
           

            OrderedBag<ComparableKeyValuePair<string, int>>.View bigRange = null;

            ComparableKeyValuePair<string, int> from = new ComparableKeyValuePair<string, int>("400000", 400000);
            ComparableKeyValuePair<string, int> to = new ComparableKeyValuePair<string, int>("410000", 410000);

            timer.Reset();
            timer.Start();

            for (int i = 10000; i <= 400000; i = i + 20)
            {
                bigRange = catalog.Range(from, true, to, false);

                from = new ComparableKeyValuePair<string, int>((i - 20).ToString(), (i - 20));
                to = new ComparableKeyValuePair<string, int>(i.ToString(), i);
            }

            Console.WriteLine("10 000 searches (200 000 to 400 000):" + timer.Elapsed.TotalMilliseconds + " ms");

            timer.Stop();
        }
    }
}
