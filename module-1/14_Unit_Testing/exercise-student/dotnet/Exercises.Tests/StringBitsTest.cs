using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]   
    public class StringBitsTest
    {
        [DataTestMethod]
        [DataRow("Hello", "Hlo")]
        [DataRow("Heeololeo", "Hello")]
        [DataRow("XoXoXoX", "XXXX")]
        public void GetBitsUsingStringsLongerThanTwo(string input, string expected)
        {
            StringBits stringBits = new StringBits();

            string actual = stringBits.GetBits(input);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("Hi", "H")]
        [DataRow("H", "H")]
        [DataRow("", "")]
        public void GetBitsUsingStringsShorterThanThreeIncludingEmpty(string input, string expected)
        {
            StringBits stringBits = new StringBits();

            string actual = stringBits.GetBits(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
