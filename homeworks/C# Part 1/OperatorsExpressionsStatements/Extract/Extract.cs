using System;

    class Extract
    {
        static void Main()
        {
            int i;
            int b;
            int result;

            Console.Write("Enter int. value:");
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter bit number to be extracted:");
            b = int.Parse(Console.ReadLine());

           
            b =(1 << b);
            result = i - b;
            Console.WriteLine("Result:{0}",result);
            
        }
    }

