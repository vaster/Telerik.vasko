using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.CustomLinkedList
{

    /*
     * Implement the data structure linked list. 
     * Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).
     * Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
    */
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<int> sample = new CustomLinkedList<int>();

            sample.Add(6);
            sample.Add(1);
            sample.Add(2);
            sample.Add(3);
            sample.Add(4);
            sample.Add(5);


            Console.WriteLine("Test interation:");
            ListItem<int> head = sample.FirstElement;
            while (head != null)
            {
                Console.WriteLine(head.Value);
                head = head.NextItem;
            }

            Console.WriteLine("Test indexer at 4:");
            Console.WriteLine(sample[4].Value);

            Console.WriteLine("Test insert 5555555:");
            sample.Insert(3, 5555555);
            head = sample.FirstElement;
            while (head != null)
            {
                Console.WriteLine(head.Value);
                head = head.NextItem;
            }

            Console.WriteLine("Test Contains for 5555555: {0}", sample.Contains(5555555));

            Console.WriteLine("Test Remove for 5555555:");
            sample.Remove(5555555);
            head = sample.FirstElement;
            while (head != null)
            {
                Console.WriteLine(head.Value);
                head = head.NextItem;
            }

            Console.WriteLine("Test RemoveAt index 1");
            sample.RemoveAt(1);
            head = sample.FirstElement;
            while (head != null)
            {
                Console.WriteLine(head.Value);
                head = head.NextItem;
            }
 
            sample.Clear();
            Console.WriteLine("Count of elements after .Clear() :{0}", sample.Count);
            head = sample.FirstElement;
            while (head != null)
            {
                Console.WriteLine(head.Value);
                head = head.NextItem;
            }

           
        }
    }
}
