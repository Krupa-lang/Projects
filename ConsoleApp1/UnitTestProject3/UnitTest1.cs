using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nullArray = PrimeGenerator.GeneratePrimeNumbers(0);
            Assert.AreEqual(nullArray.Length, 0);

            int[] minArray = PrimeGenerator.GeneratePrimeNumbers(2);
            Assert.AreEqual(minArray.Length, 1);
            Assert.AreEqual(minArray[0], 2);

            int[] treeArray = PrimeGenerator.GeneratePrimeNumbers(3);
            Assert.AreEqual(treeArray.Length, 2);
            Assert.AreEqual(treeArray[0], 2);
            Assert.AreEqual(treeArray[1], 3);

            int[] centArray = PrimeGenerator.GeneratePrimeNumbers(100);
            Assert.AreEqual(centArray.Length, 25);
            Assert.AreEqual(centArray[24], 97);
        }
    }
}
