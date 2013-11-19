using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AdvenceOperations
{
    class TestPerformance
    {
        static void Main(string[] args)
        {

            // using the same class of PerformenceDiagnostic from the onother project
            _1.SampleOperations.PerformenceDiagnostic performencer = new _1.SampleOperations.PerformenceDiagnostic();
            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            Calculation<float> calculatorFloat = new Calculation<float>(1F);

            Console.WriteLine("____________________");
            Console.WriteLine("Float Statistic.");
            Console.WriteLine();
            Console.Write("Square root: ");
            Console.WriteLine(performencer.CalculatePerformance(calculatorFloat.CalculateSquareRoot));
            Console.Write("Natural Logarithm: ");
            Console.WriteLine(performencer.CalculatePerformance(calculatorFloat.CalculateNaturalLogarithm));
            Console.Write("Sin: ");
            Console.WriteLine(performencer.CalculatePerformance(calculatorFloat.CalculateSinus));

            Calculation<double> calculatorDouble = new Calculation<double>(1D);

            Console.WriteLine("____________________");
            Console.WriteLine("Double Statistic.");
            Console.WriteLine();
            Console.Write("Square root: ");
            Console.WriteLine(performencer.CalculatePerformance(calculatorDouble.CalculateSquareRoot));
            Console.Write("Natural Logarithm: ");                         
            Console.WriteLine(performencer.CalculatePerformance(calculatorDouble.CalculateNaturalLogarithm));
            Console.Write("Sin: ");                                       
            Console.WriteLine(performencer.CalculatePerformance(calculatorDouble.CalculateSinus));

            /*      Decimal Value can't be use in System.Math class. Only Double, Float values!
            Calculation<decimal> calculatorDecimal = new Calculation<decimal>(1M);

            Console.WriteLine("____________________");
            Console.WriteLine("Decimal Statistic.");
            Console.WriteLine();
            Console.Write("Square root: ");
            Console.WriteLine(performencer.CalculatePerformance(calculatorDecimal.CalculateSquareRoot));
            Console.Write("Natural Logarithm: ");                      
            Console.WriteLine(performencer.CalculatePerformance(calculatorDecimal.CalculateNaturalLogarithm));
            Console.Write("Sin: ");                                   
            Console.WriteLine(performencer.CalculatePerformance(calculatorDecimal.CalculateSinus));
            */


        }
    }
}
