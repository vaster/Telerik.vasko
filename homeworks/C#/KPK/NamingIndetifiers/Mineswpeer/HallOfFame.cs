using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    // This class is used to store first six results and sort them by name and score
    // + method to print them out on the console.
    public class HallOfFame
    {
        private List<Result> TopSixScores { get; set; }

        public HallOfFame()
        {
            this.TopSixScores = new List<Result>(6);
        }

        public void AddScore(Result score)
        {
            if (this.TopSixScores.Count < 5)
            {
                this.TopSixScores.Add(score);
            }
            else
            {
                for (int playerIndex = 0; playerIndex < this.TopSixScores.Count; playerIndex++)
                {
                    if (this.TopSixScores[playerIndex].Points < score.Points)
                    {
                        this.TopSixScores.Insert(playerIndex, score);
                        this.TopSixScores.RemoveAt(this.TopSixScores.Count - 1);
                        break;
                    }
                }
            }
        }

        public void PrintTopScores()
        {
            this.SortWinnersByNameAndScore();

            Console.WriteLine("\nPoints:");
            if (this.TopSixScores.Count > 0)
            {
                for (int i = 0; i < this.TopSixScores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, this.TopSixScores[i].Name, this.TopSixScores[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Hall Of Fame is empty!\n");
            }
        }

        private void SortWinnersByNameAndScore()
        {
            this.TopSixScores.Sort((Result otherResultInCollection, Result currResultInCollection) =>
                currResultInCollection.Name.CompareTo(otherResultInCollection.Name));

            this.TopSixScores.Sort((Result otherResultInCollection, Result currResultInCollection) =>
                currResultInCollection.Points.CompareTo(otherResultInCollection.Points));
        }
    }
}
