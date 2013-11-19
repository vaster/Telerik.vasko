using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Easiest way is to think about a possible scenario for the code and following it by the rules of quality code.
 * Some styleCop refactor too.
 */
namespace RefactoredNamesCSharp
{
    public class ApplicationInput
    {
        private const int MAX_COUNT = 6;

        public static void InputReader()
        {
            ApplicationInput.InputPrinter windowConsole = new ApplicationInput.InputPrinter();
            windowConsole.BoolenValuePrinter(true);
        }

        private class InputPrinter
        {
            public void BoolenValuePrinter(bool boolStatement)
            {
                string boolStatementToString = boolStatement.ToString();
                Console.WriteLine(boolStatementToString);
            }
        }
    }
}
