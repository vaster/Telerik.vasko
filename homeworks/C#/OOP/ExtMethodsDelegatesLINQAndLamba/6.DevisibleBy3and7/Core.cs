using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
 
*/
namespace _6.DevisibleBy3and7
{
    class Core
    {
        static void Main(string[] args)
        {

            List<int>testArray = new List<int> { 1, 2, 3, 7, 11, 14, 12, 21};

            var findNumbersByPaternLambda = 
                testArray.FindAll((i) =>
            {
                return i % 3 == 0 || i % 7 == 0;
            });
            Console.WriteLine();
            Console.WriteLine("By Lambda");
            foreach (var item in findNumbersByPaternLambda)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("By LINQ");
            var findNumberNyPaternLINQ =
                from num in testArray
                where num % 3 == 0 || num % 7 == 0
                select num;

            foreach (var item in findNumberNyPaternLINQ)
            {
                Console.WriteLine(item);
            }
        }
    }
}
