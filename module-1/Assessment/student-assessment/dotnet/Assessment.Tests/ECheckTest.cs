using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Tests
{
    [TestClass]

    public class ECheckTest
    {
        [TestMethod]
        public void ECheck()
        {

            Assessment.Car c = new Assessment.Car(2004, "Kia", false);

            bool expected = true;
            bool actual = c.IsInNeedOfECheck(2022);

            Assert.AreEqual(expected, actual);
        }
    }
}
