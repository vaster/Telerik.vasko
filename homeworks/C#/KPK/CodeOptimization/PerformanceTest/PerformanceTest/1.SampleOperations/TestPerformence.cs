using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SampleOperations
{
    class TestPerformence
    {
        static void Main(string[] args)
        {

            // The first calls of a specific types are The slowest becouse of the dynamic.
            //    It's slow on the first becouse this is when the compiler take an apropriate action on all dynamic objects and once its ready the transformation of
            //      dynamic is kept for the entire proccess no need to do it each time, only when we use different type and becouse of the generics probably makes a check
            //          each time did we changed the type we used for 'T' and if  its changed it makes the transformation of the dynamic again wich is slow proccess.

            PerformenceDiagnostic performencer = new PerformenceDiagnostic();
            /////////////////////////////////////////////////////////////////
            Calculation<int> calculatorInt = new Calculation<int>(1, 1);
            Calculation<long> calculatorLong = new Calculation<long>(1L, 1L);
            Calculation<double> calculatorDouble = new Calculation<double>(1D, 1D);
            Calculation<float> calculatorFloat = new Calculation<float>(1F, 1F);
            Calculation<decimal> calculatorDecimal = new Calculation<decimal>(1M, 1M);

            Console.Write("Integer".PadLeft(16));
            Console.Write("Long   ".PadLeft(13));
            Console.Write("Float  ".PadLeft(13));
            Console.Write("Double ".PadLeft(13));
            Console.Write("Decimal".PadLeft(13));
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Addition ".PadRight(10) +
                 performencer.CalculatePerformance(calculatorInt.AddTwoNumbers)  +
                 performencer.CalculatePerformance(calculatorLong.AddTwoNumbers).PadLeft(12) +
                 performencer.CalculatePerformance(calculatorFloat.AddTwoNumbers).PadLeft(13) + 
                 performencer.CalculatePerformance(calculatorDouble.AddTwoNumbers).PadLeft(13) +
                 performencer.CalculatePerformance(calculatorDecimal.AddTwoNumbers).PadLeft(13)
                );

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Substract ".PadRight(10) +
                 performencer.CalculatePerformance(calculatorInt.SubstractTwoNumbers) +
                 performencer.CalculatePerformance(calculatorLong.SubstractTwoNumbers).PadLeft(12) +
                 performencer.CalculatePerformance(calculatorFloat.SubstractTwoNumbers).PadLeft(12) +
                 performencer.CalculatePerformance(calculatorDouble.SubstractTwoNumbers).PadLeft(14) +
                 performencer.CalculatePerformance(calculatorDecimal.SubstractTwoNumbers).PadLeft(13)
                );

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Increment ".PadRight(10) +
                 performencer.CalculatePerformance(calculatorInt.Increment) +
                 performencer.CalculatePerformance(calculatorLong.Increment).PadLeft(12) +
                 performencer.CalculatePerformance(calculatorFloat.Increment).PadLeft(12) +
                 performencer.CalculatePerformance(calculatorDouble.Increment).PadLeft(14) +
                 performencer.CalculatePerformance(calculatorDecimal.Increment).PadLeft(13)
                );

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Multiply ".PadRight(10) +
                 performencer.CalculatePerformance(calculatorInt.MultiplyTwoNumbers) +
                 performencer.CalculatePerformance(calculatorLong.MultiplyTwoNumbers).PadLeft(12) +
                 performencer.CalculatePerformance(calculatorFloat.MultiplyTwoNumbers).PadLeft(12) +
                 performencer.CalculatePerformance(calculatorDouble.MultiplyTwoNumbers).PadLeft(14) +
                 performencer.CalculatePerformance(calculatorDecimal.MultiplyTwoNumbers).PadLeft(13)
                );

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Devide ".PadRight(10) +
                 performencer.CalculatePerformance(calculatorInt.DivideTwoNumbers) +
                 performencer.CalculatePerformance(calculatorLong.DivideTwoNumbers).PadLeft(12) +
                 performencer.CalculatePerformance(calculatorFloat.DivideTwoNumbers).PadLeft(12) +
                 performencer.CalculatePerformance(calculatorDouble.DivideTwoNumbers).PadLeft(14) +
                 performencer.CalculatePerformance(calculatorDecimal.DivideTwoNumbers).PadLeft(13)
                );
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("All in milliseconds.");
        }
    }
}
