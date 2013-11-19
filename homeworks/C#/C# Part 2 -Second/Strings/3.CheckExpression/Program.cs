using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CheckExpression
{
    internal class Program
    {
        /*
            Write a program to check if in a given expression the brackets are put correctly.
            Example of correct expression: ((a+b)/5-d).
            Example of incorrect expression: )(a+b)).
         */

        public static bool CheckExpression(string expression)
        {
            const char OPENING_BRACKET = '(';
            const char CLOSING_BRACKET = ')';

            int openingBracketsCount = 0;
            int closingBracketsCount = 0;

            foreach (var expressionSymbol in expression)
            {
                if (expressionSymbol == OPENING_BRACKET)
                {
                    openingBracketsCount++;
                }
                if (expressionSymbol == CLOSING_BRACKET)
                {
                    closingBracketsCount++;
                }

                if (closingBracketsCount > openingBracketsCount)
                {
                    return false;
                }
            }
            if (openingBracketsCount != closingBracketsCount)
            {
                return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            string trueExpression = "((a+b)/5-d)";
            string falseExpression = ")(a+b))";

            Console.WriteLine(trueExpression + " -> " + Program.CheckExpression(trueExpression));
            Console.WriteLine(falseExpression + " -> " + Program.CheckExpression(falseExpression));
        }
    }
}
