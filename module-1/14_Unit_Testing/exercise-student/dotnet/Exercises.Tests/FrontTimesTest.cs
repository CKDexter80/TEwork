using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]

    public class FrontTimesTest
    {
        [DataTestMethod]
        [DataRow("Chocolate", 2, "ChoCho")]
        [DataRow("Chocolate", 3, "ChoChoCho")]
        [DataRow("Abc", 3, "AbcAbcAbc")]
        [DataRow("HiMikeLevy", 0, "")]
        public void GenerateStringFromStringOfAtLeastThreeCharacters(string fullStr, int repeat, string expected)
        {
            FrontTimes frontTimes = new FrontTimes();

            string actual = frontTimes.GenerateString(fullStr, repeat);

            Assert.AreEqual(expected, actual);

        }
        [DataTestMethod]
        [DataRow("Wa", 2, "WaWa")]
        [DataRow("", 4, "")]
        [DataRow("Z", 3, "ZZZ")]
        public void GenerateStringFromStringOfUnderThreeCharacters(string fullStr, int repeat, string expected)
        {
            FrontTimes frontTimes = new FrontTimes();

            string actual = frontTimes.GenerateString(fullStr, repeat);

            Assert.AreEqual(expected, actual);

        }
    }

}
