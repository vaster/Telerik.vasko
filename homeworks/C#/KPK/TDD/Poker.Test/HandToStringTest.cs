using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Test
{
    [TestClass]
    public class HandToStringTest
    {
        [TestMethod]                                                                               // ♣
        public void ToString_StringEmptyHand()                                                     // ♦
        {                                                                                          // ♥
            IHand hand = new Hand(new List<ICard>());                                              // ♠

            string actual = hand.ToString();
            Assert.AreEqual(String.Empty, actual, "Tostring() method of Hand not implemented currenctly.");
        }

        [TestMethod]
        public void ToString_HandOfOneCard()
        {
            ICard jackOfDiamonds = new Card(CardFace.Jack, CardSuit.Diamonds);
            IHand hand = new Hand(new List<ICard>() { jackOfDiamonds });

            string actual = hand.ToString();
            Assert.AreEqual("J♦", actual, "Tostring() method of Hand not implemented currenctly.");
        }

        [TestMethod]
        public void ToString_HandOfTwoCards()
        {
            ICard queenOfClubs = new Card(CardFace.Queen, CardSuit.Clubs);
            ICard twoOfHearts = new Card(CardFace.Two, CardSuit.Hearts);

            IHand handOfTwo = new Hand(new List<ICard>()
            {
                queenOfClubs,
                twoOfHearts,
            });

            string actual = handOfTwo.ToString();
            Assert.AreEqual("Q♠ 2♥", actual, "Tostring() method of Hand not implemented currenctly.");
        }

        [TestMethod]
        public void ToString_HandOfThreeCards()
        {
            ICard kingOfDiamonds = new Card(CardFace.King, CardSuit.Diamonds);
            ICard queenOfClubs = new Card(CardFace.Queen, CardSuit.Clubs);
            ICard twoOfHearts = new Card(CardFace.Two, CardSuit.Hearts);

            IHand handOfThree = new Hand(new List<ICard>()
            {
                kingOfDiamonds,
                queenOfClubs,
                twoOfHearts, 
            });

            string actual = handOfThree.ToString();
            Assert.AreEqual("K♦ Q♠ 2♥", actual, "Tostring() method of Hand not implemented currenctly.");
        }

        [TestMethod]
        public void ToString_HandOfFourCards()
        {
            ICard fourOfSpades = new Card(CardFace.Four, CardSuit.Spades);
            ICard kingOfDiamonds = new Card(CardFace.King, CardSuit.Diamonds);
            ICard queenOfClubs = new Card(CardFace.Queen, CardSuit.Clubs);
            ICard twoOfHearts = new Card(CardFace.Two, CardSuit.Hearts);

            IHand handOfFour = new Hand(new List<ICard>() 
            {
                fourOfSpades,
                kingOfDiamonds,
                queenOfClubs,
                twoOfHearts,
            });

            string actual = handOfFour.ToString();
            Assert.AreEqual("4♣ K♦ Q♠ 2♥", actual, "Tostring() method of Hand not implemented currenctly.");
        }

        [TestMethod]
        public void ToString_HandOfFive()
        {
            ICard aceOfDiamonds = new Card(CardFace.Ace, CardSuit.Diamonds);
            ICard fourOfSpades = new Card(CardFace.Four, CardSuit.Spades);
            ICard kingOfDiamonds = new Card(CardFace.King, CardSuit.Diamonds);
            ICard queenOfClubs = new Card(CardFace.Queen, CardSuit.Clubs);
            ICard twoOfHearts = new Card(CardFace.Two, CardSuit.Hearts);

            IHand handOfFive = new Hand(new List<ICard>() 
            {
                aceOfDiamonds,
                fourOfSpades,
                kingOfDiamonds,
                queenOfClubs,
                twoOfHearts,
            });

            string actual = handOfFive.ToString();
            Assert.AreEqual("A♦ 4♣ K♦ Q♠ 2♥", actual, "Tostring() method of Hand not implemented currenctly.");
        }

        [TestMethod]
        public void ToString_HandOfSame()
        {
            ICard aceOfDiamonds = new Card(CardFace.Ace, CardSuit.Diamonds);

            IHand handOfSame = new Hand(new List<ICard>()
            {
                aceOfDiamonds,
                aceOfDiamonds,
                aceOfDiamonds,
            });

            string actual = handOfSame.ToString();
            Assert.AreEqual("A♦ A♦ A♦", actual, "Tostring() method of Hand not implemented currenctly.");
        }
    }
}
