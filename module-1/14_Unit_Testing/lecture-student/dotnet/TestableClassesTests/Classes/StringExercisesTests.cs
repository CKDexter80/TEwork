using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class StringExercisesTests
    {
        //Assert
        //.AreEqual() - compares expected and actual value for equality
        //.AreSame() - verifies two object variables refer to same object
        //.AreNotSame() - verifies two object variables refer to different objects
        //.Fail() - fails without checking conditions
        //.IsFalse()
        //.IsTrue()
        //.IsNotNull()
        //.IsNull()

        [TestMethod]        
        public void MakeAbba()
        {
            /*
             makeAbba("Hi", "Bye") → "HiByeByeHi"
        makeAbba("Yo", "Alice") → "YoAliceAliceYo"
        makeAbba("What", "Up") → "WhatUpUpWhat"
             */

            StringExercises sa = new StringExercises();

            string parm1 = "Hi";
            string parm2 = "Bye";
            string acutal = sa.MakeAbba(parm1, parm2);
            string expected = "HiByeByeHi";

            Assert.AreEqual(expected, acutal, "message");

        }

        [TestMethod]
        [DataRow("Hello", "He")]
        [DataRow("abcdefg", "ab")]
        [DataRow("a", "a")]
        public void FirstTwoDataRow(string parameter, string expected)
        {
            StringExercises sa = new StringExercises();

            string actual = sa.FirstTwo(parameter);
            Assert.AreEqual(expected, actual);
        }
    }
}