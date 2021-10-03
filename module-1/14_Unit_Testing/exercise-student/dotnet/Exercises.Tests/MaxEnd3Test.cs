using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Test
    {
        [TestMethod]
        public void MakeArrayAndFirstValueIsLargest()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();

            int[] values = { 11, 2, 3 };
            int[] expected = { 11, 11, 11 };
            int[] actual = maxEnd3.MakeArray(values);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakeArrayAndSecondValueIsLargest()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();

            int[] values = { 2, 11, 3 };
            int[] expected = { 3, 3, 3 };
            int[] actual = maxEnd3.MakeArray(values);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakeArrayAndLastValueIsLargest()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();

            int[] values = { 1, 2, 3 };
            int[] expected = { 3, 3, 3 };
            int[] actual = maxEnd3.MakeArray(values);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakeArrayAndAllAreEqual()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();

            int[] values = { 13, 13, 13 };
            int[] expected = { 13, 13, 13 };
            int[] actual = maxEnd3.MakeArray(values);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakeArrayAndIncludeNegatives()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();

            int[] values = { -13, 18, 0 };
            int[] expected = { 0, 0, 0 };
            int[] actual = maxEnd3.MakeArray(values);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
