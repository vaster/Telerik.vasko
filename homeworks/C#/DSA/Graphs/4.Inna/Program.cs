using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Inna
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string currBestCandidate = null;
            int currBestLikness = -1;
            int currLiknes = 0;

            for (int i = 0; i < n; i++)
            {
                currLiknes = 0;
                string[] currCandidate = Console.ReadLine().Split(' ');


                foreach (var item in currCandidate[1])
                {
                    if (item == '1')
                    {
                        currLiknes++;
                    }
                }

                if (currLiknes > currBestLikness)
                {
                    currBestLikness = currLiknes;
                    currBestCandidate = currCandidate[0];
                    if (currBestLikness == n)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(currBestCandidate);

        }
    }
}
