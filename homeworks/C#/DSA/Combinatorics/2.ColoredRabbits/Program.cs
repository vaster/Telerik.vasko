using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ColoredRabbits
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> answers = new List<int>();
            int currAnswer = 0;
            int sum = 0;
            Dictionary<int, int> countTracker = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                currAnswer = int.Parse(Console.ReadLine());

                if (answers.Contains(currAnswer))
                {
                    countTracker[currAnswer]++;
                }

                if (!answers.Contains(currAnswer))
                {
                    countTracker.Add(currAnswer, 1);
                    answers.Add(currAnswer);

                    sum = sum + currAnswer + 1;
                }

                if (countTracker.ContainsKey(currAnswer))
                {
                    if (countTracker[currAnswer] == currAnswer + 1)
                    {
                        answers.Remove(currAnswer);
                        countTracker.Remove(currAnswer);
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
