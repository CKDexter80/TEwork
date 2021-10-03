using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        [DataTestMethod]
        [DataRow(new[] {1, 2, 1}, true)]
        [DataRow(new[] {1, 2, 3, 1}, true)]
        [DataRow(new[] { 1 }, true)]
        public void IsItTheSameWithSameFirstAndLastElements(int[] values, bool expected)
        {
            SameFirstLast sameFirstLast = new SameFirstLast();

            bool actual = sameFirstLast.IsItTheSame(values);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(new[] { 1, 2, 1, -1}, false)]
        [DataRow(new[] { 1, 2, 3 }, false)]
        [DataRow(new[] { 0, 1 }, false)]
        public void IsItTheSameWithDifferentFirstAndLastElements(int[] values, bool expected)
        {
            SameFirstLast sameFirstLast = new SameFirstLast();

            bool actual = sameFirstLast.IsItTheSame(values);

            Assert.AreEqual(expected, actual);
        }

    }
}
