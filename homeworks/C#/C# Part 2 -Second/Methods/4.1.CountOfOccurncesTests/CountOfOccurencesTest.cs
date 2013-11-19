using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4.CountOfOccurences;

namespace _4._1.CountOfOccurncesTests
{
    [TestClass]
    public class CountOfOccurencesTest
    {
        [TestMethod]
        public void TestRightCount1()
        {
            int number = 4;
            int[] array = {4,4,4,4 };

            int expeceted = 4;
            int actual = Program.CountOfOccurences(array,number);

            Assert.AreEqual(expeceted,actual);
        }

        [TestMethod]
        public void TestZeroCount()
        {
            int number = 4;
            int[] array = { 1, 2, 3, -4 };

            int expeceted = 0;
            int actual = Program.CountOfOccurences(array, number);

            Assert.AreEqual(expeceted, actual);
        }
    }
}
