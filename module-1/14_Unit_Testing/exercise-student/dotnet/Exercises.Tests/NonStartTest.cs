using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        [DataTestMethod]
        [DataRow("Hello", "There", "ellohere")]
        [DataRow("java", "code", "avaode")]
        [DataRow("shotl", "java", "hotlava")]
        public void GetPartialStringFromStringsWithLengthsOfAtLeastTwo(string a, string b, string expected)
        {
            NonStart nonStart = new NonStart();

            string actual = nonStart.GetPartialString(a, b);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("He", "Th", "eh")]
        [DataRow("j", "c", "")]
        [DataRow("sh", "j", "h")]
        [DataRow("AR", "Gobert", "Robert")]
        public void GetPartialStringFromStringsWithLengthsOfAtMostTwo(string a, string b, string expected)
        {
            NonStart nonStart = new NonStart();

            string actual = nonStart.GetPartialString(a, b);
            Assert.AreEqual(expected, actual);
        }
              
        
    }
}
