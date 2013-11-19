using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class DifferentNumberRepresentations
    {
        static void Main(string[] args)
        {

            string number;

            Console.Write("Enter number:");
            number = Console.ReadLine();
            Console.WriteLine("{0,15:X}", Convert.ToInt32(number));
            Console.WriteLine("{0,15:D}", Convert.ToInt32(number));
            Console.WriteLine("{0,15:P0}", Convert.ToDouble(number));
            Console.WriteLine("{0,15:E3}", Convert.ToDouble(number));
        }
    }

