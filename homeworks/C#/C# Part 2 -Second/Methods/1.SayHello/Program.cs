using System;
using System.Collections.Generic;

namespace _1.SayHello
{
    public class Program
    {
        public static string SayHelloAsString(string name)
        {
            return "Hello, " + name;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine(Program.SayHelloAsString(name));
        }
    }
}
