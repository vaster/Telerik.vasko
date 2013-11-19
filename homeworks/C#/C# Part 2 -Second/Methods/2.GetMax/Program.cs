using System;
using System.Collections.Generic;

namespace _2.GetMax
{
    public class Program
    {
        public static int GetMax(int number, int otherNumber)
        {
            return (number > otherNumber) ? number : otherNumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers.");


            Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("B = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("C = ");
            int c = int.Parse(Console.ReadLine());

            int biggestFromAandB = Program.GetMax(a,b);

            int biggestOfThree = Program.GetMax(biggestFromAandB,c);

            Console.WriteLine("Numbers are " + a + ", " + b + ", " + c);
            Console.WriteLine("Biggest is : " + biggestOfThree);
        }
    }
}
