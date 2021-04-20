using ArabicToRomanNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ArabicToRomanNumbersTests
{
    [TestClass]
    public class ArabicToRomanNumbersTest
    {
        [TestMethod]
        public void CheckIfOneConvertsToI()
        {
            Assert.AreEqual("I", ArabicToRomanNumbersConverter.Convert(1));
        }

        [TestMethod]
        public void CheckIfTwoConvertsToII()
        {
            Assert.AreEqual("II", ArabicToRomanNumbersConverter.Convert(2));
        }

        [TestMethod]
        public void CheckIfThreeConvertsToIII()
        {
            Assert.AreEqual("III", ArabicToRomanNumbersConverter.Convert(3));
        }

        [TestMethod]
        public void CheckIfFourConvertsToIV()
        {
            Assert.AreEqual("IV", ArabicToRomanNumbersConverter.Convert(4));
        }

        [TestMethod]
        public void CheckIfFiveConvertsToV()
        {
            Assert.AreEqual("V", ArabicToRomanNumbersConverter.Convert(5));
        }

        [TestMethod]
        public void CheckIfNineConvertsToIX()
        {
            Assert.AreEqual("IX", ArabicToRomanNumbersConverter.Convert(9));
        }

        [TestMethod]
        public void CheckIfTenConvertsToX()
        {
            Assert.AreEqual("X", ArabicToRomanNumbersConverter.Convert(10));
        }

        [TestMethod]
        public void CheckIfTwentyConvertsToXX()
        {
            Assert.AreEqual("XX", ArabicToRomanNumbersConverter.Convert(20));
        }

        [TestMethod]
        public void CheckIfThirtyConvertsToXXX()
        {
            Assert.AreEqual("XXX", ArabicToRomanNumbersConverter.Convert(30));
        }

        [TestMethod]
        public void CheckIfNinetyConvertsToXC()
        {
            Assert.AreEqual("XC", ArabicToRomanNumbersConverter.Convert(90));
        }

        [TestMethod]
        public void CheckIfNinetynineConvertsToXCIX()
        {
            Assert.AreEqual("XCIX", ArabicToRomanNumbersConverter.Convert(99));
        }

        [TestMethod]
        public void CheckIfFiftyConvertsToL()
        {
            Assert.AreEqual("L", ArabicToRomanNumbersConverter.Convert(50));
        }

        [TestMethod]
        public void CheckIfHundredConvertsToC()
        {
            Assert.AreEqual("C", ArabicToRomanNumbersConverter.Convert(100));
        }

        [TestMethod]
        public void CheckIfFivehundredConvertsToD()
        {
            Assert.AreEqual("D", ArabicToRomanNumbersConverter.Convert(500));
        }

        [TestMethod]
        public void CheckIfNinehundredConvertsToCM()
        {
            Assert.AreEqual("CM", ArabicToRomanNumbersConverter.Convert(900));
        }

        [TestMethod]
        public void CheckIfThousandConvertsToM()
        {
            Assert.AreEqual("M", ArabicToRomanNumbersConverter.Convert(1000));
        }

        [TestMethod]
        public void CheckIfTwothousandseventeenConvertsToMMXVII()
        {
            Assert.AreEqual("MMXVII", ArabicToRomanNumbersConverter.Convert(2017));
        }

        [TestMethod]
        public void CheckIfNegativeInputIsException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            { ArabicToRomanNumbersConverter.Convert(-1); });
        }

        [TestMethod]
        public void CheckIfZeroIsException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            { ArabicToRomanNumbersConverter.Convert(0); });
        }

        [TestMethod]
        public void CheckIfFourthousandIsException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            { ArabicToRomanNumbersConverter.Convert(4000); });
        }
    }
}
