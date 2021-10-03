using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{   
    [TestClass]
    public class Lucky13Test
    {
        [TestMethod]
        public void GetLuckyWithArrayContainingAOne()
        {
            Lucky13 lucky13 = new Lucky13();

            int[] valueArr = { 1, 2, 4 };
            bool expected = false;
            bool actual = lucky13.GetLucky(valueArr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLuckyWithArrayContainingAThree()
        {
            Lucky13 lucky13 = new Lucky13();

            int[] valueArr = { 7, 2, 3};
            bool expected = false;
            bool actual = lucky13.GetLucky(valueArr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLuckyWithArrayContainingNeitherAOneOrAThree()
        {
            Lucky13 lucky13 = new Lucky13();

            int[] valueArr = { 0, 2, 44};
            bool expected = true;
            bool actual = lucky13.GetLucky(valueArr);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetLuckyWithArrayContainingAOneAndAThree()
        {
            Lucky13 lucky13 = new Lucky13();

            int[] valueArr = { 1, 2, 3 };
            bool expected = false;
            bool actual = lucky13.GetLucky(valueArr);

            Assert.AreEqual(expected, actual);
        }
    }
}
