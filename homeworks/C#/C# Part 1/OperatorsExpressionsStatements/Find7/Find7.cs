using System;

    class Find7
    {
        static void Main()
        {
            int[] array = new int[200];
            int number;
            int rest;
            int counter=0;
            int flag = 0;
            Console.Write("Enter number:");
            number = int.Parse(Console.ReadLine());
            
            do
            {
                if(flag>0)
                number = number / 10;
                rest = number % 10;
                flag++;
                array[counter] = rest;
                counter++; 
            }while(number !=0);

            if (array[2] == 7 || array[2] == -7)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            
            
        }
    }

