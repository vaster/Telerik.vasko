using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.ShortestSequenceOfMoves
{
    /*
     * * We are given numbers N and M and the following operations:
        N = N+1
        N = N+2
        N = N*2
        Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M. Hint: use a queue.
     * 
        Example: N = 5, M = 16
        Sequence: 5 -> 7 -> 8 -> 16

     */

    public class Program
    {
        static int AddOne(int result)
        {
            result = result + 1;

            return result;
        }

        static int AddTwo(int result)
        {
            result = result + 2;

            return result;
        }

        static int MultiplyByTwo(int result)
        {
            result = result * 2;

            return result;

        }

        static void Main(string[] args)
        {

            Console.Write("N:");
            int n = int.Parse(Console.ReadLine());

            Console.Write("M:");
            int m = int.Parse(Console.ReadLine());

            Queue<int> sequnce = new Queue<int>();

            int reminder = 0;
            int holePart = 0;
            bool toStopMultiply = true;
            bool toAddLastMove = true;

            // not working correctly, hole idea of implementation went wrong ...
            // Not the worst count of moves, but not the best for sure.
            if (n < m)
            {
                do
                {
                    reminder = m % n;
                    holePart = m / n;
                    if (holePart * n <= m && holePart >= 1 && toStopMultiply)
                    {
                        toAddLastMove = true;
                        sequnce.Enqueue(n);

                        if (holePart != 1)
                        {
                            n = Program.MultiplyByTwo(n);
                        }
                        else
                        {
                            toStopMultiply = false;
                        }
                    }
                    else if (reminder != 0)
                    {
                        toAddLastMove = false;
                        int holePartFromReminder = reminder / 2;
                        int beLikeHolePartFromReminder = 0;
                        do
                        {
                            beLikeHolePartFromReminder = Program.AddTwo(beLikeHolePartFromReminder);
                            n = Program.AddTwo(n);
                            sequnce.Enqueue(n);
                        } while (holePartFromReminder * 2 != beLikeHolePartFromReminder);
                        if (beLikeHolePartFromReminder % reminder != 0)
                        {
                            n = Program.AddOne(n);
                            sequnce.Enqueue(n);
                        }
                    }

                } while (n != m);

                if (toAddLastMove)
                {
                    sequnce.Enqueue(m);
                }
            }

            foreach (var item in sequnce)
            {
                Console.WriteLine(item);
            }
        }
    }
}
