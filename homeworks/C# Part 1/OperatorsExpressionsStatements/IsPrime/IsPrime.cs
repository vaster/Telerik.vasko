using System;

    class IsPrime
    {
        static void Main()
        {
            int prime;
            int counter;
            int flag = 0;
            int[] array = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
           
          
           do
           {
            Console.WriteLine("Enter a positive int. number:");
            prime = int.Parse(Console.ReadLine());
           }while(prime <0);



           for (counter = 0; counter < array.Length; counter++)
           {
               if (prime == array[counter])
               {
                   Console.WriteLine("{0} is prime", prime);
               }
               else
                   flag++;

           }
           if (flag == array.Length)
               Console.WriteLine("{0} is not prime", prime);
             
        }
       
    }

