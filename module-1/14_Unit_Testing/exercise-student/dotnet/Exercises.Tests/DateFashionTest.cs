using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTest
    {
        DateFashion dateFashion = new DateFashion();

        [DataTestMethod]
        [DataRow(5, 2, 0)]
        [DataRow(10, 0, 0)]
        [DataRow(2, 1, 0)]
        public void GetATableWithOnePersonNotStylish(int myself, int date, int expected)
        {
            int actual = dateFashion.GetATable(myself, date);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(5, 5, 1)]
        [DataRow(3, 7, 1)]
        [DataRow(6, 4, 1)]
        public void GetATableWithTwoPeopleModeratelyStylish(int myself, int date, int expected)
        {
            int actual = dateFashion.GetATable(myself, date);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(10, 5, 2)]
        [DataRow(8, 8, 2)]
        [DataRow(6, 9, 2)]
        public void GetATableWithOnePersonVeryStylishAndOneModerately(int myself, int date, int expected)
        {
            int actual = dateFashion.GetATable(myself, date);

            Assert.AreEqual(expected, actual);
        }
    }   
}
