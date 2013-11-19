using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IEnumerableExtMethod
{
    class Core
    {
        static void Main(string[] args)
        {
            double[] testArray = new double[] { 1, 2, 3, 4 };


            Console.WriteLine(testArray.Sum());
            Console.WriteLine(testArray.Product());
            Console.WriteLine(testArray.Min());
            Console.WriteLine(testArray.Max());
            Console.WriteLine(testArray.Avarage());

        }
    }
}
