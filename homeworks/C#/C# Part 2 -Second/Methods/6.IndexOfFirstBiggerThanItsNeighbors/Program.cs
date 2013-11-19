using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5.BiggerThanItsNeighbors;

namespace _6.IndexOfFirstBiggerThanItsNeighbors
{
    public class Program
    {
        public static int IndexOfBggerThanNeighbors(int[] array)
        {
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                    // reference to project 5's method
                if (_5.BiggerThanItsNeighbors.Program.BiggerThanNeighbors(array, i))
                {
                    return i;
                }
            }

            return index;
        }
        static void Main(string[] args)
        {
            int[] array = {1,2,3,100,99,-100 };

            int index = Program.IndexOfBggerThanNeighbors(array);

            Console.WriteLine(String.Join(",",array));
            Console.WriteLine("Condition is ok for number at index: " + index);
        }
    }
}
