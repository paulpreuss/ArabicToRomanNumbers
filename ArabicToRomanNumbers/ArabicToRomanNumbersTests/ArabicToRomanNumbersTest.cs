using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArabicToRomanNumbersTests
{
    [TestClass]
    public class ArabicToRomanNumbersTests
    {
        [TestMethod]
        public void CheckIfOneConvertsToI()
        {
            Assert.AreEqual("I", Converter.Convert(1));
        }

        [TestMethod]
        public void CheckIfTwoConvertsToII()
        {
            Assert.AreEqual("II", Converter.Convert(2));
        }

        [TestMethod]
        public void CheckIfThreeConvertsToIII()
        {
            Assert.AreEqual("III", Converter.Convert(3));
        }

        [TestMethod]
        public void CheckIfFourConvertsToIV()
        {
            Assert.AreEqual("IV", Converter.Convert(4));
        }

        [TestMethod]
        public void CheckIfFiveConvertsToV()
        {
            Assert.AreEqual("V", Converter.Convert(5));
        }

        [TestMethod]
        public void CheckIfNineConvertsToIX()
        {
            Assert.AreEqual("IX", Converter.Convert(9));
        }

        [TestMethod]
        public void CheckIfTenConvertsToX()
        {
            Assert.AreEqual("X", Converter.Convert(10));
        }

        [TestMethod]
        public void CheckIfTwentyConvertsToXX()
        {
            Assert.AreEqual("XX", Converter.Convert(20));
        }

        [TestMethod]
        public void CheckIfThirtyConvertsToXXX()
        {
            Assert.AreEqual("XXX", Converter.Convert(30));
        }

        [TestMethod]
        public void CheckIfNinetyConvertsToXC()
        {
            Assert.AreEqual("XC", Converter.Convert(90));
        }

        [TestMethod]
        public void CheckIfNinetynineConvertsToXCIX()
        {
            Assert.AreEqual("XCIX", Converter.Convert(99));
        }

        [TestMethod]
        public void CheckIfFiftyConvertsToL()
        {
            Assert.AreEqual("L", Converter.Convert(50));
        }

        [TestMethod]
        public void CheckIfHundredConvertsToC()
        {
            Assert.AreEqual("C", Converter.Convert(100));
        }

        [TestMethod]
        public void CheckIfFivehundredConvertsToD()
        {
            Assert.AreEqual("D", Converter.Convert(500));
        }

        [TestMethod]
        public void CheckIfNinehundredConvertsToCM()
        {
            Assert.AreEqual("CM", Converter.Convert(900));
        }

        [TestMethod]
        public void CheckIfThousandConvertsToM()
        {
            Assert.AreEqual("M", Converter.Convert(1000));
        }

        [TestMethod]
        public void CheckIfTwothousandseventeenConvertsToMMXVII()
        {
            Assert.AreEqual("MMXVII", Converter.Convert(2017));
        }

        [TestMethod]
        public void CheckIfNegativeInputIsException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            { Converter.Convert(-1); });
        }

        [TestMethod]
        public void CheckIfZeroIsException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            { Converter.Convert(0); });
        }

        [TestMethod]
        public void CheckIfFourthousandIsException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            { Converter.Convert(4000); });
        }
    }
}
