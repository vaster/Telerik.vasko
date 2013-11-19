using System;


class MultipleTasks
{
    static char[] ReverseTheNumber(decimal reversIt)
    {

        char[] reversed = reversIt.ToString().ToCharArray();
        Array.Reverse(reversed);

        return reversed;
    }
    /*_____________________________________________________________*/
    static decimal CalcAverage(int[] numbersToBeAveraged)
    {
        decimal sum = 0;
        for (int i = 0; i < numbersToBeAveraged.Length; i++)
        {
            sum = sum + numbersToBeAveraged[i];
        }

        return sum / numbersToBeAveraged.Length;
    }
    /*_____________________________________________________________*/
    static decimal CalcLinearEq(decimal a, decimal b)
    {
        decimal x;
        x = (-b) / a;
        return x;
    }
    /*_____________________________________________________________*/
    static void Main(string[] args)
    {
        int choice;


        Console.WriteLine("1.Reverse digits");
        Console.WriteLine("2.Calculate average of sequence");
        Console.WriteLine("3.Solve linear equ. a*x+b=0");

        Console.Write("Make a Choice:");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                {
                    decimal numberToRevers;
                    do
                    {
                        Console.Write("Enter a positive number to be reversed:");
                        numberToRevers = decimal.Parse(Console.ReadLine());
                    } while (numberToRevers < 0);

                    char[] reversed = ReverseTheNumber(numberToRevers);

                    Console.WriteLine("This are the reversed digits");
                    for (int i = 0; i < reversed.Length; i++)
                    {

                        Console.Write(reversed[i]);
                    }

                    break;
                }
            case 2:
                {
                    int length;
                    decimal average;
                    do
                    {

                        Console.Write("Enter how many numbers you want(can't be zero or less):");
                        length = int.Parse(Console.ReadLine());

                    } while (length <= 0);
                    ////////////////////////////////////////
                    int[] arrayForAverage = new int[length];
                    ////////////////////////////////////////
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write("array[{0}]=", i);
                        arrayForAverage[i] = int.Parse(Console.ReadLine());
                    }
                    average = CalcAverage(arrayForAverage);
                    Console.WriteLine("Average is {0}", average);
                    break;
                }
            case 3:
                {
                    decimal a;
                    decimal b;
                    decimal x;
                    do
                    {
                        Console.Write("enter number for a(cant be zero):");
                        a = decimal.Parse(Console.ReadLine());
                    } while (a == 0);
                    Console.Write("enter number for b(no restriction):");
                    b = decimal.Parse(Console.ReadLine());
                    x = CalcLinearEq(a,b);
                    Console.WriteLine("x equals {0}",x);


                    break;
                }
        }
    }
}

