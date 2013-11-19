using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            for (int currCardIndex = 0; currCardIndex < hand.Cards.Count; currCardIndex++)
            {
                for (int cardIndex = currCardIndex + 1; cardIndex < hand.Cards.Count; cardIndex++)
                {
                    if (hand.Cards[currCardIndex].ToString().Equals(hand.Cards[cardIndex].ToString()))
                    {

                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        { 
            if (hand.Cards.Count < 4)
            {
                return false;
            }

            for (int templateCardIndex = 0; templateCardIndex < 2; templateCardIndex++)
            {
                int fourOfKindCount = 0;

                for (int cardIndex = 0; cardIndex < hand.Cards.Count; cardIndex++)
                {
                    if (hand.Cards[templateCardIndex].Face == hand.Cards[cardIndex].Face)
                    {
                        fourOfKindCount++;
                    }
                }
                if (fourOfKindCount == 4)
                {
                    return true;
                }
            }
               
            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (hand.Cards.Count < 5)
            {
                return false;
            }
            else
            {
                CardSuit templateSuit = hand.Cards[0].Suit;

                foreach (ICard card in hand.Cards)
                {
                    if (templateSuit != card.Suit)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
