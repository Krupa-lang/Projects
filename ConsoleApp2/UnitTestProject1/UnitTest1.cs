using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class FrameTest
    {
        [TestMethod]
        public void TestScoreNoTrows()
        {
            Frame f = new Frame();
            Assert.AreEqual(0, f.Score);
        }

        [TestMethod]
        public void TestAddOneTrow()
        {
            Frame f = new Frame();
            f.Add(5);
            Assert.AreEqual(5, f.Score);
        }
    }
}
