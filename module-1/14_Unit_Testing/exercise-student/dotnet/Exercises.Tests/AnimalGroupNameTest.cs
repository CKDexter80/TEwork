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

            string inputL = "giraffe";

            string expectedL = animalGroupName.GetHerd(inputL);
            string actualL = "Tower";

            Assert.AreEqual(expectedL, actualL);
        }

        [TestMethod]
        public void GetHerdWithUppercaseString()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string inputU = "FLAMINGO";

            string expectedU = animalGroupName.GetHerd(inputU);
            string actualU = "Pat";

            Assert.AreEqual(expectedU, actualU);
        }
        [TestMethod]
        public void GetHerdWithMixedcaseString()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string inputM = "Rhino";

            string expectedM = animalGroupName.GetHerd(inputM);
            string actualM = "Crash";

            Assert.AreEqual(expectedM, actualM);
        }
        [DataTestMethod]
        [DataRow("walrus", "unknown")]
        [DataRow("elephants", "unknown")]        
        public void GetHerdWithNotFound(string input, string returned)
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string inputNF = input;
            string actualNF = animalGroupName.GetHerd(inputNF);
            string expectedNF = returned;

            Assert.AreEqual(expectedNF, actualNF);
        }
        [TestMethod]
        public void GetHerdWithNull()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string inputN = null;

            string expectedN = animalGroupName.GetHerd(inputN);
            string actualN = "unknown";

            Assert.AreEqual(expectedN, actualN);
        }
        [TestMethod]
        public void GetHerdWithEmpty()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string inputE = "";

            string expectedE = animalGroupName.GetHerd(inputE);
            string actualE = "unknown";

            Assert.AreEqual(expectedE, actualE);
        }
    }
}
