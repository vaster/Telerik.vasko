using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Program
    {
        public static void ReadOpositions(Dictionary<string, int> positionsRating)
        {
            int posCount = int.Parse(Console.ReadLine());

            string[] jobRatingPair = null;
            for (int i = 0; i < posCount; i++)
            {
                jobRatingPair = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                if (!positionsRating.ContainsKey(jobRatingPair[0].Trim()))
                {
                    positionsRating.Add(jobRatingPair[0].Trim(), int.Parse(jobRatingPair[1]));
                }

            }
        }

        static void ReadEmplyeesPositions(Dictionary<string, List<string>> personPosition)
        {
            int posCount = int.Parse(Console.ReadLine());

            string[] personPositionPair = null;
            string[] personNames = null;
            StringBuilder reversedOrderOfPersonName = new StringBuilder();
            for (int i = 0; i < posCount; i++)
            {
                personPositionPair = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                personNames = personPositionPair[0].Split(' ');
                reversedOrderOfPersonName.Append(personNames[1]);
                reversedOrderOfPersonName.Append(" ");
                reversedOrderOfPersonName.Append(personNames[0]);

                if (personPosition.ContainsKey(personPositionPair[1].Trim()))
                {
                    personPosition[personPositionPair[1].Trim()].Add(reversedOrderOfPersonName.ToString());
                }
                else
                {
                    personPosition.Add(personPositionPair[1].Trim(), new List<string>() { reversedOrderOfPersonName.ToString() });
                }

                reversedOrderOfPersonName.Clear();
            }
        }

        static StringBuilder SortPersonByRatingAndName(Dictionary<string, int> jobsByRating, Dictionary<string, List<string>> jobsAndPersons)
        {
            SortedDictionary<int, List<string>> ratingAndNames = new SortedDictionary<int, List<string>>();
            StringBuilder result = new StringBuilder();

            int rating = 0;
            List<string> names = null;
            bool toExecute = false;
            foreach (var job in jobsByRating.Keys)
            {
                if (jobsByRating.ContainsKey(job) && jobsAndPersons.ContainsKey(job))
                {
                    rating = jobsByRating[job];
                    names = jobsAndPersons[job];

                    if (ratingAndNames.ContainsKey(rating))
                    {

                        ratingAndNames[rating].AddRange(names);
                    }
                    else
                    {

                        ratingAndNames.Add(rating, names);
                    }
                    toExecute = true;

                    ratingAndNames[rating].Sort();
                }

            }
            if (toExecute)
            {
                foreach (var pair in ratingAndNames.Reverse())
                {
                    foreach (var personName in pair.Value)
                    {
                        string[] reorderNames = personName.Split(' ');

                        result.AppendLine(reorderNames[1] + ' ' + reorderNames[0]);
                    }

                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Dictionary<string, int> jobsByRating = new Dictionary<string, int>();
            Dictionary<string, List<string>> jobsAndEmployees = new Dictionary<string, List<string>>();


            Program.ReadOpositions(jobsByRating);

            Program.ReadEmplyeesPositions(jobsAndEmployees);

            StringBuilder result = Program.SortPersonByRatingAndName(jobsByRating, jobsAndEmployees);

            Console.WriteLine(result);
        }
    }
}
