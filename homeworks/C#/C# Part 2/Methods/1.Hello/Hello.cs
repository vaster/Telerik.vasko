using System;

class Hello
{
    static void PrintHelloName()
    {
        string name = Console.ReadLine();

        Console.WriteLine("Hello, {0}!", name);
    }

    ///////////////////////////////////////////

    static void Main(string[] args)
    {
        PrintHelloName();
    }
}

