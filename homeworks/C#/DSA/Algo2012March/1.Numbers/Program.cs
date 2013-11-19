using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Numbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(' ');

            int A = int.Parse(inputData[0]);
            int B = int.Parse(inputData[1]);
            int P = int.Parse(inputData[2]);
            int Q = int.Parse(inputData[3]);

            int count = 0;


            for (int i = A; i <= B; i++)
            {
                if (i % P == Q)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
