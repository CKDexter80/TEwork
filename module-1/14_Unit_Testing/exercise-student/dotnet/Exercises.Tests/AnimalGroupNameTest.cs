using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
        [TestMethod]
        public void GetHerdWithLowercaseString()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string input = "giraffe";

            string expected = animalGroupName.GetHerd(input);
            string actual = "Tower";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetHerdWithUppercaseString()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string input = "FLAMINGO";

            string expected = animalGroupName.GetHerd(input);
            string actual = "Pat";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetHerdWithMixedcaseString()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string input = "Rhino";

            string expected = animalGroupName.GetHerd(input);
            string actual = "Crash";

            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow("walrus", "unknown")]
        [DataRow("elephants", "unknown")]
        public void GetHerdWithStringsNotFound(string input, string returned)
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
                        
            string actual = animalGroupName.GetHerd(input);
            string expected = returned;

            Assert.AreEqual(expected, actual);
        }
        /*[TestMethod]
        public void GetHerdWithNull()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string input = null;

            string expected = animalGroupName.GetHerd(input);
            string actual = "unknown";

            Assert.AreEqual(expected, actual);
        }*/
        [TestMethod]
        public void GetHerdWithEmptyString()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string input = "";

            string expected = animalGroupName.GetHerd(input);
            string actual = "unknown";

            Assert.AreEqual(expected, actual);
        }
    }
}
