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
            /*
             haveParty(30, false) → false
        haveParty(50, false) → true
        haveParty(70, true) → true
            */
            CigarParty cigarParty = new CigarParty();

            int ciga = 50;
            bool isWe = false;
            bool expectedW = true;
            bool actualW = cigarParty.HaveParty(ciga, isWe);

            Assert.AreEqual(expectedW, actualW);
        }
        [TestMethod]
        public void HavePartyOnWeekEndWithMoreThanFortyCigars()
        {
            /*
             haveParty(30, false) → false
        haveParty(50, false) → true
        haveParty(70, true) → true
            */
            CigarParty cigarParty = new CigarParty();

            int cigar = 50;
            bool isWee = false;
            bool expectedW = true;
            bool actualW = cigarParty.HaveParty(ciga, isWe);

            Assert.AreEqual(expectedW, actualW);

        }
    }
}
