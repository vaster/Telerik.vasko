using System;

    class ExchangeToPPlusKminus1
    {
        static void Main()
        {
            int p=0;
            int q=0;
            uint number=0;
            int k=0;
            uint[] numberInBits = new uint[32];
            int counter = 0;
            uint temp=0;
            
            int keepP;

            Console.Write("Enter int. number:");
            number = uint.Parse(Console.ReadLine());

            Console.Write("Enter position of the first bit to be exchanged:");
            p = int.Parse(Console.ReadLine());

            Console.Write("Enter position the first bit to be exchaged with:");
            q = int.Parse(Console.ReadLine());

            Console.Write("Enter how many bits to be exchanged(by condition (p,p+1..p+k-1)): k =");
            k = int.Parse(Console.ReadLine());

           
           
            for (counter = 0; counter <= 31; counter++)
            {
                
                numberInBits[counter] = number % 2;
                number = number / 2;
            }
            keepP = p;
            for (; p <=keepP + k - 1;p++,q++ )
            {
                temp = numberInBits[p];
                numberInBits[p] = numberInBits[q];
                numberInBits[q] = temp;
            }
            for (counter = 31; counter >= 0; counter--)
            {
                Console.Write("{0}",numberInBits[counter]);
            }
               
        }
    }

