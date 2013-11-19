using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Calculator
{
    public static class Calculator<T>
    {
        public static T MinimalSum(ICollection<T> sequence)
        {
            T result = default(T);

            foreach (var number in sequence)
            {
                if ((dynamic)number < 0)
                {
                    result = (dynamic)result + number;
                }
            }

            return result;
        }

        public static T MaximalSum(ICollection<T> sequence)
        {
            T result = default(T);

            foreach (var number in sequence)
            {
                if ((dynamic)number > 0)
                {
                    result = (dynamic)result + number;
                }
            }

            return result;
        }

        public static double AvarageSum(ICollection<T> sequence)
        {
            double result = 0;

            foreach (var number in sequence)
            {
                result = (dynamic)result + number;
            }

            return result / sequence.Count;
        }

        public static T Product(ICollection<int> sequence)
        {
            T result = (dynamic)1;

            foreach (var number in sequence)
            {
                result = (dynamic)result * number;
            }

            return result;
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 1, 2, 3, -4, 5 };
            Console.WriteLine(String.Join(",", sequence));
            Console.WriteLine("Maximal Sum: " + Calculator<int>.MaximalSum(sequence));
            Console.WriteLine("Minima Sum: " + Calculator<int>.MinimalSum(sequence));
            Console.WriteLine("Avg sum: " + Calculator<int>.AvarageSum(sequence));
            Console.WriteLine("Product: " + Calculator<int>.Product(sequence));
        }
    }
}
