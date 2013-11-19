using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Test
{
    [TestClass]
    public class CardToStringTest
    {
        [TestMethod]
        public void ToString_CardIsSevenOfSpades()
        {
            ICard sevenOfSpades = new Card(CardFace.Seven, CardSuit.Spades);

            string actual = sevenOfSpades.ToString();
            Assert.AreEqual("7♣", actual, "Tostring() method of Card not implemented currenctly.");

        }

        [TestMethod]
        public void ToString_CardIsAceOfHearts()
        {
            ICard aceOfHearts = new Card(CardFace.Ace, CardSuit.Hearts);

            string actual = aceOfHearts.ToString();
            Assert.AreEqual("A♥", actual, "Tostring() method of Card not implemented currenctly.");
        }

        [TestMethod]
        public void ToString_CardIsTenOfDiamonds()
        {
            ICard tenOfDiamonds = new Card(CardFace.Ten, CardSuit.Diamonds);

            string actual = tenOfDiamonds.ToString();
            Assert.AreEqual("10♦", actual, "Tostring() method of Card not implemented currenctly.");
        }

        [TestMethod]
        public void ToString_CardIsKingOfClubs()
        {
            ICard kingOfClubs = new Card(CardFace.King, CardSuit.Clubs);

            string actual = kingOfClubs.ToString();
            Assert.AreEqual("K♠", actual, "Tostring() method of Card not implemented currenctly.");
        }
    }
}
