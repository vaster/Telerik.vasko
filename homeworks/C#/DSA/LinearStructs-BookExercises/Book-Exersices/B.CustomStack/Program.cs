using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// some problem with the namespaces has appear.
using C.CustomStack.C.CustomStack;

namespace C.CustomStack
{
    /*
     * Implement the ADT stack as auto-resizable array.
     * Resize the capacity on demand (when no space is available to add / insert a new element).

     */
    class Program
    {
        static void Main(string[] args)
        {
            ICustomStack<int> sample = new CustomStack<int>();

            sample.Push(1);
            sample.Push(2);
            sample.Push(3);

            Console.WriteLine(sample.Pop() + " pop");
            Console.WriteLine(sample.Pop() + " pop");
            Console.WriteLine(sample.Peek() + " peek");
            Console.WriteLine(sample.Pop() + " pop");
        }
    }
}
