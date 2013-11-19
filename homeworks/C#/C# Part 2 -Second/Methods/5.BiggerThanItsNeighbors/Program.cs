using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BiggerThanItsNeighbors
{
    public class Program
    {
        public static bool BiggerThanNeighbors(int[] array, int index)
        {
            if (index >= array.Length || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format("No such index!"));
            }

            if (array.Length == 1)
            {
                return true;
            }

            if ((index - 1 < 0 || array[index - 1] < array[index])
                && index + 1 >= array.Length || array[index + 1] < array[index])
            {
                return true;
            }

            return false;

        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 2, 3 };

            int index = 2;

            bool result = Program.BiggerThanNeighbors(array,index);

            Console.WriteLine(result);
        }
    }
}
