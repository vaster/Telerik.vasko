using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.HashSet
{
    public class Program
    {
        static void Main(string[] args)
        {
            IHashSet<int> sampleOne = new HashSet<int>();
           
            sampleOne.Add(1);
            sampleOne.Add(1);
            sampleOne.Add(2);
            sampleOne.Add(3);
            sampleOne.Add(4);
            sampleOne.Add(5);
            sampleOne.Add(6);
            sampleOne.Add(7);
            sampleOne.Add(8);
            sampleOne.Add(9);

             IHashSet<int> sampleTwo = new HashSet<int>();

            sampleTwo.Add(1);
            sampleTwo.Add(2);
            sampleTwo.Add(9);
            sampleTwo.Add(100);


            Console.WriteLine("sampleOne:");
            foreach (var item in sampleOne)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("sampleTwo:");
            foreach (var item in sampleTwo)
            {
                Console.WriteLine(item);
            }


            IHashSet<int> intersected = sampleOne.Intersect(sampleTwo);

            Console.WriteLine("Intesected of sampleOne and sampleTwo:");
            foreach (var item in intersected)
            {
                Console.WriteLine(item);
            }

            IHashSet<int> union = sampleOne.Union(sampleTwo);

            Console.WriteLine("Union of sampleOne and sampleTwo:");
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }

            int founded = sampleOne.Find(1);
            Console.WriteLine("Look for '1':" + founded);

            Console.WriteLine("Count:" + sampleOne.Count);
            sampleOne.Remove(3);
            sampleOne.Clear();
            Console.WriteLine("Count after clear:" + sampleOne.Count);

        }
    }
}
