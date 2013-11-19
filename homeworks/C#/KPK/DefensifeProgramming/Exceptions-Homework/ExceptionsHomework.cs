using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        List<T> result = new List<T>();

        // added exception for invalid start index.
        if (startIndex < 0 || startIndex >= arr.Length)
        {
            throw new ArgumentOutOfRangeException(String.Format("Invalid 'startIndex'! 'startIndex' must be in range of ({0} - {1})! 'startIndex' = {2}.", 0, arr.Length - 1, startIndex));
        }
        // add exception for invalid count.
        if (count < 0 || count + startIndex > arr.Length)
        {
            throw new ArgumentOutOfRangeException(String.Format("Invalid count of extraction! Count must be in range of ({0} - {1})! 'count' = {2}", 0, arr.Length, count));
        }

        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (count > str.Length)
        {
            // implemented proper exception
            throw new ArgumentOutOfRangeException(String.Format("Invalid count of extraction! Count can't be bigger than {0}! 'count' = {1}", str.Length, count));
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                // implemented proper exception
                throw new ArgumentException(String.Format("{0} is not prime!",number));
            }
        }
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 1)); // original value = 100;

        try
        {
            CheckPrime(23);
            Console.WriteLine("23 is prime.");
        }
        catch (Exception ex)
        {
            // calling the inner exception to the Console.
            Console.WriteLine("Try another number.\n" + ex);
        }

        try
        {
            CheckPrime(31); // original value = 33
            Console.WriteLine("31 is prime.");
        }
        catch (Exception ex)
        {
            // calling the inner exception to the Console.
            Console.WriteLine("Try another number.\n" + ex);
        }

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
