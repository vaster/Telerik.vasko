using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list,
finding element by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.
Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
 Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. You may need to add a generic constraints for the type T.

 */
namespace _2.Generic
{
    class Core
    {
        static void Main(string[] args)
        {
            GenericList<object> processingGenericList = new GenericList<object>();
            object[] list;


            //Testing

            processingGenericList.AddElement(0);
            processingGenericList.AddElement(1);
            processingGenericList.AddElement(2);
            processingGenericList.InsertElement(15,8);
            processingGenericList.AddElement(3);
            processingGenericList.AddElement(4);
            processingGenericList.AddElement(5);
            processingGenericList.AddElement(-1);
            processingGenericList.AddElement(7);
            processingGenericList.AddElement(8);
               
            list = processingGenericList.returnList();
            for (int i = 0; i < list.Length; i++)
            {
               Console.WriteLine(list[i]);
            }

            Console.WriteLine("Min is: " + processingGenericList.Min());
            Console.WriteLine("Max is: " + processingGenericList.Max());
        }
    }
}
