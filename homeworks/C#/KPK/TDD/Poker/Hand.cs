using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.Cards.Count == 0)
            {
                return String.Empty;
            }

            for (int cardIndex = 0; cardIndex < this.Cards.Count-1; cardIndex++)
            {
                result.Append(this.Cards[cardIndex] + " ");
            }

            result.Append(this.Cards[this.Cards.Count-1]);
            return result.ToString();
        }
    }
}
