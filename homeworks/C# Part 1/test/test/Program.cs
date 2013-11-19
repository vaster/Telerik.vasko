using System;

class Program
{
    static void Main()
    {
        ushort a = 1500;
        ushort b = 4;
         for (int i = 0; i < 10000; i++)
			{
			 a = (ushort)(a*b);
             if (a > 10000)
             {
                 a++;
             }
             if (a < 15000)
             {
                 a--;
             }
             if (a > 20000)
             {
                 break;
             }
			}
         Console.WriteLine(a);
    }
}

