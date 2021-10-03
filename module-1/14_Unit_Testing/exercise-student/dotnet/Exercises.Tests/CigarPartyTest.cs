using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]

    public class CigarPartyTest
    {
        [TestMethod]
        public void HavePartyOnWeekDayWithFewerThanFortyCigars()
        {
            CigarParty cigarParty = new CigarParty();

            int cig = 30;
            bool isW = false;
            bool expected = false;
            bool actual = cigarParty.HaveParty(cig, isW);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void HavePartyOnWeekDayWithMoreThanFortyCigarsAndFewerThanSixty()
        {            
            CigarParty cigarParty = new CigarParty();

            int cig = 50;
            bool isW = false;
            bool expected = true;
            bool actual = cigarParty.HaveParty(cig, isW);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HavePartyOnWeekEndWithMoreThanFortyCigars()
        {
            CigarParty cigarParty = new CigarParty();

            int cig = 50;
            bool isW = true;
            bool expected = true;
            bool actual = cigarParty.HaveParty(cig, isW);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void HavePartyOnWeekEndWithNegative()
        {
            CigarParty cigarParty = new CigarParty();

            int cig = -50;
            bool isW = true;
            bool expected = false;
            bool actual = cigarParty.HaveParty(cig, isW);

            Assert.AreEqual(expected, actual);

        }
    }
}
