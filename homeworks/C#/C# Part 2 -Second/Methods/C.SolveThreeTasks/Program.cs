using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.SolveThreeTasks
{
    public class Program
    {
        public static decimal Reverse(decimal number)
        {
            string numberAsString = number.ToString();

            StringBuilder result = new StringBuilder();

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                result.Append(numberAsString[i]);
            }

            return Convert.ToDecimal(result.ToString());
        }

        public static decimal AvarageSum(ICollection<int> sequence)
        {
            int avgSum = 0;

            foreach (var number in sequence)
            {
                avgSum = avgSum + number;
            }

            return avgSum / sequence.Count;
        }

        public static decimal LinearEqSolver(int a, int b)
        {
            decimal x = b / a;

            return x;
        }

        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("1.Reverse Digits.");
            Console.WriteLine("2.Avarage sum.");
            Console.WriteLine("3.Linear Eq.");
            Console.WriteLine("4.Exit.");
            Console.WriteLine();
            Console.Write("Make choice(1,2,3 or 4):");
        }

        public static void FlowLogicForReverse()
        {
            decimal number = 0;
            do
            {
                Console.Write("Enter positive number:");
                number = decimal.Parse(Console.ReadLine());
            } while (number < 0);

            decimal result = Program.Reverse(number);

            Console.WriteLine("Revers:" + result);
        }

        public static void FlowLogicForAvgSum()
        {
            bool toProcceed = false;
            int currNumber = 0;
            List<int> sequnce = new List<int>();

            Console.WriteLine("Enter numbers untill u press 'Enter'(Empty Sequnce not allowed)");
            do
            {
                Console.Write("number:");
                toProcceed = int.TryParse(Console.ReadLine(), out currNumber);
                if (toProcceed)
                {
                    sequnce.Add(currNumber);
                }
            } while (toProcceed || sequnce.Count == 0);

            Console.WriteLine(String.Join(",", sequnce));
            Console.WriteLine("Avg sum: " + Program.AvarageSum(sequnce));
        }

        public static void FLowLogicForLinearEq()
        {
            int a = 0;
            do
            {
                Console.Write("Enter A( 0 is not allowed):");
                a = int.Parse(Console.ReadLine());
            } while (a == 0);

            int b = 0;
            Console.Write("Enter b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("x = " + Program.LinearEqSolver(a, b));
        }

        public static void CommandExecutor(int choice)
        {
            Console.Clear();
            switch (choice)
            {

                case 1:
                    Program.FlowLogicForReverse();
                    break;
                case 2:
                    Program.FlowLogicForAvgSum();
                    break;
                case 3:
                    Program.FLowLogicForLinearEq();
                    break;
            }
        }

        static void Main(string[] args)
        {
            const int END = 4;

            int choice = 0;

            do
            {
                Program.Menu();

                choice = int.Parse(Console.ReadLine());

                Program.CommandExecutor(choice);

            } while (choice != END);
        }
    }
}
