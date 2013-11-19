using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1.SayHello;

namespace _1._1.SayHelloTests
{
    [TestClass]
    public class SayHelloTests
    {
        [TestMethod]
        public void TestPeter()
        {
            string name = "Peter";
            string result = Program.SayHelloAsString(name);

            string actual = "Hello, " + name;

            Assert.AreEqual(result,actual);
        }

        [TestMethod]
        public void TestIvan()
        {
            string name = "Ivan";
            string result = Program.SayHelloAsString(name);

            string actual = "Hello, " + name;

            Assert.AreEqual(result, actual);
        }
    }
}
