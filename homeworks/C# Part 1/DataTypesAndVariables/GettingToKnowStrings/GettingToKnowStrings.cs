using System;

    class GettingToKnowStrings
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            string final;
            object helloWorld = hello + " " + world;
            final = (string)helloWorld;
            Console.WriteLine(final);
        }
    }

