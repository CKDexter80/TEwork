using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Test
    {
        [TestMethod]
        public void IsLessThanOneOfAMultipleOf20()
        {
            Less20 less20 = new Less20();

            int value = 19;
            bool expected = true;
            bool actual = less20.IsLessThanMultipleOf20(value);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsLessThanTwoOfAMultipleOf20()
        {
            Less20 less20 = new Less20();

            int value = 18;
            bool expected = true;
            bool actual = less20.IsLessThanMultipleOf20(value);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(17, false)]
        [DataRow(20, false)]
        [DataRow(0, false)]
        public void IsNeitherLessThanTwoOrOneOfAMultipleOf20(int value, bool expected)
        {
            Less20 less20 = new Less20();

            
            
            bool actual = less20.IsLessThanMultipleOf20(value);

            Assert.AreEqual(expected, actual);
        }

    }
}
