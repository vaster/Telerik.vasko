using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<string, int> sample = new HashTable<string, int>();

            sample.Add("1151", 1);
            sample.Add("1", 23);
            sample.Add("1", 2);
            sample.Add("19", 4);
            sample.Add("3", 3);
            sample.Add("19", 3);
            sample.Add("3", 15);
            sample.Add("2", 15);
            sample.Add("7", 15);
            sample.Add("9", 15);
            sample.Add("-11", 15);
            sample.Add("-33", 15);
            sample.Add("9", 15);
            sample.Add("0", 15);
            sample.Add("101", 15);
            sample.Add("102", 15);
            sample.Add("103", 15);
            sample.Add("104", 15);
            sample.Add("105", 15);



            foreach (LinkedList<KeyValuePair<string,int>> item in sample)
            {
                Console.WriteLine("Key:" + item.First.Value.Key);
                foreach (var element in item)
                {
                    Console.WriteLine("   Values:" + element.Value);
                }
            }

            Console.WriteLine("________________________________________");
            Console.WriteLine("Values for Key of 3:");
            int[] founded = sample.Find("3");
            for (int i = 0; i < founded.Length; i++)
            {
                Console.WriteLine("    Values:" +founded[i]);
            }

            Console.WriteLine("________________________________________");
            Console.WriteLine("Remove Key of 19:");
            sample.Remove("19");

            foreach (LinkedList<KeyValuePair<string, int>> item in sample)
            {
                Console.WriteLine("Key:" + item.First.Value.Key);
                foreach (var element in item)
                {
                    Console.WriteLine("   Values:" + element.Value);
                }
            }

            Console.WriteLine("________________________________________");
            Console.WriteLine("List of keys:");
            string[] keys = sample.Keys();
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }

            sample.Clear();
            Console.WriteLine("________________________________________");
            Console.WriteLine("After clear Count = " + sample.Count);
        }
    }
}
