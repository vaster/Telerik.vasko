using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _1.SampleOperations
{
    public class PerformenceDiagnostic
    {
        public delegate void CalculationMethod();

        private Stopwatch timer;

        public PerformenceDiagnostic()
        {
            timer = new Stopwatch();
        }

        public string CalculatePerformance(CalculationMethod function)
        {
            timer.Reset();
            timer.Start();
            function();

            return timer.Elapsed.TotalMilliseconds.ToString();
        }
    }
}
