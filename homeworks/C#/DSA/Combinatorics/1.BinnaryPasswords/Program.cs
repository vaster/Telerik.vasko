using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.BinnaryPasswords
{
    public class Program
    {
        public static int Count = 0;

        public static void PasswordCombining(char[] input, int index, bool[] allow)
        {
            if (!input.Contains('*'))
            {
                Program.Count++;
                return;
            }
            else
            {
                if (input[index] == '*')
                {
                    for (int i = 0; i <= 1; i++)
                    {
                        allow[index] = true;
                        input[index] = i.ToString().ToCharArray()[0];
                        Program.PasswordCombining(input, index + 1, allow);
                        if (allow[index])
                        {
                            input[index] = '*';
                        }
                    }
                }
                else
                {
                    Program.PasswordCombining(input, index + 1, allow);
                }
            }
        }

        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            //////////////////////////////////////////////////////////
            bool[] allow = new bool[input.Length];////////////////////
            Program.PasswordCombining(input, 0, allow);  // Recursion/
            Console.WriteLine(Program.Count);/////////////////////////
            //////////////////////////////////////////////////////////

            // formula for fast implementation
            //            ||
            //           \\//
            /*            \/
            int starts = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    starts++;
                }
            }

            Console.WriteLine(Math.Pow(2, input.Length)/ Math.Pow(2, (input.Length - starts)));
            */
        }
    }
}
