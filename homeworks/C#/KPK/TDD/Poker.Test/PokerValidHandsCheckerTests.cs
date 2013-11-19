using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Test
{
    [TestClass]
    public class PokerValidHandsCheckerTests
    {
        PokerHandsChecker validator = new PokerHandsChecker();

        [TestMethod]
        public void HandsChecker_FiveAcesIsNotValidHand()
        {
            ICard aceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);
            ICard aceOfHearts = new Card(CardFace.Ace, CardSuit.Hearts);
            ICard aceOfClubs = new Card(CardFace.Ace, CardSuit.Clubs);
            ICard aceOfDiamonds = new Card(CardFace.Ace, CardSuit.Diamonds);

            IHand hand = new Hand(new List<ICard>() 
            {
                aceOfHearts,
                aceOfDiamonds,
                aceOfSpades,
                aceOfClubs,
                aceOfSpades,
            });


            bool actual = validator.IsValidHand(hand);
            Assert.IsFalse(actual);

        }

        [TestMethod]
        public void HandsChecker_AcesOfSameSuitsAreNotValidHand()
        {
            ICard aceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);
            ICard aceOfHearts = new Card(CardFace.Ace, CardSuit.Hearts);
            ICard aceOfClubs = new Card(CardFace.Ace, CardSuit.Clubs);
            ICard aceOfDiamonds = new Card(CardFace.Ace, CardSuit.Diamonds);

            IHand handOfTwoSameSuits = new Hand(new List<ICard>() 
            { 
                aceOfClubs,
                aceOfClubs 
            });
            bool isNotValidForTwoSameSuits = validator.IsValidHand(handOfTwoSameSuits);
            /////////////////////////////////////////////////////////////////////////////

            IHand handOfThreeSameSuits = new Hand(new List<ICard>() 
            {
                aceOfHearts,
                aceOfHearts, 
                aceOfHearts 
            });
            bool isNotValidForThreeSameSuits = validator.IsValidHand(handOfThreeSameSuits);
            ///////////////////////////////////////////////////////////////////////////////

            IHand handOfFourSameSuits = new Hand(new List<ICard>() 
            { 
                aceOfDiamonds,
                aceOfDiamonds,
                aceOfDiamonds,
                aceOfDiamonds,
            });
            bool isNotValidForFourSameSuits = validator.IsValidHand(handOfFourSameSuits);
            //////////////////////////////////////////////////////////////////////////////

            IHand handsOfMorphSameSuits = new Hand(new List<ICard>() 
            {
                aceOfDiamonds,
                aceOfHearts, 
                aceOfClubs,
                aceOfDiamonds,
                aceOfSpades,
            });
            bool isNotValidForMoprhSameSuits = validator.IsValidHand(handsOfMorphSameSuits);

            bool actual =
                (
                    isNotValidForTwoSameSuits ||
                    isNotValidForThreeSameSuits ||
                    isNotValidForFourSameSuits ||
                    isNotValidForMoprhSameSuits
                );
            Assert.IsFalse(actual, String.Format
                (
                    "isNotValidForTwoSameSuits -> {0}. Expected: false.{1}", isNotValidForTwoSameSuits, Environment.NewLine +
                    "isNotValidForThreeSameSuits -> {2}. Expected: false. {3}", isNotValidForThreeSameSuits, Environment.NewLine +
                    "isNotValidForFourSameSuits -> {4}. Expected: false. {5}", isNotValidForFourSameSuits, Environment.NewLine +
                    "isNotValidForMorphSameSuits -> {6}. Expected :false. {7}", isNotValidForMoprhSameSuits, Environment.NewLine
                ));
        }

        [TestMethod]
        public void HandsChecker_HandIsFlushWithFiveSpades()
        {
            ICard aceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);
            ICard twoOfSpades = new Card(CardFace.Two, CardSuit.Spades);
            ICard sevenOfSpaces = new Card(CardFace.Seven, CardSuit.Spades);
            ICard kingOfSpades = new Card(CardFace.King, CardSuit.Spades);
            ICard jackOfSpades = new Card(CardFace.Jack, CardSuit.Spades);

            IHand handOfFlush = new Hand(new List<ICard>()
            {
                aceOfSpades,
                twoOfSpades,
                sevenOfSpaces,
                kingOfSpades,
                jackOfSpades,
            });

            bool actual = validator.IsFlush(handOfFlush);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void HandsChecker_HandIsNotFlushDiffSuits()
        {
            ICard aceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);
            ICard twoOfSpades = new Card(CardFace.Two, CardSuit.Spades);
            ICard sevenOfDiamonds = new Card(CardFace.Seven, CardSuit.Diamonds);
            ICard kingOfSpades = new Card(CardFace.King, CardSuit.Spades);
            ICard jackOfSpades = new Card(CardFace.Jack, CardSuit.Spades);

            IHand handOfNotFlush = new Hand(new List<ICard>()
            {
                aceOfSpades,
                twoOfSpades,
                sevenOfDiamonds,
                kingOfSpades,
                jackOfSpades,
            });

            bool actual = validator.IsFlush(handOfNotFlush);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void HandsChecker_HandIsNotFlushNotWithOneCard()
        {
            ICard aceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);
            IHand handOfOne = new Hand(new List<ICard>() { aceOfSpades });

            bool actual = validator.IsFlush(handOfOne);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void HandsChecker_FourAcesIsFourOfAKind()
        {
            ICard aceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);
            ICard aceOfHearts = new Card(CardFace.Ace, CardSuit.Hearts);
            ICard aceOfClubs = new Card(CardFace.Ace, CardSuit.Clubs);
            ICard aceOfDiamonds = new Card(CardFace.Ace, CardSuit.Diamonds);

            IHand handOfFourAces = new Hand(new List<ICard>() 
            { 
                aceOfClubs,
                aceOfHearts,
                aceOfDiamonds,
                aceOfSpades,
            });

            bool actual = validator.IsFourOfAKind(handOfFourAces);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void HandsChecker_FourAcesAndKingIsFourOfAKind()
        {

            ICard aceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);
            ICard aceOfHearts = new Card(CardFace.Ace, CardSuit.Hearts);
            ICard aceOfClubs = new Card(CardFace.Ace, CardSuit.Clubs);
            ICard aceOfDiamonds = new Card(CardFace.Ace, CardSuit.Diamonds);
            ICard kingOfDiamonds = new Card(CardFace.King,CardSuit.Diamonds);

            IHand handOfFourAces = new Hand(new List<ICard>() 
            { 
                aceOfClubs,
                aceOfHearts,
                kingOfDiamonds,
                aceOfDiamonds,
                aceOfSpades,
            });

            bool actual = validator.IsFourOfAKind(handOfFourAces);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void HandsChecker_ThreeKingsIsNotFourOfAKind()
        {
            ICard kingOfHearts = new Card(CardFace.King,CardSuit.Hearts);
            ICard kingOfSpades = new Card(CardFace.King,CardSuit.Spades);
            ICard kingOfDiamonds = new Card(CardFace.King,CardSuit.Diamonds);

            IHand handOfThreeKings = new Hand(new List<ICard>()
            {
                kingOfHearts,
                kingOfSpades,
                kingOfDiamonds,
            });

            bool actual = validator.IsFourOfAKind(handOfThreeKings);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void HandsChecker_ThreeQueensAndTwoJacksIsNotFourOfAKind()
        {
            ICard queenOfHearts = new Card(CardFace.Queen,CardSuit.Hearts);
            ICard queenOfSpades = new Card(CardFace.Queen, CardSuit.Spades);
            ICard queenOfDiamonds = new Card(CardFace.Queen, CardSuit.Diamonds);
            ICard jackOfClubs = new Card(CardFace.Jack,CardSuit.Clubs);
            ICard jackOfDiamonds = new Card(CardFace.Jack,CardSuit.Diamonds);

            IHand handOfHouse = new Hand(new List<ICard>() 
            {
                 queenOfHearts,
                 queenOfSpades,
                 queenOfDiamonds,
                 jackOfClubs,
                 jackOfDiamonds, 
            });

            bool actual = validator.IsFourOfAKind(handOfHouse);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void HandsChecker_ThreeAcesAndKingIsNotFourOfAKind()
        {

            ICard aceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);
            ICard aceOfHearts = new Card(CardFace.Ace, CardSuit.Hearts);
            ICard aceOfClubs = new Card(CardFace.Ace, CardSuit.Clubs);
            ICard kingOfDiamonds = new Card(CardFace.King, CardSuit.Diamonds);

            IHand handOfThreeAcesAndKing = new Hand(new List<ICard>() 
            { 
                aceOfClubs,
                aceOfHearts,
                kingOfDiamonds,
                aceOfSpades,
            });

            bool actual = validator.IsFourOfAKind(handOfThreeAcesAndKing);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void HandsChecker_OneAceIsNotFourOfAkind()
        {
            ICard aceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);
            IHand handOfOne = new Hand(new List<ICard>() { aceOfSpades });

            bool actual = validator.IsFourOfAKind(handOfOne);
            Assert.IsFalse(actual);
        }
    }
}
