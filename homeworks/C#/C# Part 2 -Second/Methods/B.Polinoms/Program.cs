using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace B.Polinoms
{
    public class Program
    {
        public static void MakePolinomUndestandableToComputer(string a, string b, int[] computerPolinomA, int[] computerPolinomB)
        {
            const int superScript2 = 178; // ²
            const int superScript3 = 179; // ³

            string[] membersOfA = a.Split(new char[] { '+', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] membersOfB = b.Split(new char[] { '+', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int length = Program.GetBiggestPower(a,b);

            computerPolinomA = new int[length];
            computerPolinomB = new int[length];

            for (int i = 0; i < length; i++)
            {
                
            }


        }

        // works only for ² ³ 
        private static int GetBiggestPower(string a, string b)
        {
            if (a.Contains("³"))
            {
                return 3;
            }
            if (b.Contains("³"))
            {
                return 3;
            }
            if (a.Contains("²"))
            {
                return 2;
            }
            if (b.Contains("²"))
            {
                return 2;
            }

            return 1;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1252);

            string a = "x² + 5";
            string b = "x³ + 3x² + 5";

            int[] computerPolinomA = null;
            int[] computerPolinomB = null;

            Program.MakePolinomUndestandableToComputer(a, b, computerPolinomA, computerPolinomB);

        }
    }
}
